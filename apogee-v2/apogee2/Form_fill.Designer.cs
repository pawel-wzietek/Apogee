/*
 * Created by SharpDevelop.
 * User: WZIETEK
 * Date: 04/06/2026
 * Time: 11:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace apogee2
{
	partial class Form_fill
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
			this.btn_verif = new System.Windows.Forms.Button();
			this.txt_fill = new System.Windows.Forms.TextBox();
			this.btn_regn = new System.Windows.Forms.Button();
			this.num_firstres = new System.Windows.Forms.NumericUpDown();
			this.btn_regr = new System.Windows.Forms.Button();
			this.txt_login = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_clear = new System.Windows.Forms.Button();
			this.lst_NR = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_liste = new System.Windows.Forms.Button();
			this.btn_clean = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_parnote = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_parres = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.num_firstres)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_verif
			// 
			this.btn_verif.Location = new System.Drawing.Point(345, 104);
			this.btn_verif.Name = "btn_verif";
			this.btn_verif.Size = new System.Drawing.Size(87, 59);
			this.btn_verif.TabIndex = 0;
			this.btn_verif.Text = "vérifier";
			this.btn_verif.UseVisualStyleBackColor = true;
			this.btn_verif.Click += new System.EventHandler(this.ButtonverifClick);
			// 
			// txt_fill
			// 
			this.txt_fill.Location = new System.Drawing.Point(27, 35);
			this.txt_fill.Multiline = true;
			this.txt_fill.Name = "txt_fill";
			this.txt_fill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_fill.Size = new System.Drawing.Size(313, 303);
			this.txt_fill.TabIndex = 1;
			// 
			// btn_regn
			// 
			this.btn_regn.Location = new System.Drawing.Point(27, 407);
			this.btn_regn.Name = "btn_regn";
			this.btn_regn.Size = new System.Drawing.Size(161, 23);
			this.btn_regn.TabIndex = 2;
			this.btn_regn.Text = "remplir règle note (liste ELP)";
			this.btn_regn.UseVisualStyleBackColor = true;
			this.btn_regn.Click += new System.EventHandler(this.Btn_regnClick);
			// 
			// num_firstres
			// 
			this.num_firstres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num_firstres.Location = new System.Drawing.Point(195, 359);
			this.num_firstres.Name = "num_firstres";
			this.num_firstres.Size = new System.Drawing.Size(60, 22);
			this.num_firstres.TabIndex = 3;
			this.num_firstres.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// btn_regr
			// 
			this.btn_regr.Location = new System.Drawing.Point(29, 450);
			this.btn_regr.Name = "btn_regr";
			this.btn_regr.Size = new System.Drawing.Size(161, 24);
			this.btn_regr.TabIndex = 4;
			this.btn_regr.Text = "remplir règle rés. (liste ELP)";
			this.btn_regr.UseVisualStyleBackColor = true;
			this.btn_regr.Click += new System.EventHandler(this.Btn_regrClick);
			// 
			// txt_login
			// 
			this.txt_login.Location = new System.Drawing.Point(153, 9);
			this.txt_login.Name = "txt_login";
			this.txt_login.Size = new System.Drawing.Size(148, 20);
			this.txt_login.TabIndex = 5;
			this.txt_login.Text = "WZIETEK";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(102, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 22);
			this.label1.TabIndex = 6;
			this.label1.Text = "login :";
			// 
			// btn_clear
			// 
			this.btn_clear.Location = new System.Drawing.Point(345, 35);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(87, 27);
			this.btn_clear.TabIndex = 7;
			this.btn_clear.Text = "effacer";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.Btn_clearClick);
			// 
			// lst_NR
			// 
			this.lst_NR.FormattingEnabled = true;
			this.lst_NR.Location = new System.Drawing.Point(207, 450);
			this.lst_NR.Name = "lst_NR";
			this.lst_NR.Size = new System.Drawing.Size(46, 30);
			this.lst_NR.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(39, 361);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 18);
			this.label2.TabIndex = 9;
			this.label2.Text = "numérotation commence à ";
			// 
			// btn_liste
			// 
			this.btn_liste.Location = new System.Drawing.Point(29, 499);
			this.btn_liste.Name = "btn_liste";
			this.btn_liste.Size = new System.Drawing.Size(159, 23);
			this.btn_liste.TabIndex = 10;
			this.btn_liste.Text = "remplir liste UE";
			this.btn_liste.UseVisualStyleBackColor = true;
			this.btn_liste.Click += new System.EventHandler(this.Btn_listeClick);
			// 
			// btn_clean
			// 
			this.btn_clean.Location = new System.Drawing.Point(345, 218);
			this.btn_clean.Name = "btn_clean";
			this.btn_clean.Size = new System.Drawing.Size(87, 56);
			this.btn_clean.TabIndex = 11;
			this.btn_clean.Text = "nettoyer et préparer liste";
			this.btn_clean.UseVisualStyleBackColor = true;
			this.btn_clean.Click += new System.EventHandler(this.Btn_cleanClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(261, 410);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 19);
			this.label3.TabIndex = 12;
			this.label3.Text = "param.";
			// 
			// txt_parnote
			// 
			this.txt_parnote.Location = new System.Drawing.Point(323, 410);
			this.txt_parnote.Name = "txt_parnote";
			this.txt_parnote.Size = new System.Drawing.Size(51, 20);
			this.txt_parnote.TabIndex = 13;
			this.txt_parnote.Text = "8";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(261, 450);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 28);
			this.label4.TabIndex = 14;
			this.label4.Text = "param.";
			// 
			// txt_parres
			// 
			this.txt_parres.Location = new System.Drawing.Point(321, 456);
			this.txt_parres.Name = "txt_parres";
			this.txt_parres.Size = new System.Drawing.Size(51, 20);
			this.txt_parres.TabIndex = 15;
			this.txt_parres.Text = "3";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(102, 543);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(208, 12);
			this.label5.TabIndex = 16;
			this.label5.Text = "Cliquer sur la fenêtre pour interrompre";
			// 
			// Form_fill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 564);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_parres);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_parnote);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_clean);
			this.Controls.Add(this.btn_liste);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lst_NR);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_login);
			this.Controls.Add(this.btn_regr);
			this.Controls.Add(this.num_firstres);
			this.Controls.Add(this.btn_regn);
			this.Controls.Add(this.txt_fill);
			this.Controls.Add(this.btn_verif);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form_fill";
			this.Text = "apogée: remplissage";
			this.Activated += new System.EventHandler(this.Form_fillActivated);
			this.Enter += new System.EventHandler(this.Form_fillEnter);
			((System.ComponentModel.ISupportInitialize)(this.num_firstres)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_parres;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_parnote;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_clean;
		private System.Windows.Forms.Button btn_liste;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lst_NR;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_login;
		private System.Windows.Forms.Button btn_regr;
		private System.Windows.Forms.NumericUpDown num_firstres;
		private System.Windows.Forms.Button btn_regn;
		private System.Windows.Forms.TextBox txt_fill;
		private System.Windows.Forms.Button btn_verif;
		
		void Form_fillEnter(object sender, System.EventArgs e)
		{
			
		}
		
		void Form_fillActivated(object sender, System.EventArgs e)
		{
			stop=true;
		}
	}
}
