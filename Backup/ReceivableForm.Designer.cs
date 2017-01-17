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
			this.err4 = new System.Windows.Forms.Label();
			this.err3 = new System.Windows.Forms.Label();
			this.err2 = new System.Windows.Forms.Label();
			this.err1 = new System.Windows.Forms.Label();
			this.errorLb1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.quantityTxtbox = new System.Windows.Forms.TextBox();
			this.supplierCmbox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.datepicker = new System.Windows.Forms.DateTimePicker();
			this.itemNameCmb = new System.Windows.Forms.ComboBox();
			this.saveBtn = new System.Windows.Forms.Button();
			this.costTxtbox = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.err4);
			this.panel1.Controls.Add(this.err3);
			this.panel1.Controls.Add(this.err2);
			this.panel1.Controls.Add(this.err1);
			this.panel1.Controls.Add(this.errorLb1);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.quantityTxtbox);
			this.panel1.Controls.Add(this.supplierCmbox);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.datepicker);
			this.panel1.Controls.Add(this.itemNameCmb);
			this.panel1.Controls.Add(this.saveBtn);
			this.panel1.Controls.Add(this.costTxtbox);
			this.panel1.Controls.Add(this.statusStrip1);
			this.panel1.Controls.Add(this.menuStrip1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(281, 333);
			this.panel1.TabIndex = 0;
			// 
			// err4
			// 
			this.err4.BackColor = System.Drawing.Color.Transparent;
			this.err4.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.err4.ForeColor = System.Drawing.Color.Red;
			this.err4.Location = new System.Drawing.Point(252, 65);
			this.err4.Name = "err4";
			this.err4.Size = new System.Drawing.Size(26, 14);
			this.err4.TabIndex = 49;
			this.err4.Text = "*";
			this.err4.Visible = false;
			// 
			// err3
			// 
			this.err3.BackColor = System.Drawing.Color.Transparent;
			this.err3.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.err3.ForeColor = System.Drawing.Color.Red;
			this.err3.Location = new System.Drawing.Point(253, 148);
			this.err3.Name = "err3";
			this.err3.Size = new System.Drawing.Size(23, 14);
			this.err3.TabIndex = 48;
			this.err3.Text = "*";
			this.err3.Visible = false;
			// 
			// err2
			// 
			this.err2.BackColor = System.Drawing.Color.Transparent;
			this.err2.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.err2.ForeColor = System.Drawing.Color.Red;
			this.err2.Location = new System.Drawing.Point(196, 197);
			this.err2.Name = "err2";
			this.err2.Size = new System.Drawing.Size(26, 14);
			this.err2.TabIndex = 47;
			this.err2.Text = "*";
			this.err2.Visible = false;
			// 
			// err1
			// 
			this.err1.BackColor = System.Drawing.Color.Transparent;
			this.err1.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.err1.ForeColor = System.Drawing.Color.Red;
			this.err1.Location = new System.Drawing.Point(196, 233);
			this.err1.Name = "err1";
			this.err1.Size = new System.Drawing.Size(26, 14);
			this.err1.TabIndex = 46;
			this.err1.Text = "*";
			this.err1.Visible = false;
			// 
			// errorLb1
			// 
			this.errorLb1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.errorLb1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLb1.ForeColor = System.Drawing.Color.Red;
			this.errorLb1.Location = new System.Drawing.Point(47, 5);
			this.errorLb1.Name = "errorLb1";
			this.errorLb1.Size = new System.Drawing.Size(205, 14);
			this.errorLb1.TabIndex = 45;
			this.errorLb1.Text = "*Input fields cannot be empty";
			this.errorLb1.Visible = false;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 194);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 23);
			this.label5.TabIndex = 20;
			this.label5.Text = "Quantity";
			// 
			// quantityTxtbox
			// 
			this.quantityTxtbox.Location = new System.Drawing.Point(102, 195);
			this.quantityTxtbox.Name = "quantityTxtbox";
			this.quantityTxtbox.Size = new System.Drawing.Size(88, 20);
			this.quantityTxtbox.TabIndex = 14;
			// 
			// supplierCmbox
			// 
			this.supplierCmbox.FormattingEnabled = true;
			this.supplierCmbox.Location = new System.Drawing.Point(101, 144);
			this.supplierCmbox.Name = "supplierCmbox";
			this.supplierCmbox.Size = new System.Drawing.Size(148, 21);
			this.supplierCmbox.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 233);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 16);
			this.label4.TabIndex = 12;
			this.label4.Text = "Cost";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 148);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Supplier";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(17, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Date Received";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(18, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Item Name";
			// 
			// datepicker
			// 
			this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datepicker.Location = new System.Drawing.Point(104, 108);
			this.datepicker.Name = "datepicker";
			this.datepicker.Size = new System.Drawing.Size(105, 20);
			this.datepicker.TabIndex = 8;
			// 
			// itemNameCmb
			// 
			this.itemNameCmb.FormattingEnabled = true;
			this.itemNameCmb.Location = new System.Drawing.Point(102, 64);
			this.itemNameCmb.Name = "itemNameCmb";
			this.itemNameCmb.Size = new System.Drawing.Size(147, 21);
			this.itemNameCmb.TabIndex = 7;
			this.itemNameCmb.SelectedIndexChanged += new System.EventHandler(this.ItemNameCmbSelectedIndexChanged);
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(101, 272);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(96, 27);
			this.saveBtn.TabIndex = 6;
			this.saveBtn.Text = "Save";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.SaveBtnClick);
			// 
			// costTxtbox
			// 
			this.costTxtbox.Location = new System.Drawing.Point(102, 229);
			this.costTxtbox.Name = "costTxtbox";
			this.costTxtbox.Size = new System.Drawing.Size(88, 20);
			this.costTxtbox.TabIndex = 5;
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.statusStrip1.Location = new System.Drawing.Point(0, 311);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(281, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(281, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ReceivableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(281, 333);
			this.Controls.Add(this.panel1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ReceivableForm";
			this.Text = "ReceivableForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReceivableFormFormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label err3;
		private System.Windows.Forms.Label err4;
		private System.Windows.Forms.Label err2;
		private System.Windows.Forms.Label err1;
		private System.Windows.Forms.TextBox costTxtbox;
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Panel panel1;
	}
}
