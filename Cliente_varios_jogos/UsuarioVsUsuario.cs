using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace inicio
{
	public partial class UsuarioVsUsuario
	{
        Socket server;
        int PLAYER,IDGAME;
        delegate void SetAnalizaCallBack();

        public UsuarioVsUsuario(Socket s,int player,int idpartida)
		{
			InitializeComponent();
            server = s;
            PLAYER = player;
            IDGAME = idpartida;
		}

        public void SetJugada(int player, int casilla)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
            
            /*Si Jugador es igual a X y la casilla es B1*/
            if (player == 1) 
            {
               switch(casilla)
               {
                   /*Casilla igual a B1*/
                   case 1:
                       //Poner una O en la casilla B1
                       if (this.p1.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                       {
                           B1 = "o";
                           this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                           c++;
                       }
                       break;
                   /*Casilla igual a B2*/
                   case 2:
                       //Poner una O en la casilla B2
                       if (this.p2.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                       {
                           B2 = "o";
                           this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                           c++;
                       }
                       break;
                   /*Casilla igual a B3*/
                   case 3:
                       //Poner una O en la casilla B3, Poner Jugador o=true;
                       if (this.p3.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                       {
                           B3 = "o";
                           this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                           c++;
                       }
                       break;
                   /*Casilla igual a B4*/
                   case 4:
                       //Poner una O en la casilla B4, Poner Jugador o=true;
                       if (this.p4.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                       {
                           B4 = "o";
                           this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                           c++;

                       }
                       break;
                   /*Casilla igual a B5*/
                   case 5:
                       //Poner una O en la casilla B5, Poner Jugador o=true;
                       if (this.p5.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                       {
                           B5 = "o";
                           this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                           c++;
                       }
                       break;
                   /*Casilla igual a B6*/
                   case 6:
                       //Poner una O en la casilla B6;
                       if (this.p6.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                       {
                           B6 = "o";
                           this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                           c++;
                       }
                       break; 
                   /*Casilla igual a B7*/
                   case 7:
                       //Poner una O en la casilla B7;
                       if (this.p7.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                       {
                           B7 = "o";
                           this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                           c++;
                       }
                       break; 
                   /*Casilla igual a B8*/
                   case 8:
                       //Poner una O en la casilla B8;
                       if (this.p8.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                       {
                           B8 = "o";
                           this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                           c++;
                       }
                       break;
                   /*Casilla igual a B9*/
                   case 9:
                       //Poner una O en la casilla B9;
                       if (this.p9.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                       {
                           B9 = "o";
                           this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                           c++;
                       }
                       break;
               }
               x = true;
               analiza(); 
            }
            if (player == 0)
            {
                switch (casilla)
                {
                    /*Casilla igual a B1*/
                    case 1:
                        //Poner una X en la casilla B1;
                        if (this.p1.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                        {
                            B1 = "x";
                            this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                            c++;
                        }
                        break;
                    
                    /*Casilla igual a B2*/
                    case 2:
                        //Poner una X en la casilla B2;
                         if (this.p2.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                        {
                             B2 = "x";
                             this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                            c++;
                        }
                        break;

                    /*Casilla igual a B3*/
                    case 3:
                        //Poner una X en la casilla B3;
                        if (this.p3.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                        {
                            B3 = "x";
                            this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                            c++;
                        }
                        break;

                    /*Casilla igual a B4*/
                    case 4:
                        //Poner una X en la casilla B4;
                        if (this.p4.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                        {
                            B4 = "x";
                            this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                            c++;
                        }
                        break;

                    /*Casilla igual a B5*/
                    case 5:
                        //Poner una X en la casilla B5;
                        if (this.p5.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                        {
                            B5 = "x";
                            this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                            c++;
                        }
                        break;

                    /*Casilla igual a B6*/
                    case 6:
                        //Poner una X en la casilla B6;
                        if (this.p6.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                        {
                            B6 = "x";
                            this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                            c++;
                        }
                        break; 
                    
                    /*Casilla igual a B7*/
                    case 7:
                        //Poner una X en la casilla B7;
                        if (this.p7.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                        {
                            B7 = "x";
                            this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                            c++;
                        }
                        break; 

                    /*Casilla igual a B8*/
                    case 8:
                        //Poner una X en la casilla B8;
                        if (this.p8.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                        {
                            B8 = "x";
                            this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                            c++;
                        }
                        break;

                    /*Casilla igual a B9*/
                    case 9:
                        //Poner una X en la casilla B9;
                        if (this.p9.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
                        {
                            B9 = "x";
                            this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                            c++;
                        }
                        break;
                }
                o = true;
                analiza();
            }
            
        }

		private bool x=false;
		private bool o=false;
		private int c=0;
		private String B1="",B2="",B3="",B4="",B5="",B6="",B7="",B8="",B9="";
		
		void PictureBox1Click(object sender, System.EventArgs e)
		{   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
											
			if(x==true&&this.p1.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				o=false;
                B1="x";
				c++;
				this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 1" + " " + IDGAME;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
			if(o==true&&this.p1.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	o=false;
				x=false;
                B1="o";
                c++;
				this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));

                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 1" + " " + IDGAME;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);

			}
			analiza();	
		}
				
		void PictureBox2Click(object sender, System.EventArgs e)
		{System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p2.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				o=false;
                B2="x";
                c++;
				this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 2" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
			if(o==true&&this.p2.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	o=false;
				x=false;
                B2="o";
                c++;
				this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 2" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
            analiza();
		}
		
		void PictureBox3Click(object sender, System.EventArgs e)
		{System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p3.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				o=false;
                B3="x";
                c++;
				this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 3" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
			if(o==true&&this.p3.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	o=false;
				x=false;
                B3="o";
                c++;
				this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 3" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
            analiza();
		}
		
		void PictureBox4Click(object sender, System.EventArgs e)
		{System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p4.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				o=false;
                B4="x";
                c++;
				this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 4" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
			if(o==true&&this.p4.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	o=false;
				x=false;
                B4="o";
                c++;
				this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 4" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
            analiza();
		}
		
		void PictureBox5Click(object sender, System.EventArgs e)
		{System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p5.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				o=false;
                B5="x";
                c++;
				this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 5" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
			if(o==true&&this.p5.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	o=false;
				x=false;
                B5="o";
                c++;
				this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 5" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
            analiza();
		}
		
		void PictureBox6Click(object sender, System.EventArgs e)
		{System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p6.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				o=false;
                B6="x";
                c++;
				this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 6" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
			if(o==true&&this.p6.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	o=false;
				x=false;
                B6="o";
                c++;
				this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 6" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
            analiza();
		}
		
		void PictureBox7Click(object sender, System.EventArgs e)
		{System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p7.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				o=false;
                B7="x";
                c++;
				this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 7" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
			if(o==true&&this.p7.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	o=false;
				x=false;
                B7="o";
                c++;
				this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 7" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
            analiza();
		}
		
		void PictureBox8Click(object sender, System.EventArgs e)
		{System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
		if(x==true&&this.p8.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				o=false;
                B8="x";
                c++;
				this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 8" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
			if(o==true&&this.p8.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	o=false;
				x=false;
                B8="o";
                c++;
				this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 8" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
            analiza();
		}
		
		void PictureBox9Click(object sender, System.EventArgs e)
		{System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p9.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				o=false;
                B9="x";
                c++;
				this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 9" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
			if(o==true&&this.p9.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	o=false;
				x=false;
                B9="o";
                c++;
				this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
                //Escribir mensaje en el socketActualizando el otro cliente
                string jugada = "6 " + PLAYER + " 9" + " " + IDGAME;
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(jugada);
                server.Send(msg);
			}
            analiza();
		}
		
		public  void analiza()
		{
			/*Solamente los Jugadores 1(X), que son los invitantes envíaran mensajes al servidor
             *Actualizado el final de la partida, encaso de empate solamente limpiamos la lista
             *de jugadores en el servidor en caso 
             */
            string resultado;

            if(B1=="x"&&B2=="x"&&B3=="x")
			{
                if (label3.InvokeRequired)
                {
                    SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                    this.Invoke(d, new object[] {});
                }
                else
                {
                    this.label3.Visible = true;

                    x = false;
                    o = false;

                    /*Este If activa Los paneles de ganadores y perdedores
                     * Actualiza el servidor con a la información de ganador
                     * Todavia hace falta configurar los mensajes que se envian al servidor
                     * Esta configuración es la del que gana el jugador de la X
                     * Para O tenemos que invertir la logica.
                     */
                }
                if (PLAYER == 1)
                {
                    this.label15.Visible = true;
                    /* Se va enviar un mensaje del tipo 7 [2..3] [0..1]
                     * [2..3]-> 2 en caso de que sea un empate, solamente limpiamos la lista de jugadores.
                     *       -> 3 hubo un ganador tenemos que limpiar la lista de jugadores y actualizar la BD's.
                     * [0..1]-> 0 En caso de que sea un 0 ha ganado el jugador invitado PLAYERLIST.jugadores[1]
                     *       -> 1 Ha ganado el jugador invitante PLAYERLIST.jugadores[0]
                     * La duración de la partida no es un requerimiento por lo tanto de momento no la trataremos.
                     */
                    resultado = "7 3 1" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);

                }
                if (PLAYER == 0)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
            }
			if(B4=="x"&&B5=="x"&&B6=="x")
			{
                if (label5.InvokeRequired)
                {
                    SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    this.label5.Visible = true;

                    x = false;
                    o = false;

                    /*Este If activa Los paneles de ganadores y perdedores
                     * Actualiza el servidor con a la información de ganador
                     * Todavia hace falta configurar los mensajes que se envian al servidor
                     * Esta configuración es la del que gana el jugador de la X
                     * Para O tenemos que invertir la logica.
                     */
                }
                if (PLAYER == 1)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 1" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 0)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
            }
			if(B7=="x"&&B8=="x"&&B9=="x")
			{
                if (label3.InvokeRequired)
                {
                    SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    this.label3.Visible = true;

                    x = false;
                    o = false;

                    /*Este If activa Los paneles de ganadores y perdedores
                     * Actualiza el servidor con a la información de ganador
                     * Todavia hace falta configurar los mensajes que se envian al servidor
                     * Esta configuración es la del que gana el jugador de la X
                     * Para O tenemos que invertir la logica.
                     */
                }
                if (PLAYER == 1)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 1" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 0)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
                //this.label5.Visible = true;this.label16.Visible = true;x=false;o=false;
            }
			if(B1=="x"&&B4=="x"&&B7=="x")
			{
                if (label6.InvokeRequired)
                {
                    SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    this.label6.Visible = true;

                    x = false;
                    o = false;

                    /*Este If activa Los paneles de ganadores y perdedores
                     * Actualiza el servidor con a la información de ganador
                     * Todavia hace falta configurar los mensajes que se envian al servidor
                     * Esta configuración es la del que gana el jugador de la X
                     * Para O tenemos que invertir la logica.
                     */
                }
                if (PLAYER == 1)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 1" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 0)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
                //this.label6.Visible = true;this.label16.Visible = true;x=false;o=false;
            }
			if(B2=="x"&&B5=="x"&&B8=="x")
			{
                if (label7.InvokeRequired)
                {
                    SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    this.label7.Visible = true;

                    x = false;
                    o = false;

                    /*Este If activa Los paneles de ganadores y perdedores
                     * Actualiza el servidor con a la información de ganador
                     * Todavia hace falta configurar los mensajes que se envian al servidor
                     * Esta configuración es la del que gana el jugador de la X
                     * Para O tenemos que invertir la logica.
                     */
                }
                if (PLAYER == 1)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 1" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 0)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
                //this.label7.Visible = true;this.label16.Visible = true;x=false;o=false;
            }
			if(B3=="x"&&B6=="x"&&B9=="x")
			{
                if (label8.InvokeRequired)
                {
                    SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    this.label8.Visible = true;

                    x = false;
                    o = false;

                    /*Este If activa Los paneles de ganadores y perdedores
                     * Actualiza el servidor con a la información de ganador
                     * Todavia hace falta configurar los mensajes que se envian al servidor
                     * Esta configuración es la del que gana el jugador de la X
                     * Para O tenemos que invertir la logica.
                     */
                }
                if (PLAYER == 1)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 1" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 0)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
            }
			if(B1=="x"&&B5=="x"&&B9=="x")
			{
                x = false;
                o = false;

                /*Este If activa Los paneles de ganadores y perdedores
                 * Actualiza el servidor con a la información de ganador
                 * Todavia hace falta configurar los mensajes que se envian al servidor
                 * Esta configuración es la del que gana el jugador de la X
                 * Para O tenemos que invertir la logica.
                 */
                d2941();
                if (PLAYER == 1)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 1" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 0)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
            }
			if(B3=="x"&&B5=="x"&&B7=="x")
			{
                    x = false;
                    o = false;

                    /*Este If activa Los paneles de ganadores y perdedores
                     * Actualiza el servidor con a la información de ganador
                     * Todavia hace falta configurar los mensajes que se envian al servidor
                     * Esta configuración es la del que gana el jugador de la X
                     * Para O tenemos que invertir la logica.
                     */
                    d1727();
                if (PLAYER == 1)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 1" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 0)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
            }
			if(B1=="o"&&B2=="o"&&B3=="o")
			{
                if (label9.InvokeRequired)
                {
                    SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    this.label9.Visible = true;

                    x = false;
                    o = false;

                    /*Este If activa Los paneles de ganadores y perdedores
                     * Actualiza el servidor con a la información de ganador
                     * Todavia hace falta configurar los mensajes que se envian al servidor
                     * Esta configuración es la del que gana el jugador de la X
                     * Para O tenemos que invertir la logica.
                     */
                }
                if (PLAYER == 0)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 0" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 1)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
            }
			if(B4=="o"&&B5=="o"&&B6=="o")
			{
                if (label10.InvokeRequired)
                {
                    SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    this.label10.Visible = true;

                    x = false;
                    o = false;

                    /*Este If activa Los paneles de ganadores y perdedores
                     * Actualiza el servidor con a la información de ganador
                     * Todavia hace falta configurar los mensajes que se envian al servidor
                     * Esta configuración es la del que gana el jugador de la X
                     * Para O tenemos que invertir la logica.
                     */
                }
                if (PLAYER == 0)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 0" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 1)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
            }
			if(B7=="o"&&B8=="o"&&B9=="o")
			{
                if (label11.InvokeRequired)
                {
                    SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    this.label11.Visible = true;

                    x = false;
                    o = false;

                    /*Este If activa Los paneles de ganadores y perdedores
                     * Actualiza el servidor con a la información de ganador
                     * Todavia hace falta configurar los mensajes que se envian al servidor
                     * Esta configuración es la del que gana el jugador de la X
                     * Para O tenemos que invertir la logica.
                     */
                }
                if (PLAYER == 0)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 0" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 1)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
            }
			if(B1=="o"&&B4=="o"&&B7=="o")
			{
                if (label12.InvokeRequired)
                {
                    SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    this.label12.Visible = true;

                    x = false;
                    o = false;

                    /*Este If activa Los paneles de ganadores y perdedores
                     * Actualiza el servidor con a la información de ganador
                     * Todavia hace falta configurar los mensajes que se envian al servidor
                     * Esta configuración es la del que gana el jugador de la X
                     * Para O tenemos que invertir la logica.
                     */
                }
                if (PLAYER == 0)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 0" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 1)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
            }
			if(B2=="o"&&B5=="o"&&B8=="o")
			{
                if (label13.InvokeRequired)
                {
                    SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    this.label13.Visible = true;

                    x = false;
                    o = false;

                    /*Este If activa Los paneles de ganadores y perdedores
                     * Actualiza el servidor con a la información de ganador
                     * Todavia hace falta configurar los mensajes que se envian al servidor
                     * Esta configuración es la del que gana el jugador de la X
                     * Para O tenemos que invertir la logica.
                     */
                }
                if (PLAYER == 0)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 0" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 1)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
            }
			if(B3=="o"&&B6=="o"&&B9=="o")
			{
                if (label14.InvokeRequired)
                {
                    SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    this.label14.Visible = true;

                    x = false;
                    o = false;

                    /*Este If activa Los paneles de ganadores y perdedores
                     * Actualiza el servidor con a la información de ganador
                     * Todavia hace falta configurar los mensajes que se envian al servidor
                     * Esta configuración es la del que gana el jugador de la X
                     * Para O tenemos que invertir la logica.
                     */
                }
                if (PLAYER == 0)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 0" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 1)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
            }
			if(B1=="o"&&B5=="o"&&B9=="o")
			{
                x = false;
                o = false;

                /*Este If activa Los paneles de ganadores y perdedores
                 * Actualiza el servidor con a la información de ganador
                 * Todavia hace falta configurar los mensajes que se envian al servidor
                 * Esta configuración es la del que gana el jugador de la X
                 * Para O tenemos que invertir la logica.
                 */
                d5466();
                if (PLAYER == 0)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 0" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 1)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
            }
			if(B3=="o"&&B5=="o"&&B7=="o")
			{
                x = false;
                o = false;

                /*Este If activa Los paneles de ganadores y perdedores
                 * Actualiza el servidor con a la información de ganador
                 * Todavia hace falta configurar los mensajes que se envian al servidor
                 * Esta configuración es la del que gana el jugador de la X
                 * Para O tenemos que invertir la logica.
                 */
                d4253();
                if (PLAYER == 0)
                {
                    this.label15.Visible = true;
                    resultado = "7 3 0" + " " + IDGAME;
                    
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                    server.Send(msg);
                }
                if (PLAYER == 1)
                {
                    if (label16.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label16.Visible = true;
                    }
                }
            }
			if(c==9)
			{
                if (label16.Visible == false && label15.Visible == false)
                {
                    if (label68.InvokeRequired)
                    {
                        SetAnalizaCallBack d = new SetAnalizaCallBack(analiza);
                        this.Invoke(d, new object[] { });
                    }
                    else
                    {
                        this.label68.Visible = true;
                        if (PLAYER == 1)
                        {
                            resultado = "7 2 1" + " " + IDGAME;
                            
                            byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
                            server.Send(msg);
                        }
                    }
                    
                }
			}
		}
		
		public void d1727()
		{

            if (label17.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d1727);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label17.Visible = true;
            }
            if (label18.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d1727);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label18.Visible = true;
            }
            if (label19.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d1727);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label19.Visible = true;
            }
            if (label20.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d1727);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label20.Visible = true;
            }
            if (label21.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d1727);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label21.Visible = true;
            }
            if (label22.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d1727);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label22.Visible = true;
            }
            if (label23.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d1727);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label23.Visible = true;
            }
            if (label24.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d1727);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label24.Visible = true;
            }
            if (label25.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d1727);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label25.Visible = true;
            }
            if (label26.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d1727);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label26.Visible = true;
            }
            if (label27.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d1727);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label27.Visible = true;
            }
            if (label28.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d1727);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label28.Visible = true;
            }
		
		}
		public void d2941()
		{
            if (label29.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d2941);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label29.Visible = true;
            }
            if (label39.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d2941);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label39.Visible = true;
            }
            if (label30.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d2941);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label30.Visible = true;
            }
            if (label40.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d2941);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label40.Visible = true;
            }
            if (label31.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d2941);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label31.Visible = true;
            }
            if (label32.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d2941);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label32.Visible = true;
            }
            if (label33.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d2941);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label33.Visible = true;
            }
            if (label34.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d2941);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label34.Visible = true;
            }
            if (label35.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d2941);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label35.Visible = true;
            }
            if (label36.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d2941);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label36.Visible = true;
            }
            if (label37.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d2941);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label37.Visible = true;
            }
            if (label38.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d2941);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label38.Visible = true;
            }
            if (label41.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d2941);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label41.Visible = true;
            }
		}
		public void d4253()
		{
            if (label42.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d4253);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label42.Visible = true;
            }
            if (label48.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d4253);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label48.Visible = true;
            }
            if (label43.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d4253);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label43.Visible = true;
            }
            if (label49.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d4253);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label49.Visible = true;
            }
            if (label44.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d4253);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label44.Visible = true;
            }
            if (label50.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d4253);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label50.Visible = true;
            }
            if (label45.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d4253);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label45.Visible = true;
            }
            if (label51.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d4253);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label51.Visible = true;
            }
            if (label46.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d4253);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label46.Visible = true;
            }
            if (label52.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d4253);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label52.Visible = true;
            }
            if (label47.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d4253);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label47.Visible = true;
            }
            if (label53.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d4253);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label53.Visible = true;
            }
		}
		public void d5466()
		{
            if (label54.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d5466);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label54.Visible = true;
            }
            if (label61.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d5466);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label61.Visible = true;
            }
            if (label55.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d5466);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label55.Visible = true;
            }
            if (label62.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d5466);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label62.Visible = true;
            }
            if (label56.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d5466);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label56.Visible = true;
            }
            if (label63.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d5466);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label63.Visible = true;
            }
            if (label57.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d5466);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label57.Visible = true;
            }
            if (label64.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d5466);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label64.Visible = true;
            }
            if (label58.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d5466);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label58.Visible = true;
            }
            if (label65.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d5466);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label65.Visible = true;
            }
            if (label59.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d5466);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label59.Visible = true;
            }
            if (label66.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d5466);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label66.Visible = true;
            }
            if (label60.InvokeRequired)
            {
                SetAnalizaCallBack d = new SetAnalizaCallBack(d5466);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.label60.Visible = true;
            }
		
		}
		
		
		void Label67Click(object sender, System.EventArgs e)
		{
			base.Dispose();
					
		}
		
		void Label15Click(object sender, System.EventArgs e)
		{
			base.Dispose();
		}
		void Label16Click(object sender, System.EventArgs e)
		{
			base.Dispose();
		}
		
		void Label68Click(object sender, System.EventArgs e)
		{
			base.Dispose();
		}
        private void start()
        {
            if (PLAYER == 1)
            {
                x = true;
                MessageBox.Show(this.Text + " eres X Empieza a Jugar");
            }
            else if (PLAYER == 0)
            {
                MessageBox.Show(this.Text + " eres O Aguarde para Jugar");
            }
        }

        private void UsuarioVsUsuario_Load(object sender, EventArgs e)
        {
            start();   
        }

	}
}
