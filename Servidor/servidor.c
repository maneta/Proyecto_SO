/*
 *Alumnos:
 *Hamilton Daniel Cesario
 *Ernesto Jimenez
 *Christian Lopez
 */

#include <my_global.h>
#include <string.h>
#include <mysql.h>
#include <time.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>
#include <sys/wait.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <netdb.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <arpa/inet.h>
#include <pthread.h>

#define MAX 200
#define MAX_THREADS 10

/*........ Inicio de las estructuras .......*/

typedef struct {

       int conexion;
       char nombre [20];
 } Tusuario;

 typedef struct {
       int num;
       Tusuario usuarios [MAX];
 } Tlista;
 
 /*......Estructuras responsables por la invitación y jugadas......*/
 typedef struct {
       char nombre [20];
 } Tjugador;

 typedef struct {
       /*Los valores de num solamente serán 0-->X, o 1-->O
       * Los invitadores serán siempre num=0-->X y los invitados num=1-->O
       */
       int num;
       Tjugador jugadores [MAX];
 } TlistaJugadores;
 
/*......Fin de las estructuras de las Jugadas......*/ 

/*.........Fin de las estructuras........*/

/*Asignacion Global de la Lista*/

Tlista mi_lista;
Tusuario t;

/*Asignacion Global de las Estructuras de jugada*/

Tjugador PLAYER;
TlistaJugadores PLAYERLIST;

/*........Defino variables globales.....*/

MYSQL *conn;
MYSQL_RES *resultado;
MYSQL_ROW row;

/* Declaro la variable global "semaforo" del tipo pthread_mutex_t.*/
pthread_mutex_t semaforo; 

/*Contador Global threads*/
int T;
int IDPARTIDA;

void crea_base_datos()
{
       int err;

       /*Ahora creo la base de datos, que se llamara jugadoresPartidas
       primero la borramos si es que ya existe*/

       mysql_query(conn, "DROP DATABASE IF EXISTS Proyecto;");
       err=mysql_query(conn, "CREATE DATABASE Proyecto;");
       if (err!=0)
       {
              printf ("Error al crear la base de datos %u %s\n", mysql_errno(conn), mysql_error(conn));
              exit (1);
       }

       //indicamos la base de datos con la que queremos trabajar

       err=mysql_query(conn, "USE Proyecto;");
       if (err!=0)
       {
              printf ("No se ha indicado correctamente la base de datos, existe el siguiente problema: %u %s\n", mysql_errno(conn), mysql_error(conn));
              exit (1);
       }

       // Creamos las diferentes tablas de de nuestra base de datos
       err=mysql_query(conn,"CREATE TABLE Jugador(Nombre VARCHAR(10) not null PRIMARY KEY,password VARCHAR(10)NOT NULL)TYPE=InnoDB;");
       if (err!=0)
       {
              printf ("Error al definir la tabla Jugador %u %s\n", mysql_errno(conn), mysql_error(conn));
              exit (1);
       }

       err=mysql_query(conn,"CREATE TABLE Partida(Identificador INTEGER PRIMARY KEY AUTO_INCREMENT, fecha TIMESTAMP DEFAULT NOW(),duracion INTEGER, ganador VARCHAR(10))TYPE=InnoDB;");
       if (err!=0)
       {
              printf ("Error al definir la tabla Partida %u %s\n", mysql_errno(conn), mysql_error(conn));
              exit (1);
       }

       err=mysql_query(conn,"CREATE TABLE Relacion(Nom VARCHAR(10),Id INTEGER, FOREIGN KEY(Nom) REFERENCES Jugador(Nombre),FOREIGN KEY(Id) REFERENCES Partida(Identificador))TYPE=InnoD;");
       if (err!=0)
       {
              printf ("Error al definir la tabla Relacion %u %s\n", mysql_errno(conn), mysql_error(conn));
              exit (1);
       }
       printf("Se han creado correctamente las tablas de la base de datos \n");
}



 int conexion_a_sql() // Conectamos con sql
 {
       conn = mysql_init(NULL);
       /*Creamos una conexion al servidor MYSQL*/
       
       if (conn == NULL) {
              printf("Error al crear la conexiÃƒÂ³n: %u %s\n", mysql_errno(conn),
              mysql_error(conn));
              exit(1);
              return -1;
       }

       /*inicializar la conexiÃƒÂ³n, entrando nuestras claves de acceso */
       conn = mysql_real_connect(conn, "localhost", "root", "mimara",NULL, 0,NULL, 0);
       if (conn == NULL) {
              printf("Error al inicializar la conexiÃƒÂ³n: %u %s\n", mysql_errno(conn),
              mysql_error(conn));
              return -1;
              exit(1);
       }
       return 1;
 }


