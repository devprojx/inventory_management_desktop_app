/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 20/07/2015
 * Time: 12:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class About
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.productNameLbl = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.productVersionlbl = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(113, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "©2015 Yanik Blake";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Location = new System.Drawing.Point(0, 320);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(314, 21);
			this.panel1.TabIndex = 4;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, -2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(323, 232);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label5.Location = new System.Drawing.Point(63, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(202, 25);
			this.label5.TabIndex = 13;
			this.label5.Text = "Email:  YanikBlake@gmail.com";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label4.Location = new System.Drawing.Point(92, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "Author:  Yanik Blake";
			// 
			// productNameLbl
			// 
			this.productNameLbl.BackColor = System.Drawing.Color.Transparent;
			this.productNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productNameLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.productNameLbl.Location = new System.Drawing.Point(145, 8);
			this.productNameLbl.Name = "productNameLbl";
			this.productNameLbl.Size = new System.Drawing.Size(166, 23);
			this.productNameLbl.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label2.Location = new System.Drawing.Point(42, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "Product Name:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.Location = new System.Drawing.Point(31, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "Product Version:";
			// 
			// productVersionlbl
			// 
			this.productVersionlbl.BackColor = System.Drawing.Color.Transparent;
			this.productVersionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productVersionlbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.productVersionlbl.Location = new System.Drawing.Point(148, 31);
			this.productVersionlbl.Name = "productVersionlbl";
			this.productVersionlbl.Size = new System.Drawing.Size(166, 23);
			this.productVersionlbl.TabIndex = 8;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.productVersionlbl);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.productNameLbl);
			this.panel2.Controls.Add(this.label2);
			this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Location = new System.Drawing.Point(0, 222);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(322, 95);
			this.panel2.TabIndex = 14;
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(314, 341);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "About";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AboutFormClosed);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label productVersionlbl;
		private System.Windows.Forms.Label productNameLbl;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
