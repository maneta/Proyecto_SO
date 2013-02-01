using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace inicio
{
    public partial class Form4 : Form
    {
        Socket server;
        //DataTable Lista = new DataTable();
        //DataRow Fila;

        delegate void SetListaCallback(string text);

        public void SetLista(string text)
        {
            
            int i = 0;
            int j = 0;
            int index = 0;
            if (dataGridView1.InvokeRequired)
            {
                SetListaCallback d = new SetListaCallback(SetLista);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                //dataGridView1.Rows.Clear();
                this.dataGridView1.ColumnCount = 1;
                MessageBox.Show(text);
                string[] trozos = text.Split(',');
                List<string> Conectados = new List<string>(trozos);
                index = Conectados.Count;
                index--;
                this.dataGridView1.RowCount = index;
                Conectados.RemoveAt(index);
                //MessageBox.Show(text);
                foreach (string s in Conectados)
                {
                    dataGridView1[0, i].Value = s;
                    dataGridView1.ClearSelection();
                    i++;
                    //j++;
                }
            }

        }
            
        public Form4(Socket s)
        {
            InitializeComponent();

            server = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Lista.Columns.Add(new DataColumn("Jugadores Online"));
            //Fila = Lista.NewRow();
            //dataGridView1.DataSource = Lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // String usuarioContraseña = "5 " + usuario2.Text;
            //byte[] msg = System.Text.Encoding.ASCII.GetBytes(usuarioContraseña);
            // server.Send(msg);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder constructor = new StringBuilder();
            constructor.Append("3 ");
            //constructor.Append(usuario2.Text);

            string verify = constructor.ToString();
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(verify);
            server.Send(msg);

            /*  byte[] msg2 = new byte[80];
              server.Receive(msg2);
              string mensaje = Encoding.ASCII.GetString(msg2);
              MessageBox.Show(mensaje); */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String logoff = "100 " + this.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(logoff);
            server.Send(msg);
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UsuarioVsUsuario f = new UsuarioVsUsuario();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
