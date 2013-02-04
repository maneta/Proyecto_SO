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
        string INVITADO = "";
        UsuarioVsUsuario jogo;
        List<UsuarioVsUsuario> jogos = new List<UsuarioVsUsuario>();

        delegate void SetListaCallback(string text);

        public void SetInvitacion(string text,int id)
        {
            string invitacion = "Invitación de " + text;
            string header = "Aceptas Jugar " + this.Text + "?";
            DialogResult res= MessageBox.Show(invitacion, header, MessageBoxButtons.YesNo);

        if (res == DialogResult.Yes)
        {
            String resultado = "5 1" + " " + Convert.ToString(id);
            MessageBox.Show(resultado);
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
            server.Send(msg);
        }
        else
        {
            String resultado = "5 0" + " " +Convert.ToString(id);
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(resultado);
            server.Send(msg);
        }

        }
        
        public void SetJuego(int player,int idgame)
        {
            ThreadStart tsjogo = delegate { activar_juego(player,idgame); };

            /*Creo un nuevo thread a partir de ts2 que es la referencia de chat->FormuralioSecundario*/
            Thread tjogo = new Thread(tsjogo);
            /*Se inicia una nueva instancia del formulario de forma concurrente*/
            tjogo.Start();
        }
        
        public void SetJugada(int player_local,int jugada,int id_game)
        {
            string search = this.Text + " " + Convert.ToString(id_game);
            foreach (UsuarioVsUsuario juego in jogos)
            {
                if (juego.Text.Equals(search))
                {
                    
                    juego.SetJugada(player_local,jugada);
                }
            }
        }

        public void SetLista(string text)
        {
            
            int i = 0;
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
                string[] trozos = text.Split(',');
                List<string> Conectados = new List<string>(trozos);
                index = Conectados.Count;
                index--;
                this.dataGridView1.RowCount = index;
                Conectados.RemoveAt(index);
                foreach (string s in Conectados)
                {
                    dataGridView1[0, i].Value = s;
                    dataGridView1.ClearSelection();
                    i++;
                }
            }

        }

        public void SetLista2(string text)
        {

            int i = 0;
            int index = 0;
            if (dataGridView1.InvokeRequired)
            {
                SetListaCallback d = new SetListaCallback(SetLista2);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                //dataGridView1.Rows.Clear();
                this.dataGridView2.ColumnCount = 1;
                string[] trozos = text.Split(',');
                List<string> Conectados = new List<string>(trozos);
                index = Conectados.Count;
                index--;
                this.dataGridView2.RowCount = index;
                Conectados.RemoveAt(index);
                //MessageBox.Show(text);
                foreach (string s in Conectados)
                {
                    dataGridView2[0, i].Value = s;
                    dataGridView2.ClearSelection();
                    i++;
                }
            }

        }
            
        public Form4(Socket s)
        {
            InitializeComponent();

            server = s;
        }

        private void activar_juego(int jugador, int idpartida_local)
        {
            /* El form chat se crea y de momento no se thredea, se esta ejecutando en este pequeño
             * espacio de tiempo "bloqueando el código" 
             */

            /*Este thread lo único que hace es activar el formulario de Chat*/
            jogo = new UsuarioVsUsuario(server,jugador,idpartida_local);
            jogo.Text = this.Text + ' ' +  Convert.ToString(idpartida_local);

            /*agrego la nueva instancia del formulario en la instancia de la lista formularios*/
            jogos.Add(jogo);

            /*enseño por pantalla la nueva instancia del formulario*/
            jogo.ShowDialog();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            String jogadores = "9 " + this.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(jogadores);
            server.Send(msg);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Lista.Columns.Add(new DataColumn("Jugadores Online"));
            //Fila = Lista.NewRow();
            //dataGridView1.DataSource = Lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ganadores = "10 " + this.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(ganadores);
            server.Send(msg);

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
            //UsuarioVsUsuario f = new UsuarioVsUsuario();
            //f.Show();
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
            if (INVITADO == this.Text || INVITADO == "")
            {
                MessageBox.Show("No Puedes Invitar a ti Mismo");
            }
            else
            {
                String invitacion = "4 " + this.Text + " " + INVITADO;
                //MessageBox.Show(invitacion);
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(invitacion);
                server.Send(msg);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DateTime result = dateTimePicker1.Value;
            String fecha_inicial = result.ToString();
            String [] constructor = fecha_inicial.Split(' ');
            String[] sub_fecha = constructor[0].Split('/');
            fecha_inicial = sub_fecha[2] + "-" + sub_fecha[1] + "-" + sub_fecha[0] + " " + constructor[1];
            
            DateTime result2 = dateTimePicker2.Value;
            String fecha_final = result2.ToString();
            String[] constructor2 = fecha_final.Split(' ');
            String[] sub_fecha2 = constructor2[0].Split('/');
            fecha_final = sub_fecha2[2] + "-" + sub_fecha2[1] + "-" + sub_fecha2[0] + " " + constructor2[1];
            
            String datetime = "11 " + this.Text + " " + fecha_inicial + " " + fecha_final;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(datetime);
            server.Send(msg);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