int socket_treat(int code)
{
       int sock, con, clnt_len, port, len, fd, remote_addr_len;
       int s,r;

       struct sockaddr_in serv_adr, remote_addr;

       if(code == 0){
       printf ("Creando el socket\n");

       //AF_INET indica que se estÃƒÂ¡ creando un socket de familia IPV4, SOCK_STREAM indica socket orientado a conexiÃƒÂ³n(TCP)
       s=socket(AF_INET, SOCK_STREAM, 0);

       if (s==-1) {
              //Interpreta la variable errno
              perror("socket");
              exit(-1);
       }
       printf ("Listo\n");

       /********** Fem el bind al port amb INADDR_ANY */
       serv_adr.sin_family = AF_INET;
       serv_adr.sin_port = htons(50001);
       serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);


       printf ("Aplicando el bind\n");

       r=bind(s, (struct sockaddr *) &serv_adr, sizeof(serv_adr));
       if (r==-1) {
              perror("bind");
    	      exit(-1);
       }

       /********** Limitem el nombre de connexions pendents, la cua d'espera */

       r=listen(s, 4);
       if (r==-1) {
    	      perror("listen");
    	      exit(-1);
       }

       //printf ("Esperando connexion\n");
       //emote_addr_len=sizeof(remote_addr);
       //con=accept(s,(struct sockaddr *)&remote_addr, &remote_addr_len);
       //printf ("connexio de %s:%d\n", inet_ntoa(remote_addr.sin_addr), ntohs(remote_addr.sin_port));

       return s;
       
       }else if(code == 3){
            printf ("desconnexion\n");
            close (s);
            close (con);
       }
}

int identify(char buf[MAX])
{
       int code;
       sscanf (buf, "%d/ ", &code);

       return code;
}

// Funcion nuevo usuario...

int new_user(char buf[MAX])
{


       int err, code;
       char buf2[MAX];
       char consulta[MAX];
       char user[40];
       char password[20];
       int i;

       // Cargamos lo que nos llega del cliente a traves de la variable buf a las variables code, user y password
       sscanf (buf,"%d  %s  %s",&code, user, password); 
       printf("%s\n\n",buf);
       //insertamos los valores que hemos cargado en la variable user y password en la base de datos
       sprintf(consulta,"INSERT INTO Jugador (Nombre,password) VALUES ('%s','%s')",user,password); 
       printf("%s\n",consulta);
       printf("%s\\ %s \n\n",user,password);

       err=mysql_query(conn, consulta); 
       //err=0;
       printf("%d",err);
       printf("%d",err);
	   if(err!=0){
              printf("Se ha producido algun error en la introduccion de los datos %u %s \n",mysql_errno(conn),mysql_error(conn));
              return -1;
              }
	   else
	   {
	      return 0;
	      printf("Hemos anadido al usuario correctamente \n");
	   }

}

int baja_user(char buf[MAX])
{


       int err, code;
       char buf2[MAX];
       char consulta[MAX];
       char user[40];
       char password[20];
       int i;

       // Cargamos lo que nos llega del cliente a traves de la variable buf a las variables code, user y password
       sscanf (buf,"%d  %s  %s",&code, user, password); 
       printf("%s\n\n",buf);
       //insertamos los valores que hemos cargado en la variable user y password en la base de datos
       sprintf(consulta,"DELETE FROM Jugador WHERE Nombre= '%s';",user); 
       printf("%s\n",consulta);
       printf("%s\\ %s \n\n",user,password);

       err=mysql_query(conn, consulta); 
       //err=0;
       printf("%d",err);
       printf("%d",err);
	   if(err!=0){
              printf("Se ha producido algun error en la introduccion de los datos %u %s \n",mysql_errno(conn),mysql_error(conn));
              return -1;
	      exit(1);
              }
	   else
	   {
	      return 0;
	      printf("Hemos anadido al usuario correctamente \n");
	   }

}

int tabla_partida(char buf[80])// Introduzco el usuario en la tabla que toca
{
       int err, code;
       char buf2[MAX];
       char consulta[MAX];
       char user[80];
       int i;


       strcpy(user,buf);
       //sscanf (buf,"%d  %s  %s",&code, user, password);

       //insertamos los valores que hemos cargado en la variable user y password en la base de datos
       sprintf(consulta,"INSERT INTO Partida (ganador) VALUES ('%s');",user);
       printf("%s\n",consulta);
       printf("%s\\  \n\n",user);

       err=mysql_query(conn, consulta); //
       //err=0;
       printf("%d",err);
       printf("%d",err);
       if(err!=0){
              printf("Se ha producido algun error en la introduccion de los datos %u %s \n",mysql_errno(conn),mysql_error(conn));
              return -1;
       }
       else
       {
              return 0;
              printf("Hemos anadido al usuario correctamente \n");
       }
}

