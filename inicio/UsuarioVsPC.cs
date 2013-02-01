/*
 * Created by SharpDevelop.
 * User: Junior Manuel Muñoz Cuiza
 * Date: 24/09/2008
 * Time: 12:15 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace inicio
{
	/// <summary>
	/// Description of UsuarioVsPC.
	/// </summary>
	public partial class UsuarioVsPC
	{
		public UsuarioVsPC()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private bool x=true;
		private bool o=true;
		private int c=0;
		private String B1="",B2="",B3="",B4="",B5="",B6="",B7="",B8="",B9="";
		void P1Click(object sender, System.EventArgs e)
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
											
			if(x==true&&this.p1.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				B1="x";c++;
				this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
			}
			
			piensa();analiza();
			
		}
		void P2Click(object sender, System.EventArgs e)
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p2.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				B2="x";c++;
				this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
			}
			tiempo();
			piensa();analiza();
		}
		
		void P3Click(object sender, System.EventArgs e)
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p3.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				B3="x";c++;
				this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
			}tiempo();
			piensa();analiza();}
		
		void P4Click(object sender, System.EventArgs e)
			
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p4.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				B4="x";c++;
				this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
			}tiempo();
		piensa();analiza();}
		void P5Click(object sender, System.EventArgs e)
			
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p5.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				B5="x";c++;
				this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
			}tiempo();
		piensa();analiza();}
		void P6Click(object sender, System.EventArgs e)
			
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p6.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				B6="x";c++;
				this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
			}tiempo();
		piensa();analiza();}
		void P7Click(object sender, System.EventArgs e)
			
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p7.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				B7="x";c++;
				this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
			}tiempo();
		piensa();analiza();	}
		void P8Click(object sender, System.EventArgs e)
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p8.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				B8="x";c++;
				this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
			}tiempo();
	piensa();analiza();	}
		
		void P9Click(object sender, System.EventArgs e)
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
			if(x==true&&this.p9.BackgroundImage == ((System.Drawing.Image)(resources.GetObject(""))))
			{	x=false;
				B9="x";c++;
				this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
			}tiempo();
	piensa();analiza();	}
		
		
		public void d1727()
		{this.label17.Visible = true;this.label18.Visible = true;
		this.label19.Visible = true;this.label20.Visible = true;
		this.label21.Visible = true;this.label22.Visible = true;
		this.label23.Visible = true;this.label24.Visible = true;
		this.label25.Visible = true;this.label26.Visible = true;
		this.label27.Visible = true;this.label28.Visible = true;
		
		}		
		public void d2941()
		{this.label29.Visible = true;this.label39.Visible = true;
		this.label30.Visible = true;this.label40.Visible = true;
		this.label31.Visible = true;this.label32.Visible = true;
		this.label33.Visible = true;this.label34.Visible = true;
		this.label35.Visible = true;this.label36.Visible = true;
		this.label37.Visible = true;this.label38.Visible = true;
		this.label41.Visible = true;
		
		}
		public void d4253()
		{this.label42.Visible = true;this.label48.Visible = true;
		this.label43.Visible = true;this.label49.Visible = true;
		this.label44.Visible = true;this.label50.Visible = true;
		this.label45.Visible = true;this.label51.Visible = true;
		this.label46.Visible = true;this.label52.Visible = true;
		this.label47.Visible = true;this.label53.Visible = true;
		
		}
		public void d5466()
		{this.label54.Visible = true;this.label61.Visible = true;
		this.label55.Visible = true;this.label62.Visible = true;
		this.label56.Visible = true;this.label63.Visible = true;
		this.label57.Visible = true;this.label64.Visible = true;
		this.label58.Visible = true;this.label65.Visible = true;
		this.label59.Visible = true;this.label66.Visible = true;
		this.label60.Visible = true;
		
		}
		public void piensa()
		{c++;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioVsUsuario));
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		    this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		    o=false;x=true;B5="o";
		    
		}
		if (B2=="x" && B1=="x" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="")
		{	    
		     this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		   		}
		if (B1=="x" && B2=="x" && B3=="o" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="")
		{
		     this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		    		}
		if (B1=="x" && B2=="x" && B3=="o" && B4=="o" && B5=="o" && B6=="" && B7=="x" && B8=="x" && B9=="")
		{
		       this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		         
		   		}
		if (B1=="x" && B2=="x" && B3=="o" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="")
		{
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		       
		}	
		
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="x")
		{	    
		     this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		    		}

		if (B1=="x" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="o" && B7=="" && B8=="" && B9=="x")
		{
		     this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		   		}
		if (B1=="x" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="o" && B8=="" && B9=="x")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		    		}

		if (B1=="x" && B2=="o" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="o" && B8=="x" && B9=="x")
		{
			analiza();
		} ///4
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{		   
		    this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		    		}
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="")
		{		    
		     this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		    		}
		if (B1=="x" && B2=="" && B3=="" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="")
		{
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		    		}
		if (B1=="x" && B2=="x" && B3=="" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="")
		{
		     this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		      
		}
		///5
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{	    
		     this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		    		}
		if (B1=="x" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		      this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		   }
		if (B1=="x" && B2=="o" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="")
		{
		     this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		   }
		if (B1=="x" && B2=="o" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="o" && B8=="x" && B9=="x")
		{
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		    		}
		if (B1=="x" && B2=="o" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="o" && B8=="x" && B9=="x")
		{
			analiza();
		}		///6
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{	    
		   this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		    }
		if (B1=="x" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		      this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		    		}
		if (B1=="x" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="o" && B8=="" && B9=="")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		    		}
		if (B1=="x" && B2=="o" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="o" && B8=="x" && B9=="")
		{
		     this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		     
		}
		if (B1=="x" && B2=="o" && B3=="x" && B4=="" && B5=="o" && B6=="x" && B7=="o" && B8=="x" && B9=="")
		{
		     this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		      
		}
		///7
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		     this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		   	}
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="")
		{
		       this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		   		}
		if (B1=="x" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="o" && B8=="x" && B9=="")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		    		}
		if (B1=="x" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="o" && B8=="x" && B9=="")
		{
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		      
		    }
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="x" && B7=="o" && B8=="x" && B9=="")
		{
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		      
		    }
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="o" && B8=="x" && B9=="x")
		{
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		       
		    }
		if (B1=="x" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="o" && B8=="x" && B9=="")
		{
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		       
		    }
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		     this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		    }
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		       this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		   		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="")
		{
		     this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		   		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="x" && B9=="")
		{
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		        
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="x")
		{
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		    }
		if (B1=="x" && B2=="x" && B3=="o" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="x")
		{
			analiza();
		}
		if (B1=="x" && B2=="o" && B3=="o" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="x" && B9=="x")
		{		    
			analiza();
		}
		if (B1=="x" && B2=="x" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="")
		{    this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		       
		    		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="x" && B9=="")
		{
		    this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		       
		    }
		if (B1=="x" && B2=="" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="x")
		{
		    this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		       
		    }
		if (B1=="x" && B2=="" && B3=="o" && B4=="x" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		     this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		      
		   	}
		if (B1=="x" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="o" && B7=="" && B8=="" && B9=="x")
		{
		    this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		       
		    }
		if (B1=="x" && B2=="x" && B3=="o" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="")
		{
		   this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		    
		}
		if (B1=="x" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="o" && B8=="" && B9=="")
		{
		  this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
   
		}
		if (B1=="x" && B2=="x" && B3=="o" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="x")
		{
		   this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";  
		    
		}
		if (B1=="x" && B2=="o" && B3=="x" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		   this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
 
		}
		if (B1=="x" && B2=="o" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
				 
		    }
		if (B1=="x" && B2=="o" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="")
		{
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		        
		  		}
		if (B1=="x" && B2=="o" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="x")
		{
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		       
		  	}
		if (B1=="x" && B2=="x" && B3=="" && B4=="o" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="")
		{
		   this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		       
		  	}
		if (B1=="x" && B2=="" && B3=="" && B4=="o" && B5=="o" && B6=="" && B7=="x" && B8=="x" && B9=="")
		{
		  this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		     
		   }
		if (B1=="x" && B2=="" && B3=="" && B4=="o" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="x")
		{
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		       
		  }
		if (B1=="x" && B2=="" && B3=="x" && B4=="o" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="")
		{
		   this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		     
		    
		} 
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="o" && B7=="" && B8=="x" && B9=="x")
		{
		    this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		       
		   }
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="o" && B7=="x" && B8=="" && B9=="x")
		{
		   this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     
		   
		}
		if (B1=="x" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="o" && B7=="" && B8=="" && B9=="x")
		{
		   this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     
		    
		}
		if (B1=="x" && B2=="x" && B3=="o" && B4=="o" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="x")
		{
		   this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		       
		   }
		if (B1=="x" && B2=="o" && B3=="x" && B4=="x" && B5=="o" && B6=="x" && B7=="o" && B8=="" && B9=="")
		{
		   this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		      
		   }
		if (B1=="x" && B2=="o" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="o" && B8=="" && B9=="x")
		{
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		     
		  }
		if (B1=="x" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="o" && B8=="" && B9=="x")
		{
		   this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		     
		 	}
		if (B1=="x" && B2=="" && B3=="x" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="")
		{
		     this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		      
		  }
		if (B1=="x" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="x" && B7=="o" && B8=="" && B9=="")
		{
		     this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		      
		 }
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		     this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		  	}
		if (B1=="" && B2=="x" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		   this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		    
		}
		if (B1=="o" && B2=="x" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="x")
		{	    
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		   	}
		if (B1=="o" && B2=="x" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="" && B8=="" && B9=="x")
		{	   
		     this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		     
		  		}
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		    this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		   	}
		if (B1=="" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="")
		{	    
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		  		}
		if (B1=="o" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="x")
		{		     
		    this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		   		}
		if (B1=="o" && B2=="x" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="o" && B8=="" && B9=="x")
		{	     
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		      
		    }
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{	     
		  this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
 		}
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="")
		{
		   this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		    	}
		if (B1=="o" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="x")
		{
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		    
		  }
		if (B1=="o" && B2=="x" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="o" && B9=="x")
		{
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		    
		    }

		if (B1=="o" && B2=="x" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="x" && B8=="o" && B9=="x")
		{	    
			analiza();
		} ///4
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		     this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		    }
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="")
		{	    
		   this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		    }

		if (B1=="" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="o" && B7=="" && B8=="x" && B9=="")
		{
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		    }

		if (B1=="x" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="o" && B7=="" && B8=="x" && B9=="")
		{	     
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		    		}
		if (B1=="x" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="o" && B7=="" && B8=="x" && B9=="o")
		{
		   this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
   
		}
		if (B1=="" && B2=="x" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="" && B8=="x" && B9=="o")
		{	   
 			this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		      
		 	}
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		       this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		  	}
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="x")
		{	    
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		   		}
		if (B1=="" && B2=="x" && B3=="o" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="x")
		{
		   this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		    }
		if (B1=="x" && B2=="x" && B3=="o" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="o" && B9=="x")
		{
		     this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		   	}
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{	    
		   this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		 		}
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		  	}
		if (B1=="" && B2=="x" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="")
		{
		     this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		   	}
		if (B1=="x" && B2=="x" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="o")
		{     
		    this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     
		}
		if (B1=="o" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="")
		{
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		      
 		}
		if (B1=="" && B2=="x" && B3=="o" && B4=="x" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		   this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		      
		}
		if (B1=="o" && B2=="x" && B3=="x" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		  	     
		  		}
		if (B1=="o" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="")
		{
		   this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		 		     
		 		}
		if (B1=="o" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		  	     
		   		}
		if (B1=="o" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="x" && B9=="")
		{
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		        
		}
		if (B1=="o" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="")
		{
		   this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		      
		     
		}
		if (B1=="o" && B2=="x" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="")
		{
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		      
 
		}
		if (B1=="o" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="")
		{
		   this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		      
		   }
		if (B1=="o" && B2=="x" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		   this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		}
		    
		if (B1=="x" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="o" && B7=="" && B8=="x" && B9=="")
		{
		   this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     
		     
		}
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="o" && B7=="x" && B8=="x" && B9=="")
		{
		    this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		    
		    		}
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="o" && B7=="" && B8=="x" && B9=="x")
		{
		   this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     
		   		}
		if (B1=="" && B2=="x" && B3=="x" && B4=="" && B5=="o" && B6=="o" && B7=="" && B8=="x" && B9=="")
		{
		    this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     
		 		}
		if (B1=="" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="o" && B7=="x" && B8=="x" && B9=="o")
		{
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		    		     
		    		}
		if (B1=="o" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="x" && B7=="o" && B8=="" && B9=="x")
		{
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		    		     
		     		}
		if (B1=="o" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="o" && B8=="x" && B9=="x")
		{
		     this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		     		     
		    		}
		if (B1=="" && B2=="x" && B3=="o" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="x")
		{
		     this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		     		     
		  	}
		if (B1=="" && B2=="x" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="x")
		{
		     this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		     		     
		    		}
		if (B1=="" && B2=="x" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="x" && B9=="")
		{
		     this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		     		     
		    		}
		if (B1=="o" && B2=="x" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="")
		{
		     this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		     		     
		    		}
		if (B1=="x" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="o" && B7=="o" && B8=="" && B9=="x")
		{  this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		     		     
 		}
		if (B1=="x" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="o" && B7=="o" && B8=="x" && B9=="x")
		{
		   this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		    		     
		    		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		       this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		     }
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="")
		{
		       this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		     		}
		if (B1=="x" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="o")
		{
		      this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		     
		}
		if (B1=="x" && B2=="o" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="x" && B9=="o")
		{
		      this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     	}
		if (B1=="x" && B2=="o" && B3=="x" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="x" && B9=="o")
		{
			analiza();
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		       this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		    
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		       this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		     }
		if (B1=="o" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="x")
		{
		        this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		     		}
		if (B1=="o" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="x" && B8=="" && B9=="x")
		{
		     this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		    		}
		if (B1=="o" && B2=="x" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="x" && B8=="o" && B9=="x")
		{
			analiza();
		}
		if (B1=="o" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="")
		{
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		    		     
		     		}
		if (B1=="o" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="")
		{
		   this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		     		     
		     		}
		if (B1=="o" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		     		     
		    		}
		if (B1=="o" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="" && B8=="x" && B9=="x")
		{
		    this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		    		     
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		    this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="")
		{
		     this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     		}
		if (B1=="" && B2=="" && B3=="x" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="")
		{
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		     		}
		if (B1=="x" && B2=="" && B3=="x" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="o")
		{
		     this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		     		}
		if (B1=="" && B2=="x" && B3=="x" && B4=="o" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="")
		{
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		    		     
		     		}
		if (B1=="" && B2=="" && B3=="x" && B4=="o" && B5=="o" && B6=="" && B7=="x" && B8=="x" && B9=="")
		{
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		          
		     
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="o" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="x")
		{
		   this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		     	     
		     		}
		if (B1=="" && B2=="" && B3=="x" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="x" && B9=="o")
		{
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		         
		     		}
		if (B1=="" && B2=="x" && B3=="x" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="o")
		{
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		         
		     		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="x" && B9=="o")
		{
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		     		     
		     		}
		if (B1=="" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="o")
		{
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		     		     
		     		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="x" && B9=="o")
		{
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		     		     
		   		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="x" && B9=="o")
		{
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		     		     
		   		}
		if (B1=="" && B2=="x" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="o")
		{
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		    		     
		     		}
		if (B1=="x" && B2=="o" && B3=="x" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="x" && B9=="o")
		{
		   this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		    		     
		   		}
		if (B1=="x" && B2=="o" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="o")
		{
		    this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		     		     
		    		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		      	this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		     		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="x")
		{
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		    		}
		if (B1=="" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="" && B8=="" && B9=="x")
		{
		     this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		     		}
		if (B1=="" && B2=="x" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="" && B8=="o" && B9=="x")
		{
		   this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		     		     
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="o" && B7=="" && B8=="x" && B9=="x")
		{
		    this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     		     
		     		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="o" && B7=="x" && B8=="" && B9=="x")
		{
		    this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		    		     
		   		}
		if (B1=="" && B2=="x" && B3=="x" && B4=="" && B5=="o" && B6=="o" && B7=="" && B8=="" && B9=="x")
		{
		    this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     	     
		     		}
		if (B1=="" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="x" && B8=="o" && B9=="x")
		{
		   this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		         
		   		}
		if (B1=="x" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="" && B8=="o" && B9=="x")
		{
		     this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		    	     
		}

		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
 			this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		 }
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		     this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		}
		if (B1=="x" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="o")
		{
		     	 this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		  }
		if (B1=="x" && B2=="o" && B3=="x" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="x" && B9=="o")
		{
		    this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		}
		if (B1=="" && B2=="x" && B3=="x" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="o")
		{
		     this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";

		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="o")
		{
		   this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
  
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="o")
		{
		   this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		     
  
		}
		if (B1=="x" && B2=="o" && B3=="x" && B4=="x" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="o")
		{
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		    
 
		}
		if (B1=="x" && B2=="o" && B3=="x" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="o")
		{
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
 
		    
		}
		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		    
		   this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		   
		}
		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		    this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		    
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="x" && B7=="o" && B8=="" && B9=="")
		{
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		     
		}
		if (B1=="x" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="x" && B7=="o" && B8=="" && B9=="o")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		     
		}
		if (B1=="x" && B2=="o" && B3=="x" && B4=="x" && B5=="o" && B6=="x" && B7=="o" && B8=="x" && B9=="o")
		{
			analiza();
		     
		}

		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="x" && B7=="o" && B8=="x" && B9=="")
		{
		   this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
     
		}
		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="x" && B7=="o" && B8=="" && B9=="x")
		{
		   this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
   
		}
		if (B1=="" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="x" && B7=="o" && B8=="" && B9=="")
		{
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		        
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="x" && B7=="o" && B8=="x" && B9=="o")
		{
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
    
		}
		if (B1=="" && B2=="x" && B3=="x" && B4=="x" && B5=="o" && B6=="x" && B7=="o" && B8=="" && B9=="o")
		{
		   this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
 
		}
		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{ 
		   this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		     
		}
		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="")
		{
		    
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		     
		}
		if (B1=="o" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="x")
		{
		     
		   this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		     
		}
		if (B1=="o" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="x" && B8=="o" && B9=="x")
		{
		    
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		    
		}
		if (B1=="o" && B2=="x" && B3=="o" && B4=="x" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="x")
		{
			analiza();
		     
		}

		if (B1=="o" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="x" && B8=="x" && B9=="")
		{
		   this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";

		}
		if (B1=="o" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="")
		{
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";

		}
		if (B1=="o" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="x")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
   
		}
		if (B1=="o" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="x" && B8=="o" && B9=="x")
		{
		   this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
   
 
		}
		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		    this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
   
		    
		}
		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="")
		{
		     
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
   
		     
		}
		if (B1=="x" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="o")
		{
		    
		   this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		     
		}
		if (B1=="x" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="o" && B8=="x" && B9=="o")
		{
		     
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		     
		     
		}
		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="x" && B8=="x" && B9=="o")
		{
		   this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		      
		    
		}
		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="x" && B7=="" && B8=="x" && B9=="o")
		{this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		}
		if (B1=="" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="o")
		{this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		}
		if (B1=="x" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="x" && B7=="o" && B8=="x" && B9=="o")
		{
		   this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		   
		}
		if (B1=="x" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="o" && B8=="x" && B9=="o")
		{
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
  
		}
		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		     
		    this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		     
		}
		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="" && B8=="" && B9=="x")
		{
		     
		    this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		     
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="" && B7=="o" && B8=="" && B9=="x")
		{
		     
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		     
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="o" && B8=="x" && B9=="x")
		{
		     
		     this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		     
		     
		}
		if (B1=="" && B2=="x" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="o" && B8=="" && B9=="x")
		{
		     
		     this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
	    
		}
		if (B1=="" && B2=="x" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="o" && B8=="" && B9=="x")
		{
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
  
		     
		}
		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="o" && B8=="x" && B9=="x")
		{
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
   
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="" && B9=="")
		{    
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		     
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		     
		   this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		     
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="" && B5=="x" && B6=="x" && B7=="" && B8=="" && B9=="o")
		{
		     
		   this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     
		}
		if (B1=="x" && B2=="x" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="" && B8=="" && B9=="o")
		{
		     
		   this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
     
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="" && B8=="x" && B9=="o")
		{
		   this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";   
		     
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="x" && B8=="" && B9=="o")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o"; 
    
		}
		if (B1=="x" && B2=="x" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="" && B9=="o")
		{
		   this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o"; 
  
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="x" && B8=="" && B9=="o")
		{
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
    
		     
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="x" && B5=="x" && B6=="" && B7=="" && B8=="" && B9=="o")
		{
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
   
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="x" && B9=="o")
		{
		   this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
   
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		     
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		     
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="x" && B5=="x" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		     
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		     
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="x" && B5=="x" && B6=="o" && B7=="" && B8=="" && B9=="x")
		{
		     
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		     
		}
		if (B1=="o" && B2=="x" && B3=="o" && B4=="x" && B5=="x" && B6=="o" && B7=="" && B8=="" && B9=="x")
		{     
		   this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
   
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="x" && B5=="x" && B6=="o" && B7=="" && B8=="" && B9=="")
		{
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
  
		}
		if (B1=="" && B2=="x" && B3=="o" && B4=="x" && B5=="x" && B6=="o" && B7=="" && B8=="" && B9=="")
		{
		     this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
  
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="x" && B5=="x" && B6=="o" && B7=="x" && B8=="" && B9=="")
		{
		     this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
      
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="x" && B5=="x" && B6=="o" && B7=="" && B8=="x" && B9=="")
		{
		     this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
  
		}
		if (B1=="o" && B2=="" && B3=="o" && B4=="x" && B5=="x" && B6=="o" && B7=="x" && B8=="" && B9=="x")
		{
		     this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";

		}
		if (B1=="o" && B2=="" && B3=="o" && B4=="x" && B5=="x" && B6=="o" && B7=="" && B8=="x" && B9=="x")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";

		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		     
		   this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		     
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="x" && B8=="" && B9=="")
		{
		     this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";  
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="" && B5=="x" && B6=="x" && B7=="x" && B8=="" && B9=="o")
		{
		     
		   this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     
		}
		if (B1=="" && B2=="x" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="x" && B8=="" && B9=="o")
		{
		     
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
    
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="x" && B8=="x" && B9=="o")
		{
		     this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o"; 

		}
		if (B1=="x" && B2=="o" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="x" && B8=="x" && B9=="o")
		{
			analiza();
		     
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="x" && B8=="" && B9=="o")
		{
		     
		   this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
 
		}
		if (B1=="" && B2=="x" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="x" && B8=="" && B9=="o")
		{
		   this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
 
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="x" && B8=="x" && B9=="o")
		{
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";

		     
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="x" && B5=="x" && B6=="" && B7=="x" && B8=="" && B9=="o")
		{
		   this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";

		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		     
		   this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		     
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="x" && B9=="")
		{
		     
		   this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		     
		}
		if (B1=="x" && B2=="o" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="x" && B9=="")
		{
		     
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		     
		}
		if (B1=="x" && B2=="o" && B3=="o" && B4=="" && B5=="x" && B6=="x" && B7=="" && B8=="x" && B9=="o")
		{
		     this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		  

		}
		if (B1=="" && B2=="o" && B3=="o" && B4=="x" && B5=="x" && B6=="" && B7=="" && B8=="x" && B9=="")
		{
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
 
		}
		if (B1=="" && B2=="o" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="x" && B8=="x" && B9=="")
		{
		   this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
 
		}
		if (B1=="" && B2=="o" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="x" && B9=="x")
		{
		   this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";

		     
		}
		if (B1=="" && B2=="o" && B3=="o" && B4=="" && B5=="x" && B6=="x" && B7=="" && B8=="x" && B9=="")
		{
		   this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";

		}
		if (B1=="x" && B2=="o" && B3=="o" && B4=="x" && B5=="x" && B6=="" && B7=="" && B8=="x" && B9=="o")
		{
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		}
		if (B1=="x" && B2=="o" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="x" && B8=="x" && B9=="o")
		{
		     this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
  
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		     
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		     
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="" && B9=="x")
		{
		     this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		     
		}
		if (B1=="o" && B2=="x" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="" && B9=="x")
		{
		     
		     this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		     
		}
		if (B1=="o" && B2=="x" && B3=="o" && B4=="x" && B5=="x" && B6=="" && B7=="" && B8=="o" && B9=="x")
		{
		     
		   this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
   
		}
		if (B1=="o" && B2=="x" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="x" && B8=="o" && B9=="x")
		{
		     
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
	  
		}
		if (B1=="o" && B2=="x" && B3=="o" && B4=="" && B5=="x" && B6=="x" && B7=="" && B8=="o" && B9=="x")
		{
		     
		   this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     
		}
		if (B1=="o" && B2=="x" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="x" && B8=="o" && B9=="x")
		{
		     
			analiza();
		}
		if (B1=="o" && B2=="" && B3=="o" && B4=="x" && B5=="x" && B6=="" && B7=="" && B8=="" && B9=="x")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";

		}
		if (B1=="o" && B2=="" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="x" && B8=="" && B9=="x")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
    
		}
		if (B1=="o" && B2=="" && B3=="o" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="x" && B9=="x")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
     
		}
		if (B1=="o" && B2=="" && B3=="o" && B4=="" && B5=="x" && B6=="x" && B7=="" && B8=="" && B9=="x")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";

		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="x" && B6=="" && B7=="" && B8=="" && B9=="")
		{
		     
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		     
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="" && B5=="x" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		     
		    this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		     
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		     
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="" && B8=="x" && B9=="o")
		{
		     
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
    
		}
		if (B1=="" && B2=="x" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		     
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		     
		}
		if (B1=="" && B2=="x" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="" && B8=="o" && B9=="x")
		{
		     
		   this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		     
		}
		if (B1=="o" && B2=="x" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="x" && B8=="o" && B9=="x")
		{
			analiza();
		     
		} 
		if (B1=="x" && B2=="x" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="" && B8=="o" && B9=="")
		{
		     
		     this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		     
		}
		if (B1=="x" && B2=="x" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="x" && B8=="o" && B9=="o")
		{
			analiza();
		     
		} 
		if (B1=="" && B2=="" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="x" && B8=="" && B9=="")
		{
		     
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		     
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="x" && B8=="o" && B9=="")
		{
		     
		     this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		     
		}
		if (B1=="" && B2=="x" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="x" && B8=="o" && B9=="")
		{		     
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
    
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="" && B8=="x" && B9=="")
		{
		     
		   this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		     
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="x" && B8=="o" && B9=="x")
		{
		     
		  this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		     
		}
		if (B1=="o" && B2=="x" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="x" && B8=="o" && B9=="x")
		{
			analiza();
		     
		}
		if (B1=="x" && B2=="o" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="" && B8=="x" && B9=="")
		{
		     
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";

		     
		} 

		if (B1=="" && B2=="" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="" && B8=="" && B9=="x")
		{
		     
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		     
		}
		if (B1=="o" && B2=="" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="x" && B8=="" && B9=="x")
		{
		     
		     this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		     
		     
		     
		}
		if (B1=="o" && B2=="x" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="" && B8=="" && B9=="x")
		{
		    this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
  
		     
		}
		if (B1=="o" && B2=="" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="" && B8=="x" && B9=="x")
		{
		   this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
  
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		     
		   this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		     
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="")
		{
		     
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		     
		}
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="")
		{
		     
		   this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		     
		}
		if (B1=="x" && B2=="x" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="")
		{
		     
		   this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
  
		}
		if (B1=="" && B2=="x" && B3=="o" && B4=="x" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="")
		{
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
   
		}
		if (B1=="" && B2=="x" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="x")
		{
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
   
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="x" && B9=="")
		{
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
   
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="x" && B9=="")
		{
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		     
		     
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="x" && B9=="o")
		{
		   this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
   
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="x" && B9=="o")
		{
		   this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";  
		     
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="x")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
   
		}
		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
  
		}
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
  
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="")
		{
		   this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
    
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="x" && B5=="o" && B6=="x" && B7=="" && B8=="x" && B9=="")
		{
		    this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";

		}
		if (B1=="" && B2=="" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="x" && B9=="x")
		{
		     this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
 
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="x" && B5=="o" && B6=="x" && B7=="x" && B8=="x" && B9=="o")
		{
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
 
		}
		if (B1=="" && B2=="x" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="x" && B9=="o")
		{
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";

		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="" && B6=="x" && B7=="" && B8=="" && B9=="")
		{
		     
		    this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		     
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="x")
		{
		     
		   this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		     
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="" && B9=="x")
		{
		     
		    this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		     
		}
		if (B1=="" && B2=="x" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="x")
		{
		   this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="x" && B5=="o" && B6=="x" && B7=="" && B8=="" && B9=="x")
		{
		   this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
  
		}
		if (B1=="" && B2=="" && B3=="o" && B4=="x" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="x")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
  
		}
		if (B1=="x" && B2=="" && B3=="o" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="x")
		{
		     this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";

		}
		if (B1=="" && B2=="o" && B3=="o" && B4=="o" && B5=="x" && B6=="x" && B7=="" && B8=="x" && B9=="x")
		{
		   this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
  
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="x" && B8=="" && B9=="")
		{
		     
		   this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		     
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="x" && B9=="")
		{
		     
		    this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B9="o";
		     
		}
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="x" && B9=="o")
		{
		     
		   this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     
		}
		if (B1=="x" && B2=="" && B3=="" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="x" && B9=="o")
		{
		    this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="x" && B7=="x" && B8=="x" && B9=="o")
		{
		  this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";

		}
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="x" && B9=="o")
		{this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
		}
		if (B1=="x" && B2=="x" && B3=="" && B4=="o" && B5=="o" && B6=="" && B7=="x" && B8=="x" && B9=="o")
		{
		      this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		}
		if (B1=="x" && B2=="" && B3=="x" && B4=="o" && B5=="o" && B6=="" && B7=="x" && B8=="x" && B9=="o")
		{
		     this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="x" && B8=="" && B9=="")
		{
		     
		    this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		     
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="" && B9=="x")
		{
		     
		     this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B8="o";
		     
		}
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="o" && B9=="x")
		{
		     
		    this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B4="o";
		     
		}
		if (B1=="" && B2=="x" && B3=="" && B4=="o" && B5=="o" && B6=="x" && B7=="x" && B8=="o" && B9=="x")
		{
		      this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		}
		if (B1=="" && B2=="" && B3=="" && B4=="x" && B5=="o" && B6=="" && B7=="x" && B8=="o" && B9=="x")
		{
		   this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";

		     
		}
		if (B1=="x" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="o" && B9=="x")
		{
		    this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="x" && B8=="o" && B9=="x")
		{
		   this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B2="o";
		}
		if (B1=="x" && B2=="x" && B3=="" && B4=="o" && B5=="o" && B6=="" && B7=="x" && B8=="o" && B9=="x")
		{
		    this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		}
		if (B1=="" && B2=="x" && B3=="x" && B4=="o" && B5=="o" && B6=="" && B7=="x" && B8=="o" && B9=="x")
		{
		   this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="x" && B9=="")
		{
		    this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="" && B8=="x" && B9=="x")
		{
		     
		    this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B7="o";
		     
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="" && B5=="o" && B6=="" && B7=="o" && B8=="x" && B9=="x")
		{
		     this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B6="o";
		}
		if (B1=="" && B2=="" && B3=="x" && B4=="x" && B5=="o" && B6=="o" && B7=="o" && B8=="x" && B9=="x")
		{	     
		    this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B1="o";
  
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="o" && B6=="x" && B7=="o" && B8=="x" && B9=="x")
		{
    		 this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		}
		if (B1=="" && B2=="x" && B3=="" && B4=="" && B5=="o" && B6=="" && B7=="o" && B8=="x" && B9=="x")
		{
 			 this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B3="o";
		}
		if (B1=="" && B2=="" && B3=="" && B4=="" && B5=="" && B6=="" && B7=="" && B8=="" && B9=="x")
		{
		    this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
		     o=false;x=true;B5="o";
		}
		analiza();tiempo();
		}

		public  void analiza()
		{
			int sw=1;sw=0;
			if(B1=="x"&&B2=="x"&&B3=="x")
			{this.label3.Visible = true;this.label16.Visible = true;x=false;o=false;}
			if(B4=="x"&&B5=="x"&&B6=="x")
			{this.label4.Visible = true;this.label16.Visible = true;x=false;o=false;}
			if(B7=="x"&&B8=="x"&&B9=="x")
			{this.label5.Visible = true;this.label16.Visible = true;x=false;o=false;}
			if(B1=="x"&&B4=="x"&&B7=="x")
			{this.label6.Visible = true;this.label16.Visible = true;x=false;o=false;}
			if(B2=="x"&&B5=="x"&&B8=="x")
			{this.label7.Visible = true;this.label16.Visible = true;x=false;o=false;}
			if(B3=="x"&&B6=="x"&&B9=="x")
			{this.label8.Visible = true;this.label16.Visible = true;x=false;o=false;}
			if(B1=="x"&&B5=="x"&&B9=="x")
			{this.label16.Visible = true;d2941();x=false;o=false;}
			if(B3=="x"&&B5=="x"&&B7=="x")
			{this.label16.Visible = true;d1727();x=false;o=false;}
			if(B1=="o"&&B2=="o"&&B3=="o")
			{this.label9.Visible = true;this.label15.Visible = true;x=false;o=false;}
			if(B4=="o"&&B5=="o"&&B6=="o")
			{this.label10.Visible = true;this.label15.Visible = true;x=false;o=false;}
			if(B7=="o"&&B8=="o"&&B9=="o")
			{this.label11.Visible = true;this.label15.Visible = true;x=false;o=false;}
			if(B1=="o"&&B4=="o"&&B7=="o")
			{this.label12.Visible = true;this.label15.Visible = true;x=false;o=false;}
			if(B2=="o"&&B5=="o"&&B8=="o")
			{this.label13.Visible = true;this.label15.Visible = true;x=false;o=false;}
			if(B3=="o"&&B6=="o"&&B9=="o")
			{this.label14.Visible = true;this.label15.Visible = true;x=false;o=false;}
			if(B1=="o"&&B5=="o"&&B9=="o")
			{							this.label15.Visible = true;d5466()	;x=false;o=false;}
			if(B3=="o"&&B5=="o"&&B7=="o")
			{						this.label15.Visible = true;d4253();x=false;o=false;}
			if(c>=9)
			{
				if(label15.Visible==false&&label16.Visible==false)
					this.label68.Visible = true;
			}
			
		}
		
		void Label16Click(object sender, System.EventArgs e)
		{
			base.Dispose();
			UsuarioVsPC f=new UsuarioVsPC();
			f.Show();
		}
		
		void Label15Click(object sender, System.EventArgs e)
		{
			base.Dispose();
			UsuarioVsPC f=new UsuarioVsPC();
			f.Show();
		}
		
		void Label67Click(object sender, System.EventArgs e)
		{
			base.Dispose();
		}
		public void tiempo()
		{
			for (int i=-10000;i<=10000;i++)
			{	
			}
			
		}
		
		void Label68Click(object sender, System.EventArgs e)
		{
			base.Dispose();
			UsuarioVsPC f=new UsuarioVsPC();
			f.Show();
		}
	}

}
