/*
 * Created by SharpDevelop.
 * User: Vstudent
 * Date: 7/17/2015
 * Time: 9:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class Delete
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.itemNameCmb = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.DeleteBtn);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.itemNameCmb);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(249, 132);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Inventory_System.Resource1.yellow_document_cross_icon;
			this.pictureBox1.Location = new System.Drawing.Point(111, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(60, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.Location = new System.Drawing.Point(96, 98);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
			this.DeleteBtn.TabIndex = 2;
			this.DeleteBtn.Text = "Delete";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtnClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "Item Name";
			// 
			// itemNameCmb
			// 
			this.itemNameCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.itemNameCmb.FormattingEnabled = true;
			this.itemNameCmb.Location = new System.Drawing.Point(96, 64);
			this.itemNameCmb.Name = "itemNameCmb";
			this.itemNameCmb.Size = new System.Drawing.Size(121, 21);
			this.itemNameCmb.TabIndex = 0;
			this.itemNameCmb.SelectedIndexChanged += new System.EventHandler(this.ItemNameCmbSelectedIndexChanged);
			// 
			// Delete
			// 
			this.AcceptButton = this.DeleteBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(249, 132);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(265, 171);
			this.Name = "Delete";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delete";
			this.Load += new System.EventHandler(this.DeleteLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteFormClosed);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox itemNameCmb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.Panel panel1;
	}
}