int tabla_relacion(char buf[80], int id_partida)// Introduzco el usuario en la tabla que toca
{
       int err, id;
       char buf2[MAX];
       char consulta[MAX];
       char user[80];
       int i;


       strcpy(user,buf);
       id = id_partida;
       //sscanf (buf,"%d  %s  %s",&code, user, password);

       //insertamos los valores que hemos cargado en la variable user y password en la base de datos
       sprintf(consulta,"INSERT INTO Relacion (Nom,Id) VALUES ('%s',%d);",user,id);
       printf("%s\n",consulta);
       printf("%s\\ %d \n\n",user,id);

       err=mysql_query(conn, consulta); //
       //err=0;
       printf("%d",err);
       printf("%d",err);
       if(err!=0){
              printf("Se ha producido algun error en la introduccion de los datos %u %s \n",mysql_errno(conn),mysql_error(conn));
              return -1;
       }
       else
       {
              return 0;
              printf("Hemos anadido al usuario correctamente \n");
       }
}


// Funcion identificador

int identify_user(char buf[MAX])
{

       char buf2[MAX];
       int err;
       char nom[80];
       int numresul;
       char user[80];
       int code;
       char password[80];
       char consulta[200];
       int resul;


       sscanf (buf,"%d %s %s", &code, user, password);
       strcpy(consulta,"SELECT *FROM Jugador WHERE Nombre= '"); // Seleccionamos cualquier nombre y password de la tabla
       strcat(consulta,user);
       strcat(consulta,"'");

       //printf("%d",conn);

       err=mysql_query (conn,consulta);

       if (err!=0)
       {
              printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
              return(-1);
       }

       resultado = mysql_store_result (conn);

       // Obtenemos el numero de resultados
       numresul=mysql_num_rows(resultado);

       // Si numresul=0 quiere decir que no hay ningun usuario con ese nombre
       if(numresul==0){
    	      printf("No hay resultados! \n");
    	      return(-1);
       }

       // obtenemos la primera fila de resultados
       row = mysql_fetch_row (resultado);


       // strcmp devuelve 0 sin los strings son iguales

       resul=strcmp(row[1],password);
       // Verificamos que coinciden
       if(resul==0){
    	      printf("Se ha autentificado correctamente \n");
    	      return(0);
       }
       else
       {
    	      printf("No se ha autentificado correctamente \n");
    	      return(-1);
       }
}


int lista_fecha(char buf[200], int con){
       int err;
       char consulta[200];
       int numresul;
       char mensaje[200];
       char password[200];
       int code;
       char *msg;
       char mensaje_a_cliente[80];


       //sscanf (buf, "%d %s %s", &code, user, password);
       strcpy (consulta,buf);
       printf("La consulta es %s \n",consulta);
       err=mysql_query (conn,consulta);
       printf("err %d \n",err);

       if (err!=0)
       {
	      printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
	      strcpy(mensaje,"No se ha podido realizar la consulta");
	      
              /* Aqui se esta escribiendo en el socket usando el conector del mysql
              Revisar este write*/
              //write(conn,mensaje,strlen(mensaje));
	      return(-1);
       }

       printf("Antes de resultado!");
       resultado = mysql_store_result (conn);
       printf("Despues de resultado!");

       // Obtenemos el numero de resultados
       numresul=mysql_num_rows(resultado);
       printf("Numero de resultado es:%d \n",numresul);

       // Si numresul=0 quiere decir que no hay ningun usuario con ese nombre
       if(numresul==0){
              printf("No hay resultados! \n");
              return(-1);
       }

       // obtenemos la primera fila de resultados
       row = mysql_fetch_row (resultado);
       printf("%s \n",row[0]);

       //strcpy(mensaje,"Adversarios/");
       // Evitamos que nos salgan caracteres 'raros' cuando concatenamos por primera vez.
       strcpy(mensaje,"");

       while (row!= NULL)
       {
              strcat(mensaje,row[0]);
              printf("%s \n",mensaje);
              strcat(mensaje,",");
              row = mysql_fetch_row (resultado); // Leemos otra fila
       }
       printf("Este es el mensaje %s \n",mensaje);
       
       sprintf (mensaje_a_cliente,"12 %s",mensaje);
       write(con,mensaje_a_cliente,strlen(mensaje_a_cliente));
       return(0);    
}
    
