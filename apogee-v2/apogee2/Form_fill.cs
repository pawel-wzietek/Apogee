/*
 * Created by SharpDevelop.
 * User: WZIETEK
 * Date: 04/06/2026
 * Time: 11:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace apogee2
{
	/// <summary>
	/// Description of Form_fill.
	/// </summary>
	public partial class Form_fill : Form
	{
		public Form_fill()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			lst_NR.Items.Add("N");
			lst_NR.Items.Add("R");
			lst_NR.SelectedIndex=0;
			
			stop=false;
			
			
		}
		
		struct Ueinfo
		{ public string code;
		  public string ects;
          public string other; 		  
		}
		
		List<Ueinfo> lst_ue;	
		bool stop;
		
		
		void enable()
		{
		txt_fill.Enabled=true;
		txt_login.Enabled=true;
		txt_parnote.Enabled=true;
		txt_parres.Enabled=true;
		lst_NR.Enabled=true;
		num_firstres.Enabled=true;	
		
		 btn_liste.Enabled=true;
 		btn_regr.Enabled=true;
 		btn_regn.Enabled=true;
		
		Application.DoEvents();
		}
        
	void disable()
		{
		txt_fill.Enabled=false;
		txt_login.Enabled=false;
		txt_parnote.Enabled=false;
		txt_parres.Enabled=false;
		lst_NR.Enabled=false;
		num_firstres.Enabled=false;

 		btn_liste.Enabled=false;
 		btn_regr.Enabled=false;
 		btn_regn.Enabled=false;
		
		Application.DoEvents();
		}		
		
		bool box2list(bool checkects)
		{
		
        lst_ue=new List<Ueinfo>();
		bool ok=true;
			
		string[] linearr=new string[0]; 
		char[] sep = new char[] {' '};

        int nl=txt_fill.Lines.Length;

        for(int il=0; il<nl; il++)
          {
           
        	string line=txt_fill.Lines[il].Trim();
        	line=line.Replace('\t', ' ').Trim();
        	
        	if(line=="") continue;
        	
      linearr=line.Split(sep, 3, StringSplitOptions.RemoveEmptyEntries);
       
      if (linearr.Length<2)
      {
       	MessageBox.Show(linearr[0]+" :\r\n nombre d'ects manquant");
       	return false;
      }
      
      Ueinfo ue = new Ueinfo();
      ue.code=linearr[0];
        	
       ue.ects = linearr[1];
       ok= Apoutil.checkue(ue.code); 
       if (checkects) 
       	   ok=ok &&  Apoutil.checkects(ue.ects, linearr[0]+" "+linearr[1]);
      
        	
        if (linearr.Length>2)
        	{ue.other = linearr[2];}
        	
        if (ok) lst_ue.Add(ue);
		
		 }//for
        
		return ok;
		}
		
		
			
		
		
		bool list2box() 
		{
		
	
        
        //fill back
        txt_fill.Clear(); Application.DoEvents();
        
        for(int il=0; il<lst_ue.Count; il++)
        	{
        	txt_fill.AppendText(lst_ue[il].code+" "+
        	                    lst_ue[il].ects+"\r\n");
        	}
        
       
        
		
		return true;
	}
		

		void ButtonverifClick(object sender, EventArgs e)
		{
			box2list(true);		
			
		}
	
		void Btn_regrClick(object sender, EventArgs e)
		{
			stop=false;
			if(!box2list(true)) return;
			
			list2box();
			
			if (!Apoutil.findapowin(txt_login.Text)) return;
			
			disable();
			 for(int il=0; il<lst_ue.Count; il++)
			 {
			 	int lnum=(int)num_firstres.Value+il;
			 	Application.DoEvents();if(stop) {break;}
			 fill_line_resN(lnum, lst_ue[il]);
			 }
			 
			 enable(); 
			
		}
		
		void Btn_clearClick(object sender, EventArgs e)
		{
			 txt_fill.Clear();
		}
		
		
		//calcul res avec note ( seuil 10, params 3) ou res, (params 2)
		void fill_line_resN(int num, Ueinfo ue)
		{
			if (num<1 || num>99)
			{
			//to check by caller	
			return;
			}
			string snum=num.ToString().Trim();
	 
		
			SendKeys.SendWait(snum);  //sans tab si 2 chiffres
	        if (snum.Length==1) SendKeys.SendWait("{TAB}"); 
	        	
			
	 		SendKeys.SendWait("ELP");
	 
	 		SendKeys.SendWait(ue.code+"{TAB}");
	 
	 		string par=txt_parres.Text.Trim();
	 		if(lst_NR.SelectedIndex==0)   //N
	 		{
	 //remplissage regle res avec N
	   	 
	 	SendKeys.SendWait("{TAB}{TAB}N");	
	    SendKeys.SendWait(ue.ects);	if(stop) return;
     	SendKeys.SendWait("{TAB}{TAB}"+par); if(stop) return;
	     SendKeys.SendWait("{TAB}{DOWN}");

	 		}
	 	else
	 	{
	 	 //remplissage regle res avec R
	 	SendKeys.SendWait("{TAB}{TAB}R");	
	    SendKeys.SendWait("1");		if(stop) return;
     	//SendKeys.SendWait("{TAB}2{TAB}{TAB}");	//pas de seuil
     	SendKeys.SendWait("{TAB}"+par);
     	SendKeys.SendWait("{TAB}{DOWN}");
	 	}
			
		}
		
		//calcul  note 
		void fill_line_note(int num, Ueinfo ue)
		{
			if (num<1 || num>99)
			{
			//to check by caller	
			return;
			}
			string snum=num.ToString().Trim();
	 
		
			SendKeys.SendWait(snum);  //sans tab si 2 chiffres
	        if (snum.Length==1) SendKeys.SendWait("{TAB}"); 
	        	
			
	        	 //remplissage regle note
	 		SendKeys.SendWait("ELP");
	 
	 		SendKeys.SendWait(ue.code+"{TAB}");if(stop) return;
	 
	 		

	 		SendKeys.SendWait("{TAB}{TAB}");	
	    	SendKeys.SendWait(ue.ects);	   if(stop) return;
     		
	    	//SendKeys.SendWait("{TAB}8{TAB}{TAB}");
	    	
	    	string par=txt_parnote.Text.Trim();
	    	SendKeys.SendWait("{TAB}"+par);
	    	SendKeys.SendWait("{TAB}{DOWN}");
	 		
	 
			
		}	
		
		
				//liste
		void fill_line_liste(Ueinfo ue)
		{
			
	       SendKeys.SendWait(ue.code); 
					
	        if (ue.code.Length<8) SendKeys.SendWait("{TAB}"); 
	        		
	    	SendKeys.SendWait("{DOWN}");
	 		
	 
			
		}	
		
		
		
		
		void Btn_regnClick(object sender, EventArgs e)
		{
			stop=false;
			
			if(!box2list(true)) return;
			
			list2box();
			
			if (!Apoutil.findapowin(txt_login.Text)) return;
			
			disable();
			 for(int il=0; il<lst_ue.Count; il++)
			 {
			 	int lnum=(int)num_firstres.Value+il;
			
             Application.DoEvents();if(stop) {break;}			 	
			 fill_line_note(lnum, lst_ue[il]);
			 }
			 enable(); 
		}
		
		void Btn_listeClick(object sender, EventArgs e)
		{
			stop=false;
		
			if(!box2list(false)) return;
			
			list2box();
			
			if (!Apoutil.findapowin(txt_login.Text)) return;
			
			disable();
			 for(int il=0; il<lst_ue.Count; il++)
			 	{
			    Application.DoEvents();if(stop) {break;}
			 	fill_line_liste(lst_ue[il]);			
			
				}
			 enable(); 
			 
		}
		
		void Btn_cleanClick(object sender, EventArgs e)
		{
			box2list(true);		
			list2box();
		}
		
		
	}}
