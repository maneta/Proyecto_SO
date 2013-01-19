using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;  // Defino variables para guardar los  threads y los formularios.
        Form2 login;
        //Form3 users;
        Form4 consultas;
        
        string us;
       
        public Form1()
        {
            InitializeComponent();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("192.162.56.101");

           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse(comboBox1.Text);
            IPEndPoint ipep = new IPEndPoint(direc, 50001);
            

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
            }
            catch (SocketException)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

            //pongo en marcha el thread que atenderá los mensajes del servidor
            ThreadStart ts1 = delegate { atender_mensajes_servidor(); };
            Thread t1 = new Thread(ts1);
            t1.Start();
            
        }
      
        private void activar_formulario_login()
        {
            //Este thread lo único que hace es activar el formulario de login
            login = new Form2(server);
            login.ShowDialog();
        }
        private void activar_formulario_usuarios(string us)
        {
            //Este thread lo único que hace es activar el formulario de jugar o consultar
            //users = new Form3(server, us);
            //users.ShowDialog();
        }

        private void activar_formulario_consultas(string us)
        {
            //Activo el thread del formulario de las diferentes consultas
            consultas = new Form4(server);
            consultas.ShowDialog();
        }
       
        private void atender_mensajes_servidor()
        {
            //este thread atiende los mensajes del servidor
            Boolean continuar = true;
           
            while (continuar)
            {
                int op;
                byte[] msg = new byte[180];
                // recibo mensaje del servidor
                
                try
                {
                    server.Receive(msg);



                    string mensaje = Encoding.ASCII.GetString(msg);
                    string[] trozos = mensaje.Split(' ');
                    op = Convert.ToInt32(trozos[0]);
                    // Averiguo el tipo de mensaje

                    switch (op)
                    {
                        case 0: // mensaje confirmación de conexión establecida
                            MessageBox.Show("CONEXION CORRECTA CON EL SERVIDOR");
                            
                             //pongo en marcha el thread que activa el formulario de login
                            ThreadStart ts2 = delegate { activar_formulario_login(); };
                            Thread t2 = new Thread(ts2);
                            t2.Start();
                            break;
                        case 1: // mensaje confirmación de autentificación que el usuario se ha añadido correctamente
                            MessageBox.Show("Usuario dado de alta correctamente");
                            this.us = trozos[1];
                            // pongo en marcha el thread que activa el formulario de usuarios conectados y consultas
                           // ThreadStart ts4 = delegate { activar_formulario_consultas(this.us); };
                           // Thread t4 = new Thread(ts4);
                            //t4.Start();

                            break;
                        case 2:// Recido del servidor el mensaje con un valor de op=11 que querrá decir, caso 1, error 1.
                            MessageBox.Show("Ya te digo yo que tienes un problema con el usuario o el password!, si no lo pones bien vas a suspender...");
                            break;

                        case 3: // Activo formulario y thread en el que llamo a las consultas
                            // pongo en marcha el thread que activa el formulario de usuarios conectados y consultas
                            ThreadStart ts4 = delegate { activar_formulario_consultas(this.us); };
                            Thread t4 = new Thread(ts4);
                            t4.Start();

                            break;
                        
                        case 4: // Aqui debería de recibir el listado de conectados
                            
                            byte[] msg2 = new byte[80];
                            server.Receive(msg2);
                            string consulta_ganadores = Encoding.ASCII.GetString(msg2);
                            MessageBox.Show(consulta_ganadores);

                            break;

                    }
                }
                catch (SocketException e)
                {
                    MessageBox.Show("Socket error " + e.ErrorCode + ": " + e.Message);
                    continuar = false;
                }
                catch (Exception e) // Si se finaliza el servidor inesperadamente
                {
                    MessageBox.Show("Source error " + e.Source + ": " + e.Message);
                    continuar = false;
                }
            }
            MessageBox.Show("Finaliza atender a servidor");
            this.Close();
            Application.Exit();
        }
    }
}