int lista_jogadores(char buf[80],int con)
{
       int err;
       char user[80];
       char consulta[200];
       int numresul;
       char mensaje[200];
       char password[200];
       int code;
       char *msg;
       char mensaje_a_cliente[80];


       //sscanf (buf, "%d %s %s", &code, user, password);
       strcpy (user,buf);
       printf("El usuario es: %s \n",user);
       sprintf(consulta,"SELECT Nom FROM Relacion WHERE Id IN (SELECT Id FROM Relacion WHERE Nom='%s') AND Nom!='%s' GROUP BY Nom;",user,user);
       printf("La consulta es %s \n",consulta);
       err=mysql_query (conn,consulta);
       printf("err %d \n",err);

       if (err!=0)
       {
	      printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
	      strcpy(mensaje,"No se ha podido realizar la consulta");
	      
              /* Aqui se esta escribiendo en el socket usando el conector del mysql
              Revisar este write*/
              //write(conn,mensaje,strlen(mensaje));
	      return(-1);
       }

       printf("Antes de resultado!");
       resultado = mysql_store_result (conn);
       printf("Despues de resultado!");

       // Obtenemos el numero de resultados
       numresul=mysql_num_rows(resultado);
       printf("Numero de resultado es:%d \n",numresul);

       // Si numresul=0 quiere decir que no hay ningun usuario con ese nombre
       if(numresul==0){
              printf("No hay resultados! \n");
              return(-1);
       }

       // obtenemos la primera fila de resultados
       row = mysql_fetch_row (resultado);
       printf("%s \n",row[0]);

       //strcpy(mensaje,"Adversarios/");
       // Evitamos que nos salgan caracteres 'raros' cuando concatenamos por primera vez.
       strcpy(mensaje,"");

       while (row!= NULL)
       {
              strcat(mensaje,row[0]);
              printf("%s \n",mensaje);
              strcat(mensaje,",");
              row = mysql_fetch_row (resultado); // Leemos otra fila
       }
       printf("Este es el mensaje %s \n",mensaje);
       
       sprintf (mensaje_a_cliente,"11 %s",mensaje);
       write(con,mensaje_a_cliente,strlen(mensaje_a_cliente));
       return(0);

    }

int lista_ganadores(char buf[80],int con)
{
       int err;
       char user[80];
       char consulta[200];
       int numresul;
       char mensaje[200];
       char password[200];
       int code;
       char *msg;
       char mensaje_a_cliente[80];


       //sscanf (buf, "%d %s %s", &code, user, password);
       strcpy (user,buf);
       printf("El usuario es: %s \n",user);
       sprintf(consulta,"SELECT ganador FROM Partida WHERE Identificador IN(SELECT Id FROM Relacion WHERE Nom='%s');",user);
       printf("La consulta es %s \n",consulta);
       err=mysql_query (conn,consulta);
       printf("err %d \n",err);

       if (err!=0)
       {
	      printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
	      strcpy(mensaje,"No se ha podido realizar la consulta");
	      
              /* Aqui se esta escribiendo en el socket usando el conector del mysql
              Revisar este write*/
              //write(conn,mensaje,strlen(mensaje));
	      return(-1);
       }

       printf("Antes de resultado!");
       resultado = mysql_store_result (conn);
       printf("Despues de resultado!");

       // Obtenemos el numero de resultados
       numresul=mysql_num_rows(resultado);
       printf("Numero de resultado es:%d \n",numresul);

       // Si numresul=0 quiere decir que no hay ningun usuario con ese nombre
       if(numresul==0){
              printf("No hay resultados! \n");
              return(-1);
       }

       // obtenemos la primera fila de resultados
       row = mysql_fetch_row (resultado);
       printf("%s \n",row[0]);

       //strcpy(mensaje,"Adversarios/");
       // Evitamos que nos salgan caracteres 'raros' cuando concatenamos por primera vez.
       strcpy(mensaje,"");

       while (row!= NULL)
       {
              strcat(mensaje,row[0]);
              printf("%s \n",mensaje);
              strcat(mensaje,",");
              row = mysql_fetch_row (resultado); // Leemos otra fila
       }
       printf("Este es el mensaje %s \n",mensaje);
       
       sprintf (mensaje_a_cliente,"10 %s",mensaje);
       write(con,mensaje_a_cliente,strlen(mensaje_a_cliente));
       return(0);

    }
  //........... Funciones de las diferentes estructuras.....


