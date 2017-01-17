/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 11/09/2015
 * Time: 12:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class ReceivedLog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.supplierTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemnameTxtBox = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.dateMskTxtbx = new System.Windows.Forms.MaskedTextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 395);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.supplierTxtbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.itemnameTxtBox);
            this.groupBox1.Controls.Add(this.refresh);
            this.groupBox1.Controls.Add(this.dateMskTxtbx);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 44);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(443, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Supplier";
            // 
            // supplierTxtbox
            // 
            this.supplierTxtbox.Location = new System.Drawing.Point(500, 11);
            this.supplierTxtbox.Name = "supplierTxtbox";
            this.supplierTxtbox.Size = new System.Drawing.Size(100, 20);
            this.supplierTxtbox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(239, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Item Name";
            // 
            // itemnameTxtBox
            // 
            this.itemnameTxtBox.Location = new System.Drawing.Point(304, 11);
            this.itemnameTxtBox.Name = "itemnameTxtBox";
            this.itemnameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.itemnameTxtBox.TabIndex = 14;
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.refresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refresh.Image = global::Inventory_System.Resource1._1438206457_Refresh;
            this.refresh.Location = new System.Drawing.Point(754, 11);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(32, 23);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refresh.TabIndex = 13;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.RefreshClick);
            this.refresh.MouseEnter += new System.EventHandler(this.RefreshMouseEnter);
            this.refresh.MouseLeave += new System.EventHandler(this.RefreshMouseLeave);
            // 
            // dateMskTxtbx
            // 
            this.dateMskTxtbx.Location = new System.Drawing.Point(135, 11);
            this.dateMskTxtbx.Mask = "00/0000";
            this.dateMskTxtbx.Name = "dateMskTxtbx";
            this.dateMskTxtbx.Size = new System.Drawing.Size(61, 20);
            this.dateMskTxtbx.TabIndex = 0;
            this.dateMskTxtbx.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dateMskTxtbx_MaskInputRejected);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(652, 9);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(71, 28);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtnClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(59, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Month/Year";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(809, 325);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.Image = global::Inventory_System.Resource1.pdf;
            this.fileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.fileToolStripMenuItem.Text = "Save As PDF";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItemClick);
            // 
            // ReceivedLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 395);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReceivedLog";
            this.Text = "Received Logs";
            this.Load += new System.EventHandler(this.ReceivedLog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.TextBox supplierTxtbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox dateMskTxtbx;
		private System.Windows.Forms.PictureBox refresh;
		private System.Windows.Forms.TextBox itemnameTxtBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
	}
}
