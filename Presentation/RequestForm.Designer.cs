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
	partial class RequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestForm));
            this.amountRequestedTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.errorLb1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Submit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.itemNameCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorLbl2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountRequestedTxt
            // 
            this.amountRequestedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.amountRequestedTxt.Location = new System.Drawing.Point(70, 112);
            this.amountRequestedTxt.Name = "amountRequestedTxt";
            this.amountRequestedTxt.Size = new System.Drawing.Size(99, 26);
            this.amountRequestedTxt.TabIndex = 3;
            this.amountRequestedTxt.Leave += new System.EventHandler(this.AmountRequestedTxtLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(66, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.errorLb1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.itemNameCmb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.amountRequestedTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.errorLbl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 209);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(55, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 25;
            // 
            // errorLb1
            // 
            this.errorLb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.errorLb1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLb1.ForeColor = System.Drawing.Color.Red;
            this.errorLb1.Location = new System.Drawing.Point(155, 4);
            this.errorLb1.Name = "errorLb1";
            this.errorLb1.Size = new System.Drawing.Size(205, 14);
            this.errorLb1.TabIndex = 22;
            this.errorLb1.Text = "*Input fields cannot be empty";
            this.errorLb1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(392, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "In Stock: ";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Submit.ForeColor = System.Drawing.SystemColors.Control;
            this.Submit.Location = new System.Drawing.Point(126, 154);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(144, 43);
            this.Submit.TabIndex = 9;
            this.Submit.Text = "Submit Request";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.SubmitClick);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(13, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 15;
            // 
            // itemNameCmb
            // 
            this.itemNameCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemNameCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemNameCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemNameCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.itemNameCmb.FormattingEnabled = true;
            this.itemNameCmb.Location = new System.Drawing.Point(70, 56);
            this.itemNameCmb.Name = "itemNameCmb";
            this.itemNameCmb.Size = new System.Drawing.Size(262, 28);
            this.itemNameCmb.TabIndex = 1;
            this.itemNameCmb.SelectedIndexChanged += new System.EventHandler(this.ItemNameCmbSelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(67, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount Requested";
            // 
            // errorLbl2
            // 
            this.errorLbl2.BackColor = System.Drawing.Color.Transparent;
            this.errorLbl2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl2.ForeColor = System.Drawing.Color.Red;
            this.errorLbl2.Location = new System.Drawing.Point(166, 111);
            this.errorLbl2.Name = "errorLbl2";
            this.errorLbl2.Size = new System.Drawing.Size(14, 26);
            this.errorLbl2.TabIndex = 23;
            this.errorLbl2.Text = "!";
            this.errorLbl2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            // 
            // RequestForm
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 209);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewRequestFormClosed);
            this.Load += new System.EventHandler(this.NewRequestLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.ComboBox itemNameCmb;
		private System.Windows.Forms.Label errorLbl2;
		private System.Windows.Forms.Label errorLb1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox amountRequestedTxt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button Submit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		
		
	}
}