void inicializa_lista (Tlista *l)
{  
       /*Pone a 0 el numero de usuarios de la lista*/
       l->num=0;
}

void inicializa_players (TlistaJugadores *l)
{  
       /*Pone a 0 el numero de usuarios de la lista*/
       l->num=0;
}


int pon_usuario (Tlista *l, Tusuario u)
 {
/* Anade el usuario u al final de la lista.
 * Devuelve 0 si todo bien y -1 si no hay espacio en la lista
 */
       if (l->num==MAX)
  	      return -1;
       else
       {
  	      l->usuarios[l->num]=u;
  	      l->num=l->num+1;
  	      return 0;
       }
}

int pon_player (TlistaJugadores *l, Tjugador u)
 {
/* Anade el usuario u al final de la lista.
 * Devuelve 0 si todo bien y -1 si no hay espacio en la lista
 */
       if (l->num==MAX)
  	      return -1;
       else
       {
  	      l->jugadores[l->num]=u;
  	      l->num=l->num+1;
  	      return 0;
       }
}

void escribir_lista (Tlista l)
{
       /* Escribe en pantalla todos los usuarios de la lista*/
  
       printf ("Lista de usuarios:\n");
       int i=0;
       while (i<l.num)
       {
  	      printf ("Nombre: %s, codigo %d\n", l.usuarios[i].nombre, l.usuarios[i].conexion);
  	      i=i+1;
       }
       printf ("\n\n");
}



void construir_lista (Tlista l, int con)
  /* Construye un mensaje de texto con los nombre de los usuarios que
     hay en la lista l, separados por una coma */
{
       
       int i=1;
       //int con = (int) conn;
       char mensaje[80];
       char mensaje_a_cliente[80];
       strcpy (mensaje, l.usuarios[0].nombre);
       printf("Estoy dentro de construir lista \n");
       while (i<l.num)
       {
  	      sprintf (mensaje, "%s,%s",mensaje,l.usuarios[i].nombre);
  	      i++;
       }
       sprintf (mensaje_a_cliente,"4 %s,",mensaje);
       write(con,mensaje_a_cliente,strlen(mensaje_a_cliente));
}

int buscar (char nombre[20], Tlista l)
{ 
       /* Devuelve la posiciÃƒÂ³n que ocupa en la lista el usuario cuyo nombre se recibe
        * como parÃƒÂ¡metro. Si el usuario no estÃƒÂ¡ en la lista devuelve un -1
        */
  
       int encontrado = 0;
       int i=0;
       while ((i<l.num) &&(!encontrado))
       {
  	      if (strcmp (l.usuarios[i].nombre, nombre)==0)
  		     encontrado = 1;
  	      if (!encontrado)
  		     i=i+1;
       }
       if (encontrado)
  	      return i;
       else
  	      return -1;
  }

int eliminar (int i, Tlista *l)
{
       /* Elimina de la lista el usuario que ocupa la posiciÃƒÂ³n i
        * Devuelve 0 si ok y -1 si no hay usuario en la posiciÃƒÂ³n i
        */

       int j;
       if (i>= MAX)
	      return -1;
       else
       {
	      j=i;
	      while (j< l->num-1)
	      {
		     l->usuarios[j]= l-> usuarios[j+1];
		     j=j+1;
	      }
	      l->num=l->num-1;
	      return 0;
       }
}


