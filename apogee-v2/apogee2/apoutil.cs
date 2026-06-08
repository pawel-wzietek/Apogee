/*
 * Created by SharpDevelop.
 * User: WZIETEK
 * Date: 03/06/2026
 * Time: 14:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;
using System.Diagnostics;
using System.Threading;


namespace apogee2
{
	/// <summary>
	/// Description of apoutil.
	/// </summary>
	public class Apoutil
	{
		public Apoutil()
		{
		}
		
	[DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

//[DllImport("user32.dll")]
//    static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

[DllImport("USER32.DLL")]
public static extern bool SetForegroundWindow(IntPtr hWnd);


//switching to apo window 
public static bool findapowin(string login)
{
 Process [] processes = Process.GetProcesses();

int iapo=-1;

for (int i=0; i<processes.Length; i++)
{		
  string title=processes[i].MainWindowTitle;
  if(title.StartsWith("Apog") && title.ToUpper().Contains(login.Trim().ToUpper()))
	{		
		
		iapo=i;
		break;
	}
}


if(iapo>=0)	
{
   IntPtr pWindow=processes[iapo].MainWindowHandle;
   	
   	SetForegroundWindow(pWindow);  //marche
   return true;
}
else	
{
	MessageBox.Show("erreur : Apogée n'est pas actif ou login incorrect");
	return false;
}
	
}


public static bool checkects(string item, string text)
{

	if(item=="")
	{
	 	MessageBox.Show("erreur dans \r\n"+text+"\r\n nombre d'ects manquant");
	
	}
	
float x=0;	
bool ok = float.TryParse(item, out x);

if(x<=0) ok=false;
	
if(!ok)
	MessageBox.Show("erreur dans \r\n"+text+"\r\n nombre d'ects non valide");

return ok;
}
	

public static bool checkue(string item)
{

bool ok = item.Length<=8;
	
if(!ok)
	MessageBox.Show("nom d'UE non valide: \r\n"+item);

return ok;
}
	




public static void wait(double wsecs)
{

	
	DateTime ti=DateTime.Now;
	double secsnow;
	
	do 
	{
	Thread.Sleep(10);
	Application.DoEvents();
	
	secsnow=DateTime.Now.Subtract(ti).TotalSeconds;
	
	}
	while(secsnow<wsecs);
	
	
}





	}
}
