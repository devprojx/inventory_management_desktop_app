/*
 * Created by SharpDevelop.
 * User: Olewis
 * Date: 9/7/2015
 * Time: 6:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class ReceivableForm
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
            this.addNewSupplierLink = new System.Windows.Forms.LinkLabel();
            this.err4 = new System.Windows.Forms.Label();
            this.err3 = new System.Windows.Forms.Label();
            this.err2 = new System.Windows.Forms.Label();
            this.errorLb1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityTxtbox = new System.Windows.Forms.TextBox();
            this.supplierCmbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.itemNameCmb = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addNewSupplierLink);
            this.panel1.Controls.Add(this.err4);
            this.panel1.Controls.Add(this.err3);
            this.panel1.Controls.Add(this.err2);
            this.panel1.Controls.Add(this.errorLb1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.quantityTxtbox);
            this.panel1.Controls.Add(this.supplierCmbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.datepicker);
            this.panel1.Controls.Add(this.itemNameCmb);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 349);
            this.panel1.TabIndex = 0;
            // 
            // addNewSupplierLink
            // 
            this.addNewSupplierLink.Location = new System.Drawing.Point(101, 173);
            this.addNewSupplierLink.Name = "addNewSupplierLink";
            this.addNewSupplierLink.Size = new System.Drawing.Size(100, 23);
            this.addNewSupplierLink.TabIndex = 50;
            this.addNewSupplierLink.TabStop = true;
            this.addNewSupplierLink.Text = "Add New Supplier";
            this.addNewSupplierLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewSupplierLink_LinkClicked);
            // 
            // err4
            // 
            this.err4.BackColor = System.Drawing.Color.Transparent;
            this.err4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err4.ForeColor = System.Drawing.Color.Red;
            this.err4.Location = new System.Drawing.Point(302, 65);
            this.err4.Name = "err4";
            this.err4.Size = new System.Drawing.Size(26, 14);
            this.err4.TabIndex = 49;
            this.err4.Text = "*";
            this.err4.Visible = false;
            // 
            // err3
            // 
            this.err3.BackColor = System.Drawing.Color.Transparent;
            this.err3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err3.ForeColor = System.Drawing.Color.Red;
            this.err3.Location = new System.Drawing.Point(302, 147);
            this.err3.Name = "err3";
            this.err3.Size = new System.Drawing.Size(23, 14);
            this.err3.TabIndex = 48;
            this.err3.Text = "*";
            this.err3.Visible = false;
            // 
            // err2
            // 
            this.err2.BackColor = System.Drawing.Color.Transparent;
            this.err2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err2.ForeColor = System.Drawing.Color.Red;
            this.err2.Location = new System.Drawing.Point(192, 210);
            this.err2.Name = "err2";
            this.err2.Size = new System.Drawing.Size(26, 14);
            this.err2.TabIndex = 47;
            this.err2.Text = "*";
            this.err2.Visible = false;
            // 
            // errorLb1
            // 
            this.errorLb1.BackColor = System.Drawing.Color.Transparent;
            this.errorLb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLb1.ForeColor = System.Drawing.Color.Red;
            this.errorLb1.Location = new System.Drawing.Point(98, 239);
            this.errorLb1.Name = "errorLb1";
            this.errorLb1.Size = new System.Drawing.Size(205, 21);
            this.errorLb1.TabIndex = 45;
            this.errorLb1.Text = "*Input fields cannot be empty";
            this.errorLb1.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(34, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Quantity  ";
            // 
            // quantityTxtbox
            // 
            this.quantityTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.quantityTxtbox.Location = new System.Drawing.Point(102, 203);
            this.quantityTxtbox.Name = "quantityTxtbox";
            this.quantityTxtbox.Size = new System.Drawing.Size(88, 24);
            this.quantityTxtbox.TabIndex = 3;
            this.quantityTxtbox.Text = "0";
            this.quantityTxtbox.TextChanged += new System.EventHandler(this.quantityTxtbox_TextChanged);
            this.quantityTxtbox.Leave += new System.EventHandler(this.quantityTxtbox_Leave);
            // 
            // supplierCmbox
            // 
            this.supplierCmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierCmbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.supplierCmbox.FormattingEnabled = true;
            this.supplierCmbox.Location = new System.Drawing.Point(101, 144);
            this.supplierCmbox.Name = "supplierCmbox";
            this.supplierCmbox.Size = new System.Drawing.Size(195, 26);
            this.supplierCmbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(32, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(49, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date Received";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(50, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Item Name";
            // 
            // datepicker
            // 
            this.datepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker.Location = new System.Drawing.Point(101, 108);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(105, 24);
            this.datepicker.TabIndex = 1;
            // 
            // itemNameCmb
            // 
            this.itemNameCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemNameCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.itemNameCmb.FormattingEnabled = true;
            this.itemNameCmb.Location = new System.Drawing.Point(101, 65);
            this.itemNameCmb.Name = "itemNameCmb";
            this.itemNameCmb.Size = new System.Drawing.Size(195, 26);
            this.itemNameCmb.TabIndex = 0;
            this.itemNameCmb.SelectedIndexChanged += new System.EventHandler(this.ItemNameCmbSelectedIndexChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveBtn.Location = new System.Drawing.Point(134, 270);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(131, 42);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save Log";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtnClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Location = new System.Drawing.Point(0, 327);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(385, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ReceivableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 349);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReceivableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receivables";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReceivableFormFormClosed);
            this.Load += new System.EventHandler(this.ReceivableForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label err3;
		private System.Windows.Forms.Label err4;
		private System.Windows.Forms.Label err2;
		private System.Windows.Forms.DateTimePicker datepicker;
		private System.Windows.Forms.TextBox quantityTxtbox;
		private System.Windows.Forms.Label errorLb1;
		private System.Windows.Forms.Button saveBtn;
		public System.Windows.Forms.ComboBox supplierCmbox;
		public System.Windows.Forms.ComboBox itemNameCmb;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel addNewSupplierLink;
    }
}