void *usuarios(void *conector)
{

       printf("dentro de Usuarios \n");
       int code,borrador,aceptacion,jugador,jugada,resultado_partida,ganador;
       int nchar;
       static char buf[MAX];
       //char mensaje2[MAX];
       int resultado;
       char usuario [80];
       char fecha_inicial [25];
       char fecha_final [25];
       char hora_final [25];
       char hora_inicial [25];
       char consulta[200];
       char invitante [80];
       char invitado [80];
       char mensaje_a_cliente[50];
       //char *mensaje_respuesta;
       
       /*Haciendo la conversion del SocketID pasado por argumento*/
       int con = (int) conector;



       /* Se pasa el valor de con por puntero, no se guarda en variable local y se llama directamente
        * hay que resvisar*/
       printf("El valor del socket es %d \n",con);

       /*Exactamente el mismo problemas anterior*/
       nchar=read(con,buf,MAX);//nchar indica el numero de caractareres recibidos
       buf[nchar]='\0';
       printf("Se ha recibido el mensaje %s \n",buf);


       sscanf (buf,"%d  %s ",&code,usuario);
       printf("el codigo es: %d y el usuario es %s \n",code,usuario);
       code=identify(buf);

       // printf("el codigo es: %d y el usuario es %s \n",code,usuario);


       printf("Empezamos con el primer usuario que utilizaria un Thread\n");

       while( code!=100){

       switch(code){
	      case 1:
                     // Agregamos nuevo usuario a nuestra base de datos
	             printf("Estas en el caso 1 introducir usuario \n");
	             resultado=new_user(buf);
	             if(resultado==0){
                            pthread_mutex_lock(&semaforo);
	                    /*tabla_partida(buf);*/
	                    sprintf (mensaje_a_cliente,"1 ");
                            write(con,mensaje_a_cliente,strlen(mensaje_a_cliente));
                            pthread_mutex_unlock(&semaforo); 
                     }else{
			    //sprintf (mensaje2,"Usuario no se ha introducido correctamente");
	                    
                            /*con no existe en el contesto actual como variable, el argumento no se ha guardado
                             *en una variable local*/
                            sprintf (mensaje_a_cliente,"2 ");
                            write(con,mensaje_a_cliente,strlen(mensaje_a_cliente));
	             }
		     break;
	      case 2:

                     // autentificamos al usuario
	       	     printf("Estamos en el caso 2 con el usuario %s \n",usuario);
	             resultado=identify_user(buf);

                     // autentificacion del usuario es correcta
		     if(resultado==0){

                            /* le paso la "con" a la estructura Tusuario y la guardo en la variable conexion de esa estructura.*/
                            t.conexion=con;
                            
                            /* guardo el nombre del usuario en la estructura de Tusuario en la variable nombre.*/
                            strcpy(t.nombre,usuario); 
                            
                            printf("Se ha anadido correctamente el nombre dentro de la estructura Tusuario %d %s\n",t.conexion,t.nombre);
                            pon_usuario (&mi_lista,t);
                            escribir_lista (mi_lista);
                            sprintf (mensaje_a_cliente,"3 ");
                            write(con,mensaje_a_cliente,strlen(mensaje_a_cliente));
	             }else{
	                    printf("El usuario o contrasena no son las correctas \n");
	                    sprintf (mensaje_a_cliente,"2 ");
	                    write(con,mensaje_a_cliente,strlen(mensaje_a_cliente));
	             }
	             break;     
              case 3:
                     // Listamos a los jugadores conectados.
                            
                     construir_lista(mi_lista,con);
              	     break;
              case 4:
                     /*Case responsable por recibir la peticion de invitacion
                     * La invitacion se envia con un mensaje de tipo 5
                     */
                     sscanf (buf,"%d %s %s", &borrador, invitante, invitado);
                     
                     /*Se pone los dos jugadores en la lista de Juego
                     * En Caso de que no acepta la invitacion se limpia la lista.
                     */
                     strcpy(PLAYER.nombre,invitante); 
                     pon_player (&PLAYERLIST,PLAYER);
                     strcpy(PLAYER.nombre,invitado); 
                     pon_player (&PLAYERLIST,PLAYER);   
                     
                     int index = buscar(invitado,mi_lista);
                     int socket_invitado = mi_lista.usuarios[index].conexion;
                     sprintf (mensaje_a_cliente,"5 %s",invitante);
                     write(socket_invitado,mensaje_a_cliente,strlen(mensaje_a_cliente));
                     break;
              
              case 5:
                     /*Case responsable por la decision de aceptacion de la partida*/
                     
                     
                     sscanf (buf,"%d %d", &borrador, &aceptacion);
                     if(aceptacion == 1){
                            /*Se escribirá un case de tipo 6 activando el form de juego*/
                            
                            /*Aqui se abre el tablero en el formulario del invitante
                            * El invitante siempre será el PLAYERLIST.jugadores[0],
                            * Esto porque es el primero que se crea en la struct.
                            */
                            strcpy(invitante,PLAYERLIST.jugadores[0].nombre); 
                            int index = buscar(invitante,mi_lista);
                            int socket_invitante = mi_lista.usuarios[index].conexion;
                            sprintf (mensaje_a_cliente,"6 1");
                            write(socket_invitante,mensaje_a_cliente,strlen(mensaje_a_cliente));
                            
                            /*Aqui se abre el tablero en el formulario del invitado
                            * El invitante siempre será el PLAYERLIST.jugadores[1],
                            * Esto porque es el segundo que se crea en la struct.
                            */
                            strcpy(invitado,PLAYERLIST.jugadores[1].nombre);
                            printf("el nombre del invitadoes: %s \n",invitado);
                            index = buscar(invitado,mi_lista);
                            int socket_invitado = mi_lista.usuarios[index].conexion;
                            sprintf (mensaje_a_cliente,"6 0");
                            write(socket_invitado,mensaje_a_cliente,strlen(mensaje_a_cliente));
                            
                     }else if(aceptacion == 0){
                         inicializa_players(&PLAYERLIST);   
                     }
                     break;
              case 6:
                     /*Este case será el responsable de recibir las jugadas y repasarlas
                     * el mensaje será del tipo 6 [0/1] [1..9]
                     * En caso de que el primero argumento sea 0 -> mensaje hacia invitante
                     * En caso de que el primero argumento sea 1 -> mensaje hacia invitado
                     * [1..9] -> Casilla de uno a 9 (B1=1,B2=2,B3=3...etc)
                     */
                     //int jugador,jugada;
                     
                     sscanf (buf,"%d %d %d", &borrador, &jugador,&jugada);
                     if(jugador == 0){
                            /*Caso de mensaje destinado a invitante
                            * Se enviará un mensaje al cliente del tipo 7 1 [1..9]
                            * En el cliente se pasa la x = true;
                            */
                            strcpy(invitante,PLAYERLIST.jugadores[0].nombre); 
                            int index = buscar(invitante,mi_lista);
                            int socket_invitante = mi_lista.usuarios[index].conexion;
                            sprintf (mensaje_a_cliente,"7 1 %d",jugada);
                            write(socket_invitante,mensaje_a_cliente,strlen(mensaje_a_cliente));
                     }
                     if(jugador == 1){
                            
                            /*Caso de mensaje destinado a invitado
                            * Se enviará un mensaje al cliente del tipo 7 1 [1..9]
                            * En el cliente se pasa la o = true;
                            */
                            strcpy(invitado,PLAYERLIST.jugadores[1].nombre);
                            index = buscar(invitado,mi_lista);
                            int socket_invitado = mi_lista.usuarios[index].conexion;
                            sprintf (mensaje_a_cliente,"7 0 %d",jugada);
                            write(socket_invitado,mensaje_a_cliente,strlen(mensaje_a_cliente));
                     }
              
              case 7:
                     /*Case responsable por actualizar la informacion de las tablas relacionadas
                     * a las partidas, en concreto la tabla partida y la tabla relacion.
                     * La idea es que se actualicen las tablas solamente cuando haya un ganador.
                     * Los empates no se actualizan, no habrá una partida en caso de empate.
                     * En el final de cada partida se debe limpiar la lista de jugadores.
                     * Esto se hace llamando a la función incializa_players(&PLAYERLIST).
                     * Se va recibir un mensaje del tipo 7 [2..3] [0..1]
                     * [2..3]-> 2 en caso de que sea un empate, solamente limpiamos la lista de jugadores.
                     *       -> 3 hubo un ganador tenemos que limpiar la lista de jugadores y actualizar la BD's.
                     * [0..1]-> 0 En caso de que sea un 0 ha ganado el jugador invitado PLAYERLIST.jugadores[1]
                     *       -> 1 Ha ganado el jugador invitante PLAYERLIST.jugadores[0]
                     * La duración de la partida no es un requerimiento por lo tanto de momento no la trataremos.
                     */
                     
                     sscanf (buf,"%d %d %d", &borrador,&resultado_partida,&ganador);
                     if(resultado_partida == 2){
                            inicializa_players(&PLAYERLIST);
                     }
                     if(resultado_partida == 3){
                            if(ganador == 1){
                                   strcpy(invitante,PLAYERLIST.jugadores[0].nombre);
                                   tabla_partida(invitante);
                                   IDPARTIDA++;
                                   strcpy(invitado,PLAYERLIST.jugadores[1].nombre);
                                   tabla_relacion(invitante,IDPARTIDA);
                                   tabla_relacion(invitado,IDPARTIDA);
                            }
                            if(ganador == 0){
                                   strcpy(invitado,PLAYERLIST.jugadores[1].nombre);
                                   tabla_partida(invitado);
                                   IDPARTIDA++;
                                   strcpy(invitante,PLAYERLIST.jugadores[0].nombre);
                                   tabla_relacion(invitante,IDPARTIDA);
                                   tabla_relacion(invitado,IDPARTIDA);
                            }
                            inicializa_players(&PLAYERLIST);
                     }
                     break;
              case 8:
                     /*Case Responsable por la Baja de Usuario*/
                     
                     resultado=baja_user(buf);
	             if(resultado==0){
                            pthread_mutex_lock(&semaforo);
	                    sprintf (mensaje_a_cliente,"8 ");
                            write(con,mensaje_a_cliente,strlen(mensaje_a_cliente));
                            pthread_mutex_unlock(&semaforo); 
                     }else{
                            sprintf (mensaje_a_cliente,"9 ");
                            write(con,mensaje_a_cliente,strlen(mensaje_a_cliente));
	             }
                     break;
              case 9:
                     /*Case responsable por Listado de jugadores con los que he echado alguna partida.*/
                     
                     sscanf (buf,"%d %s", &borrador, usuario);
                     resultado = lista_jogadores(usuario,con);
                     break;
              
              case 10:
                     /*Case responsable por Listado de ganadores de las partidas en las que he jugado.*/
                     sscanf (buf,"%d %s", &borrador, usuario);
                     resultado = lista_ganadores(usuario,con);
                     break;
              case 11:
                     /*Case responsable por Lista de partidas jugadas por mi en un periodo de tiempo dado.*/
                     sscanf (buf,"%d %s %s %s %s %s", &borrador, usuario, fecha_inicial, hora_inicial, fecha_final, hora_final);
                     //printf ("Valor do que os datetimepicker mandad %s  %s %s %s %s \n",usuario,fecha_inicial,hora_inicial,fecha_final,hora_final);
                     sprintf (consulta,"SELECT Identificador FROM Partida WHERE Identificador IN(SELECT Id FROM Relacion WHERE Nom='%s') AND fecha BETWEEN '%s %s' AND '%s %s';",usuario,fecha_inicial,hora_inicial,fecha_final,hora_final);
                     lista_fecha(consulta,con);
                     //resultado = lista_ganadores(usuario,con);
                     break;
       /*fin del switch*/     
       } 

              nchar=read(con,buf,MAX); //nchar indica el numero de caractareres recibidos
              buf[nchar]='\0';
              printf("Se ha recibido el mensaje %s \n",buf);
              code=identify(buf);
              printf("el codigo es: %d\n",code);
       
       /*fin del while*/
       } 
       
       
       /* Enviamos mensaje de logoff al Cliente, FALTA ELIMINAR CLIENTE DE LA LISTA DE CONECTADOS
        * Cerramos el socket, Matamos el Threads y decrementamos el numero de Threads usados*/
       
       sprintf (mensaje_a_cliente,"100 %s ",usuario);
       write(con,mensaje_a_cliente,strlen(mensaje_a_cliente));
       int u = buscar(usuario,mi_lista);
       eliminar(u,&mi_lista);
       close(con);
       pthread_exit(NULL);
       T--;
  }

