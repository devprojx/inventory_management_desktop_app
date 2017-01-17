/*
 * Created by SharpDevelop.
 * User: VStudent
 * Date: 16/07/2015
 * Time: 07:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class NewRequest
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
			this.components = new System.ComponentModel.Container();
			this.amountRequestedTxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.errorLbl3 = new System.Windows.Forms.Label();
			this.errorLbl2 = new System.Windows.Forms.Label();
			this.errorLb1 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.Submit = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateReceived = new System.Windows.Forms.DateTimePicker();
			this.dateIssued = new System.Windows.Forms.DateTimePicker();
			this.dateRequested = new System.Windows.Forms.DateTimePicker();
			this.itemNameCmb = new System.Windows.Forms.ComboBox();
			this.receivedByTxt = new System.Windows.Forms.TextBox();
			this.amountIssuedTxt = new System.Windows.Forms.TextBox();
			this.issuedByTxt = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// amountRequestedTxt
			// 
			this.amountRequestedTxt.Location = new System.Drawing.Point(156, 118);
			this.amountRequestedTxt.Name = "amountRequestedTxt";
			this.amountRequestedTxt.Size = new System.Drawing.Size(163, 20);
			this.amountRequestedTxt.TabIndex = 3;
			this.amountRequestedTxt.Leave += new System.EventHandler(this.AmountRequestedTxtLeave);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Item Name";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.errorLbl3);
			this.panel1.Controls.Add(this.errorLbl2);
			this.panel1.Controls.Add(this.errorLb1);
			this.panel1.Controls.Add(this.statusStrip1);
			this.panel1.Controls.Add(this.Submit);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dateReceived);
			this.panel1.Controls.Add(this.dateIssued);
			this.panel1.Controls.Add(this.dateRequested);
			this.panel1.Controls.Add(this.itemNameCmb);
			this.panel1.Controls.Add(this.receivedByTxt);
			this.panel1.Controls.Add(this.amountIssuedTxt);
			this.panel1.Controls.Add(this.issuedByTxt);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.amountRequestedTxt);
			this.panel1.Location = new System.Drawing.Point(-1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(359, 389);
			this.panel1.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(55, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 16);
			this.label4.TabIndex = 25;
			// 
			// errorLbl3
			// 
			this.errorLbl3.BackColor = System.Drawing.Color.Transparent;
			this.errorLbl3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLbl3.ForeColor = System.Drawing.Color.Red;
			this.errorLbl3.Location = new System.Drawing.Point(319, 198);
			this.errorLbl3.Name = "errorLbl3";
			this.errorLbl3.Size = new System.Drawing.Size(16, 21);
			this.errorLbl3.TabIndex = 24;
			this.errorLbl3.Text = "!";
			this.errorLbl3.Visible = false;
			// 
			// errorLbl2
			// 
			this.errorLbl2.BackColor = System.Drawing.Color.Transparent;
			this.errorLbl2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLbl2.ForeColor = System.Drawing.Color.Red;
			this.errorLbl2.Location = new System.Drawing.Point(319, 116);
			this.errorLbl2.Name = "errorLbl2";
			this.errorLbl2.Size = new System.Drawing.Size(21, 26);
			this.errorLbl2.TabIndex = 23;
			this.errorLbl2.Text = "!";
			this.errorLbl2.Visible = false;
			// 
			// errorLb1
			// 
			this.errorLb1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.errorLb1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLb1.ForeColor = System.Drawing.Color.Red;
			this.errorLb1.Location = new System.Drawing.Point(155, 3);
			this.errorLb1.Name = "errorLb1";
			this.errorLb1.Size = new System.Drawing.Size(205, 14);
			this.errorLb1.TabIndex = 22;
			this.errorLb1.Text = "*Input fields cannot be empty";
			this.errorLb1.Visible = false;
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 0);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(359, 22);
			this.statusStrip1.TabIndex = 20;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
			this.toolStripStatusLabel1.Text = "In Stock: ";
			// 
			// Submit
			// 
			this.Submit.Location = new System.Drawing.Point(156, 349);
			this.Submit.Name = "Submit";
			this.Submit.Size = new System.Drawing.Size(75, 23);
			this.Submit.TabIndex = 9;
			this.Submit.Text = "Submit";
			this.Submit.UseVisualStyleBackColor = true;
			this.Submit.Click += new System.EventHandler(this.SubmitClick);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(17, 321);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(61, 23);
			this.label9.TabIndex = 19;
			this.label9.Text = "Received Date";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(17, 283);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 23);
			this.label8.TabIndex = 18;
			this.label8.Text = "Received By";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(17, 245);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 23);
			this.label7.TabIndex = 17;
			this.label7.Text = "Date Issued";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(17, 199);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "Amount Issued";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(17, 161);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "Issued By";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(17, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "Amount Requested";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(17, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Date Requested";
			// 
			// dateReceived
			// 
			this.dateReceived.CustomFormat = "\"dd MM yyyy\"";
			this.dateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateReceived.Location = new System.Drawing.Point(156, 308);
			this.dateReceived.Name = "dateReceived";
			this.dateReceived.Size = new System.Drawing.Size(110, 20);
			this.dateReceived.TabIndex = 8;
			// 
			// dateIssued
			// 
			this.dateIssued.CustomFormat = "\"dd MM yyyy\"";
			this.dateIssued.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateIssued.Location = new System.Drawing.Point(156, 242);
			this.dateIssued.Name = "dateIssued";
			this.dateIssued.Size = new System.Drawing.Size(110, 20);
			this.dateIssued.TabIndex = 6;
			// 
			// dateRequested
			// 
			this.dateRequested.CustomFormat = "\"dd MM yyyy\"";
			this.dateRequested.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateRequested.Location = new System.Drawing.Point(156, 77);
			this.dateRequested.Name = "dateRequested";
			this.dateRequested.Size = new System.Drawing.Size(121, 20);
			this.dateRequested.TabIndex = 2;
			// 
			// itemNameCmb
			// 
			this.itemNameCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.itemNameCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.itemNameCmb.FormattingEnabled = true;
			this.itemNameCmb.Location = new System.Drawing.Point(156, 42);
			this.itemNameCmb.Name = "itemNameCmb";
			this.itemNameCmb.Size = new System.Drawing.Size(121, 21);
			this.itemNameCmb.TabIndex = 1;
			this.itemNameCmb.SelectedIndexChanged += new System.EventHandler(this.ItemNameCmbSelectedIndexChanged);
			// 
			// receivedByTxt
			// 
			this.receivedByTxt.Location = new System.Drawing.Point(156, 277);
			this.receivedByTxt.Name = "receivedByTxt";
			this.receivedByTxt.Size = new System.Drawing.Size(163, 20);
			this.receivedByTxt.TabIndex = 7;
			// 
			// amountIssuedTxt
			// 
			this.amountIssuedTxt.Location = new System.Drawing.Point(156, 199);
			this.amountIssuedTxt.Name = "amountIssuedTxt";
			this.amountIssuedTxt.Size = new System.Drawing.Size(163, 20);
			this.amountIssuedTxt.TabIndex = 5;
			this.amountIssuedTxt.Leave += new System.EventHandler(this.AmountIssuedTxtLeave);
			// 
			// issuedByTxt
			// 
			this.issuedByTxt.Location = new System.Drawing.Point(156, 157);
			this.issuedByTxt.Name = "issuedByTxt";
			this.issuedByTxt.Size = new System.Drawing.Size(163, 20);
			this.issuedByTxt.TabIndex = 4;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 2000;
			// 
			// NewRequest
			// 
			this.AcceptButton = this.Submit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 385);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(373, 424);
			this.Name = "NewRequest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Request";
			this.Load += new System.EventHandler(this.NewRequestLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewRequestFormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox itemNameCmb;
		private System.Windows.Forms.Label errorLbl2;
		private System.Windows.Forms.Label errorLbl3;
		private System.Windows.Forms.Label errorLb1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox amountRequestedTxt;
		private System.Windows.Forms.TextBox issuedByTxt;
		private System.Windows.Forms.TextBox amountIssuedTxt;
		private System.Windows.Forms.TextBox receivedByTxt;
		private System.Windows.Forms.DateTimePicker dateRequested;
		private System.Windows.Forms.DateTimePicker dateIssued;
		private System.Windows.Forms.DateTimePicker dateReceived;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button Submit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		
		
	}
}
