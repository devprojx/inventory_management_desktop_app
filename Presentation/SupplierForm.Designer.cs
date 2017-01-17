/*
 * Created by SharpDevelop.
 * User: vstudent
 * Date: 9/9/2015
 * Time: 11:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class SupplierForm
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
            this.errorLb1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailMskBx = new System.Windows.Forms.MaskedTextBox();
            this.FaxMskBox = new System.Windows.Forms.MaskedTextBox();
            this.Phone2Mskbox = new System.Windows.Forms.MaskedTextBox();
            this.Phone1Mskbx = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ParishCmBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LocationTxtBox = new System.Windows.Forms.TextBox();
            this.SupplierTxtbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorLb1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmailMskBx);
            this.panel1.Controls.Add(this.FaxMskBox);
            this.panel1.Controls.Add(this.Phone2Mskbox);
            this.panel1.Controls.Add(this.Phone1Mskbx);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ParishCmBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LocationTxtBox);
            this.panel1.Controls.Add(this.SupplierTxtbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 424);
            this.panel1.TabIndex = 0;
            // 
            // errorLb1
            // 
            this.errorLb1.BackColor = System.Drawing.Color.Transparent;
            this.errorLb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLb1.ForeColor = System.Drawing.Color.Red;
            this.errorLb1.Location = new System.Drawing.Point(149, 318);
            this.errorLb1.Name = "errorLb1";
            this.errorLb1.Size = new System.Drawing.Size(205, 14);
            this.errorLb1.TabIndex = 44;
            this.errorLb1.Text = "*Input fields cannot be empty";
            this.errorLb1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(428, 22);
            this.statusStrip1.TabIndex = 43;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(194, 345);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(101, 36);
            this.SaveBtn.TabIndex = 42;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtnClick);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(83, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 41;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(41, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Fax Number";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(11, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Phone Number 2";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(11, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Phone Number 1";
            // 
            // EmailMskBx
            // 
            this.EmailMskBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.EmailMskBx.Location = new System.Drawing.Point(139, 291);
            this.EmailMskBx.Name = "EmailMskBx";
            this.EmailMskBx.Size = new System.Drawing.Size(262, 24);
            this.EmailMskBx.TabIndex = 7;
            // 
            // FaxMskBox
            // 
            this.FaxMskBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FaxMskBox.Location = new System.Drawing.Point(152, 254);
            this.FaxMskBox.Mask = "(876) 000-0000";
            this.FaxMskBox.Name = "FaxMskBox";
            this.FaxMskBox.Size = new System.Drawing.Size(127, 24);
            this.FaxMskBox.TabIndex = 6;
            // 
            // Phone2Mskbox
            // 
            this.Phone2Mskbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Phone2Mskbox.Location = new System.Drawing.Point(152, 215);
            this.Phone2Mskbox.Mask = "(876) 000-0000";
            this.Phone2Mskbox.Name = "Phone2Mskbox";
            this.Phone2Mskbox.Size = new System.Drawing.Size(127, 24);
            this.Phone2Mskbox.TabIndex = 5;
            // 
            // Phone1Mskbx
            // 
            this.Phone1Mskbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Phone1Mskbx.Location = new System.Drawing.Point(152, 181);
            this.Phone1Mskbx.Mask = "(876) 000-0000";
            this.Phone1Mskbx.Name = "Phone1Mskbx";
            this.Phone1Mskbx.Size = new System.Drawing.Size(127, 24);
            this.Phone1Mskbx.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(135, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Parish";
            // 
            // ParishCmBox
            // 
            this.ParishCmBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ParishCmBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ParishCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParishCmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ParishCmBox.FormattingEnabled = true;
            this.ParishCmBox.Location = new System.Drawing.Point(194, 142);
            this.ParishCmBox.Name = "ParishCmBox";
            this.ParishCmBox.Size = new System.Drawing.Size(121, 26);
            this.ParishCmBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(63, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Location";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Supplier Name";
            // 
            // LocationTxtBox
            // 
            this.LocationTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LocationTxtBox.Location = new System.Drawing.Point(139, 89);
            this.LocationTxtBox.Multiline = true;
            this.LocationTxtBox.Name = "LocationTxtBox";
            this.LocationTxtBox.Size = new System.Drawing.Size(262, 44);
            this.LocationTxtBox.TabIndex = 1;
            // 
            // SupplierTxtbox
            // 
            this.SupplierTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.SupplierTxtbox.Location = new System.Drawing.Point(139, 45);
            this.SupplierTxtbox.Name = "SupplierTxtbox";
            this.SupplierTxtbox.Size = new System.Drawing.Size(262, 24);
            this.SupplierTxtbox.TabIndex = 0;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 424);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Supplier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SupplierFormFormClosed);
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label errorLb1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.MaskedTextBox Phone1Mskbx;
		private System.Windows.Forms.MaskedTextBox Phone2Mskbox;
		private System.Windows.Forms.MaskedTextBox FaxMskBox;
		private System.Windows.Forms.MaskedTextBox EmailMskBx;
		private System.Windows.Forms.TextBox SupplierTxtbox;
		private System.Windows.Forms.TextBox LocationTxtBox;
		private System.Windows.Forms.ComboBox ParishCmBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
	}
}
