/*
 * Created by SharpDevelop.
 * User: WZIETEK
 * Date: 03/06/2026
 * Time: 14:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace apogee2
{
	/// <summary>
	/// Description of frm_formulas.
	/// </summary>
	public partial class Frm_formulas : Form
	{
		public Frm_formulas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Btn_calcClick(object sender, EventArgs e)
		{
			
		string res="";

		if(num_first.Value==2)
		{  res += "n1>=10"; 
		 }
			
		if(chk_nombre.Checked)
			
			//if(rb_ue.Checked)  pareil pour les 2
			
		   {
			
		    res += " et ";
		    
		    for(int i=(int)num_first.Value; i<=num_last.Value; i++)
                
		    { res += "c"+i.ToString().Trim();
				if(i<num_last.Value) res+="+";
			}
              res+="="+num_tot.Text;
		   }
			

		if(chk_seuil.Checked)
			
			
		   {
			
		    res += " et ";
		    
		    for(int i=(int)num_first.Value; i<=num_last.Value; i++)
                
		    { 
		    	string si=i.ToString().Trim();
		    	res += "n"+si+"*c"+si+">=7*c"+si;
				if(i<num_last.Value) res+=" et ";
			}
              
		   }
						
				
		 	
			
			
			
		//res += num_first.ToString() + " "; 
		
		txt_res.Text=res;
		}
	}
}
