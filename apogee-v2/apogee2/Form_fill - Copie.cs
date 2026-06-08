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
			
			
			
		}
		
		struct Ueinfo
		{ public string code;
		  public string ects;
          public string other; 		  
		}
		
		List<Ueinfo> lst_ue;	
		
		
		bool box2list()
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
        	
      Ueinfo ue = new Ueinfo();
      ue.code=linearr[0];
        	if (linearr.Length>1)
        	{ue.ects = linearr[1];
        	ok= Apoutil.checknum(ue.ects, linearr[0]+" "+linearr[1]);
        	ok=ok &&  Apoutil.checkue(ue.code); 
        	}
        	if (linearr.Length>2)
        	{ue.other = linearr[2];}
        	
        	lst_ue.Add(ue);
		
		  }
        
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
		
		void Button1Click(object sender, EventArgs e)
		{
			box2list();		
			list2box();
		}
		
		void Btn_regnClick(object sender, EventArgs e)
		{
			
			if(!box2list()) return;
			
			list2box();
			
			if (!Apoutil.findapowin(txt_login.Text)) return;
			
			
			 for(int il=0; il<lst_ue.Count; il++)
			 {
			 	int lnum=(int)num_firstres.Value+il;
			 
			 fill_line_resN(lnum, lst_ue[il]);
			 }
			
		}
		
		void Btn_clearClick(object sender, EventArgs e)
		{
			 txt_fill.Clear();
		}
		
		
		//calcul res avec note, seuil 10, params 3
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
	 
	 
	 //remplissage regle res avec N
	 	SendKeys.SendWait("{TAB}{TAB}N");	
	    SendKeys.SendWait(ue.ects);	
     	SendKeys.SendWait("{TAB}3{TAB}{TAB}{TAB}");		 
			
		}
		
		
		
		
		void Btn_regrClick(object sender, EventArgs e)
		{
			
		}
	}}
