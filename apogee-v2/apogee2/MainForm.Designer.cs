/*
 * Created by SharpDevelop.
 * User: WZIETEK
 * Date: 03/06/2026
 * Time: 14:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace apogee2
{
	partial class MainForm
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
			this.btn_formules = new System.Windows.Forms.Button();
			this.btn_fill = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_formules
			// 
			this.btn_formules.Location = new System.Drawing.Point(34, 48);
			this.btn_formules.Name = "btn_formules";
			this.btn_formules.Size = new System.Drawing.Size(150, 38);
			this.btn_formules.TabIndex = 0;
			this.btn_formules.Text = "formules";
			this.btn_formules.UseVisualStyleBackColor = true;
			this.btn_formules.Click += new System.EventHandler(this.Btn_formulesClick);
			// 
			// btn_fill
			// 
			this.btn_fill.Location = new System.Drawing.Point(38, 118);
			this.btn_fill.Name = "btn_fill";
			this.btn_fill.Size = new System.Drawing.Size(145, 42);
			this.btn_fill.TabIndex = 1;
			this.btn_fill.Text = "remplissage";
			this.btn_fill.UseVisualStyleBackColor = true;
			this.btn_fill.Click += new System.EventHandler(this.Btn_fillClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 261);
			this.Controls.Add(this.btn_fill);
			this.Controls.Add(this.btn_formules);
			this.Name = "MainForm";
			this.Text = "apogee v.2";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_fill;
		private System.Windows.Forms.Button btn_formules;
		
		void Btn_formulesClick(object sender, System.EventArgs e)
		{
			
		 if (frm_form == null || frm_form.IsDisposed)
		  	frm_form = new Frm_formulas();

		 
		  	frm_form.Show();

		}

		
		void Btn_fillClick(object sender, System.EventArgs e)
		{
			
			 if (frm_fill == null || frm_fill.IsDisposed)
		  	frm_fill = new Form_fill();

		 
		  	frm_fill.Show();
		}
	}
}
