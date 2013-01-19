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

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        Socket server;
       
        public Form2(Socket s)
        {
            InitializeComponent();
            server = s;
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }
        // Enviamos mensaje para logearnos.
        // Previamente nos tenemos que haber registrado
        // Debemos introducir el mismo user y contraseña que al registrarte
        private void button1_Click(object sender, EventArgs e)
        {
            String usuarioContraseña = "1 " + usuario.Text + " " + contraseña.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(usuarioContraseña);
            server.Send(msg);
            



        }
        // Enviamos mensaje para registrarnos.
        
        private void button2_Click(object sender, EventArgs e)
        {
            String usuarioContraseña = "2 " + usuario.Text + " " + contraseña.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(usuarioContraseña);
            server.Send(msg);
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