int main(void) {

       // Defino las variables que se utilizara en el programa principal
       int s;
       int con;
       int remote_addr_len;
       struct sockaddr_in serv_adr, remote_addr;
       int thread_p;
       char mensaje_a_cliente[50];
       
       IDPARTIDA = 0;
       T = 0;
       pthread_t Pthread[MAX_THREADS];
       inicializa_lista (&mi_lista);
       inicializa_players (&PLAYERLIST);
       
       /* Iniciamos nuestra conexionn con MYSQL*/
       conexion_a_sql();

       /*Creamos la base de datos*/
       crea_base_datos();
       
       /*inicializamos los sockets*/
       s = socket_treat(0);

       /* inicializamos el pthread mutex.*/
       pthread_mutex_init(&semaforo, NULL); 

       for(;;){

              /*El while es el responsable por el control de numero maximo de threads*/
              while (T <= MAX_THREADS){
                     printf("dentro del bucle \n");
                     printf ("Esperando connexion\n");
                     remote_addr_len=sizeof(remote_addr);
                     con=accept(s,(struct sockaddr *)&remote_addr, &remote_addr_len);
                     printf ("connexio de %s:%d\n", inet_ntoa(remote_addr.sin_addr), ntohs(remote_addr.sin_port));
                     printf("El valor de con: %d \n",con);

                     // Le enviamos el primer mensaje al cliente indicandole que se ha conectado correctamente, es el caso numero 0 del cliente//
                     sprintf (mensaje_a_cliente,"0 ");  
                     write(con,mensaje_a_cliente,strlen(mensaje_a_cliente));

                     /* Iniciamos el thread respetando siempre el numero maximo de Threads permitido*/
                     thread_p=pthread_create(&Pthread[T],NULL,usuarios,(void *) con);
                     if(thread_p){
                           printf("Ha habido un problema con el thread \n");
                           exit(-1);
                     }
                     /*Incrementamos el numero de Threads usado*/
                     T++;
                     
              /*fin del WHILE*/       
              }
       /*fin del FOR*/
       } 
       pthread_exit(NULL);
       
/* Fin del MAIN*/       
} 