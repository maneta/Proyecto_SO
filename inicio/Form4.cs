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
using System.Threading;

namespace inicio
{
    public partial class Form4 : Form
    {
        Socket server;
        //DataTable Lista = new DataTable();
        //DataRow Fila;
        string INVITADO;
        UsuarioVsUsuario jogo;
        List<UsuarioVsUsuario> jogos = new List<UsuarioVsUsuario>();

        delegate void SetListaCallback(string text);

        public void SetInvitacion(string text)
        {
            string invitacion = "Invitacio de " + text;
            string header = "Aceptas Jugar " + this.Text + "?";
            DialogResult res= MessageBox.Show(invitacion, header, MessageBoxButtons.YesNo);

        if (res == DialogResult.Yes)
        {
            String resultado = "5 1" + this.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
            server.Send(msg);
        }
        else
        {
            String resultado = "5 0" + this.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
            server.Send(msg);
        }

        }
        
        public void SetJuego(int player)
        {
            ThreadStart tsjogo = delegate { activar_juego(); };

            /*Creo un nuevo thread a partir de ts2 que es la referencia de chat->FormuralioSecundario*/
            Thread tjogo = new Thread(tsjogo);
            /*Se inicia una nueva instancia del formulario de forma concurrente*/
            tjogo.Start();
        }

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

        private void activar_juego()
        {
            /* El form chat se crea y de momento no se thredea, se esta ejecutando en este pequeño
             * espacio de tiempo "bloqueando el código" 
             */

            /*Este thread lo único que hace es activar el formulario de Chat*/
            jogo = new UsuarioVsUsuario();
            jogo.Text = this.Text;

            /*agrego la nueva instancia del formulario en la instancia de la lista formularios*/
            jogos.Add(jogo);

            /*enseño por pantalla la nueva instancia del formulario*/
            jogo.ShowDialog();
            
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
            string verify = constructor.ToString();
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(verify);
            server.Send(msg);

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
            
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                INVITADO = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*Boton Responsable por enviar la peticion (4) de invitacion*/
            String invitacion = "4 " + this.Text + " " + INVITADO;
            MessageBox.Show(invitacion);
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(invitacion);
            server.Send(msg);

        }
    }
}
