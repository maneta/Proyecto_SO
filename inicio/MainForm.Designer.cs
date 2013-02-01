/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 23/09/2008
 * Time: 08:24 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace inicio
{
	partial class MainForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.c1 = new System.Windows.Forms.RadioButton();
            this.c2 = new System.Windows.Forms.RadioButton();
            this.c3 = new System.Windows.Forms.RadioButton();
            this.b1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.SystemColors.ControlText;
            this.c1.Checked = true;
            this.c1.ForeColor = System.Drawing.Color.Yellow;
            this.c1.Location = new System.Drawing.Point(12, 317);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(118, 24);
            this.c1.TabIndex = 0;
            this.c1.TabStop = true;
            this.c1.Text = "Usuario Vs Usuario";
            this.c1.UseVisualStyleBackColor = false;
            this.c1.MouseLeave += new System.EventHandler(this.C1MouseLeave);
            this.c1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.C1MouseMove);
            // 
            // c2
            // 
            this.c2.BackColor = System.Drawing.SystemColors.ControlText;
            this.c2.ForeColor = System.Drawing.Color.Yellow;
            this.c2.Location = new System.Drawing.Point(12, 347);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(118, 24);
            this.c2.TabIndex = 1;
            this.c2.Text = "Usuario Vs PC";
            this.c2.UseVisualStyleBackColor = false;
            this.c2.MouseLeave += new System.EventHandler(this.C2MouseLeave);
            this.c2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.C2MouseMove);
            // 
            // c3
            // 
            this.c3.BackColor = System.Drawing.SystemColors.ControlText;
            this.c3.ForeColor = System.Drawing.Color.Yellow;
            this.c3.Location = new System.Drawing.Point(12, 377);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(118, 24);
            this.c3.TabIndex = 2;
            this.c3.Text = "PC Vs PC";
            this.c3.UseVisualStyleBackColor = false;
            this.c3.MouseLeave += new System.EventHandler(this.C3MouseLeave);
            this.c3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.C3MouseMove);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ControlText;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.b1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.ForeColor = System.Drawing.Color.Yellow;
            this.b1.Location = new System.Drawing.Point(164, 348);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(93, 23);
            this.b1.TabIndex = 3;
            this.b1.Text = "Next";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.B1Click);
            this.b1.MouseLeave += new System.EventHandler(this.B1MouseLeave);
            this.b1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.B1MouseMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(418, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.Label1Click);
            this.label1.MouseLeave += new System.EventHandler(this.Label1MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1MouseMove);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(115, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Juego 1 a 1 muy divertido";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(96, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 61);
            this.label3.TabIndex = 6;
            this.label3.Text = "Si eres bueno en tres en raya intenta ganar";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(96, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 66);
            this.label4.TabIndex = 7;
            this.label4.Text = "Observa como luchan 2 ordenadores";
            this.label4.Visible = false;
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label4MouseMove);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(263, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 66);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vamos Elige tu opcion";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(381, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 48);
            this.label6.TabIndex = 9;
            this.label6.Text = "Salir";
            this.label6.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(454, 441);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.MaximumSize = new System.Drawing.Size(470, 457);
            this.MinimumSize = new System.Drawing.Size(470, 457);
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton c1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button b1;
		private System.Windows.Forms.RadioButton c2;
		private System.Windows.Forms.RadioButton c3;
	}
}
