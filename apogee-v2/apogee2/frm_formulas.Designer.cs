/*
 * Created by SharpDevelop.
 * User: WZIETEK
 * Date: 03/06/2026
 * Time: 14:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace apogee2
{
	partial class Frm_formulas
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
			this.txt_res = new System.Windows.Forms.TextBox();
			this.num_first = new System.Windows.Forms.NumericUpDown();
			this.num_last = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.chk_nombre = new System.Windows.Forms.CheckBox();
			this.num_tot = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.chk_seuil = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_calc = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.num_first)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_last)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_tot)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_res
			// 
			this.txt_res.Location = new System.Drawing.Point(14, 345);
			this.txt_res.Multiline = true;
			this.txt_res.Name = "txt_res";
			this.txt_res.Size = new System.Drawing.Size(479, 104);
			this.txt_res.TabIndex = 0;
			// 
			// num_first
			// 
			this.num_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num_first.Location = new System.Drawing.Point(142, 51);
			this.num_first.Name = "num_first";
			this.num_first.Size = new System.Drawing.Size(66, 26);
			this.num_first.TabIndex = 1;
			this.num_first.Value = new decimal(new int[] {
									2,
									0,
									0,
									0});
			// 
			// num_last
			// 
			this.num_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num_last.Location = new System.Drawing.Point(299, 51);
			this.num_last.Name = "num_last";
			this.num_last.Size = new System.Drawing.Size(74, 26);
			this.num_last.TabIndex = 2;
			this.num_last.Value = new decimal(new int[] {
									2,
									0,
									0,
									0});
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.lbl_nombre);
			this.panel1.Controls.Add(this.chk_nombre);
			this.panel1.Controls.Add(this.num_tot);
			this.panel1.Location = new System.Drawing.Point(14, 97);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(479, 130);
			this.panel1.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(40, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(406, 22);
			this.label6.TabIndex = 10;
			this.label6.Text = "-  comptage d\'ECTS si chaque coefficients égal au nombre d\'ECTS";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(40, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(349, 24);
			this.label5.TabIndex = 9;
			this.label5.Text = "-  comptage d\'UE si tous les coefficients à 1";
			// 
			// lbl_nombre
			// 
			this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_nombre.Location = new System.Drawing.Point(40, 88);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(214, 28);
			this.lbl_nombre.TabIndex = 8;
			this.lbl_nombre.Text = "total UE/ECTS obligatoires :";
			// 
			// chk_nombre
			// 
			this.chk_nombre.Checked = true;
			this.chk_nombre.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_nombre.Location = new System.Drawing.Point(13, 3);
			this.chk_nombre.Name = "chk_nombre";
			this.chk_nombre.Size = new System.Drawing.Size(273, 27);
			this.chk_nombre.TabIndex = 6;
			this.chk_nombre.Text = "vérification nombre d\'UE/ECTS";
			this.chk_nombre.UseVisualStyleBackColor = true;
			// 
			// num_tot
			// 
			this.num_tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num_tot.Location = new System.Drawing.Point(271, 86);
			this.num_tot.Name = "num_tot";
			this.num_tot.Size = new System.Drawing.Size(87, 26);
			this.num_tot.TabIndex = 4;
			this.num_tot.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(45, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "ELP de ";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(235, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 26);
			this.label2.TabIndex = 6;
			this.label2.Text = "à";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.numericUpDown2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.chk_seuil);
			this.panel2.Location = new System.Drawing.Point(14, 233);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(476, 60);
			this.panel2.TabIndex = 7;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown2.Location = new System.Drawing.Point(156, 25);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(82, 26);
			this.numericUpDown2.TabIndex = 2;
			this.numericUpDown2.Value = new decimal(new int[] {
									7,
									0,
									0,
									0});
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(93, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 19);
			this.label3.TabIndex = 1;
			this.label3.Text = "seuil :";
			// 
			// chk_seuil
			// 
			this.chk_seuil.Checked = true;
			this.chk_seuil.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_seuil.Location = new System.Drawing.Point(12, 3);
			this.chk_seuil.Name = "chk_seuil";
			this.chk_seuil.Size = new System.Drawing.Size(150, 24);
			this.chk_seuil.TabIndex = 0;
			this.chk_seuil.Text = "vérification  seuils";
			this.chk_seuil.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(45, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(340, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Apogée - page \"règle de calcul de résultat\"";
			// 
			// btn_calc
			// 
			this.btn_calc.Location = new System.Drawing.Point(29, 306);
			this.btn_calc.Name = "btn_calc";
			this.btn_calc.Size = new System.Drawing.Size(142, 27);
			this.btn_calc.TabIndex = 9;
			this.btn_calc.Text = "calculer formule";
			this.btn_calc.UseVisualStyleBackColor = true;
			this.btn_calc.Click += new System.EventHandler(this.Btn_calcClick);
			// 
			// Frm_formulas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 472);
			this.Controls.Add(this.btn_calc);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.num_last);
			this.Controls.Add(this.num_first);
			this.Controls.Add(this.txt_res);
			this.Name = "Frm_formulas";
			this.Text = "apogée: formules";
			((System.ComponentModel.ISupportInitialize)(this.num_first)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_last)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.num_tot)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btn_calc;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chk_seuil;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chk_nombre;
		private System.Windows.Forms.Label lbl_nombre;
		private System.Windows.Forms.NumericUpDown num_tot;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.NumericUpDown num_last;
		private System.Windows.Forms.NumericUpDown num_first;
		private System.Windows.Forms.TextBox txt_res;
			
			//
			
		}
	}

