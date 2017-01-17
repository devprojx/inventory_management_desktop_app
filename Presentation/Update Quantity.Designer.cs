/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 17/07/2015
 * Time: 01:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class Update_Quantity
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorLbl = new System.Windows.Forms.Label();
            this.errorlbl1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.itemNameCmb = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 166);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "In Stock:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorLbl);
            this.panel1.Controls.Add(this.errorlbl1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.quantityTxt);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.itemNameCmb);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 166);
            this.panel1.TabIndex = 3;
            // 
            // errorLbl
            // 
            this.errorLbl.BackColor = System.Drawing.SystemColors.Control;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Tomato;
            this.errorLbl.Location = new System.Drawing.Point(155, 110);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(119, 16);
            this.errorLbl.TabIndex = 12;
            this.errorLbl.Text = "*Invalid Quantity";
            this.errorLbl.Visible = false;
            // 
            // errorlbl1
            // 
            this.errorlbl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.errorlbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorlbl1.ForeColor = System.Drawing.Color.Tomato;
            this.errorlbl1.Location = new System.Drawing.Point(76, 4);
            this.errorlbl1.Name = "errorlbl1";
            this.errorlbl1.Size = new System.Drawing.Size(193, 16);
            this.errorlbl1.TabIndex = 13;
            this.errorlbl1.Text = "*Input fields cannot be empty";
            this.errorlbl1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory_System.Resource1.Button_Refresh_icon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(99, 87);
            this.label2.MaximumSize = new System.Drawing.Size(66, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(91, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item Name";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(153, 87);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(121, 20);
            this.quantityTxt.TabIndex = 1;
            this.quantityTxt.Leave += new System.EventHandler(this.QuantityTxtLeave);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(184, 129);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtnClick);
            // 
            // itemNameCmb
            // 
            this.itemNameCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemNameCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemNameCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemNameCmb.FormattingEnabled = true;
            this.itemNameCmb.Location = new System.Drawing.Point(153, 48);
            this.itemNameCmb.Name = "itemNameCmb";
            this.itemNameCmb.Size = new System.Drawing.Size(121, 21);
            this.itemNameCmb.TabIndex = 0;
            this.itemNameCmb.SelectedIndexChanged += new System.EventHandler(this.ItemNameCmbSelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 4;
            // 
            // Update_Quantity
            // 
            this.AcceptButton = this.updateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 188);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Update_Quantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Quantity";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Update_QuantityFormClosed);
            this.Load += new System.EventHandler(this.Update_QuantityLoad);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label errorlbl1;
		private System.Windows.Forms.Label errorLbl;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox quantityTxt;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox itemNameCmb;
		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
	}
}
