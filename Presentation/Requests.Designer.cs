/*
 * Created by SharpDevelop.
 * User: VStudent
 * Date: 16/07/2015
 * Time: 05:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class Requests
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
            this.label3 = new System.Windows.Forms.Label();
            this.itemnameTxtBox = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.dateMskTxtbx = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportAsPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 73);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.itemnameTxtBox);
            this.groupBox1.Controls.Add(this.refresh);
            this.groupBox1.Controls.Add(this.dateMskTxtbx);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nameTxtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 44);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(575, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Item Name";
            // 
            // itemnameTxtBox
            // 
            this.itemnameTxtBox.Location = new System.Drawing.Point(656, 13);
            this.itemnameTxtBox.Name = "itemnameTxtBox";
            this.itemnameTxtBox.Size = new System.Drawing.Size(100, 24);
            this.itemnameTxtBox.TabIndex = 14;
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.refresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refresh.Image = global::Inventory_System.Resource1._1438206457_Refresh;
            this.refresh.Location = new System.Drawing.Point(976, 12);
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
            this.dateMskTxtbx.Location = new System.Drawing.Point(279, 14);
            this.dateMskTxtbx.Mask = "00/0000";
            this.dateMskTxtbx.Name = "dateMskTxtbx";
            this.dateMskTxtbx.Size = new System.Drawing.Size(61, 24);
            this.dateMskTxtbx.TabIndex = 0;
            this.dateMskTxtbx.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dateMskTxtbx_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(898, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(458, 14);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(91, 24);
            this.nameTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(366, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "User\'s Name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(191, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Month/Year";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsPdfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportAsPdfToolStripMenuItem
            // 
            this.exportAsPdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsPdfToolStripMenuItem});
            this.exportAsPdfToolStripMenuItem.Name = "exportAsPdfToolStripMenuItem";
            this.exportAsPdfToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exportAsPdfToolStripMenuItem.Text = "File";
            this.exportAsPdfToolStripMenuItem.Click += new System.EventHandler(this.ExportAsPdfToolStripMenuItemClick);
            // 
            // saveAsPdfToolStripMenuItem
            // 
            this.saveAsPdfToolStripMenuItem.Name = "saveAsPdfToolStripMenuItem";
            this.saveAsPdfToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveAsPdfToolStripMenuItem.Text = "Save As Pdf";
            this.saveAsPdfToolStripMenuItem.Click += new System.EventHandler(this.SaveAsPdfToolStripMenuItemClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 304);
            this.dataGridView1.TabIndex = 5;
            // 
            // Requests
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 377);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::Inventory_System.Resource1.Aha_Soft_Standard_Portfolio_Inventory;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(960, 415);
            this.Name = "Requests";
            this.Text = "Request Logs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryTransactionFormClosed);
            this.Load += new System.EventHandler(this.InventoryTransaction_Load);
            this.Shown += new System.EventHandler(this.InventoryTransactionShown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.TextBox itemnameTxtBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStripMenuItem saveAsPdfToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportAsPdfToolStripMenuItem;
		private System.Windows.Forms.PictureBox refresh;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nameTxtBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MaskedTextBox dateMskTxtbx;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
