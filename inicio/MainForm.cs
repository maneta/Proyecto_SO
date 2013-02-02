/*
 * Created by SharpDevelop.
 * User: JuniorManuel Muñoz Cuiza
 * Date: 23/09/2008
 * Time: 08:24 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace inicio
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm
	{
		//[STAThread]
		//public static void Main(string[] args)
		//{
			//Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new MainForm());
		//}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, System.EventArgs e)
		{
			base.Dispose();
		}
		
		void B1Click(object sender, System.EventArgs e)
		{
			/*if(c1.Checked==true){
			UsuarioVsUsuario f=new UsuarioVsUsuario();
			f.Show();}
			if(c2.Checked==true){
			UsuarioVsPC f=new UsuarioVsPC();
			f.Show();}
			if(c3.Checked==true){
			PCVsPC f=new PCVsPC();
			f.Show();}*/
			
		}
		
		void C1MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			label2.Visible=true;
		}
		
		void Label4MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			label2.Visible=false;
			label3.Visible=false;
			label4.Visible=false;
		}
		
		void C1MouseLeave(object sender, System.EventArgs e)
		{
			label2.Visible=false;
		}
		
		void C2MouseLeave(object sender, System.EventArgs e)
		{
			label3.Visible=false;
		}
		
		void C2MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			label3.Visible=true;
		}
		
		void C3MouseLeave(object sender, System.EventArgs e)
		{
			label4.Visible=false;
		}
		
		void C3MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			label4.Visible=true;
		}
		
		void B1MouseLeave(object sender, System.EventArgs e)
		{
			label5.Visible=false;
		}
		
		void B1MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			label5.Visible=true;
		}
		
		void Label1MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			label6.Visible=true;
		}
		
		void Label1MouseLeave(object sender, System.EventArgs e)
		{label6.Visible=false;
			
		}
		
		
		
		void Timer1Tick(object sender, System.EventArgs e)
		{
					}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
	}
}
