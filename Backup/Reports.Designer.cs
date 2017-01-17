/*
 * Created by SharpDevelop.
 * User: Vstudent
 * Date: 7/27/2015
 * Time: 5:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class Reports
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.genrateReportBtn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label2 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.saveTlBar = new System.Windows.Forms.ToolStripMenuItem();
			this.monthMskBox = new System.Windows.Forms.MaskedTextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.yearMskTxtbx = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.allItemsRdBtn = new System.Windows.Forms.RadioButton();
			this.leastUsedRdBtn = new System.Windows.Forms.RadioButton();
			this.mostUsedRdBtn = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// genrateReportBtn
			// 
			this.genrateReportBtn.Location = new System.Drawing.Point(82, 234);
			this.genrateReportBtn.Name = "genrateReportBtn";
			this.genrateReportBtn.Size = new System.Drawing.Size(121, 31);
			this.genrateReportBtn.TabIndex = 6;
			this.genrateReportBtn.Text = "Generate Report";
			this.genrateReportBtn.UseVisualStyleBackColor = true;
			this.genrateReportBtn.Click += new System.EventHandler(this.GenrateReportBtnClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chart1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.statusStrip1);
			this.panel1.Controls.Add(this.menuStrip1);
			this.panel1.Controls.Add(this.monthMskBox);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.yearMskTxtbx);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.genrateReportBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(998, 556);
			this.panel1.TabIndex = 1;
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(276, 246);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Items";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(556, 274);
			this.chart1.TabIndex = 13;
			this.chart1.Text = "chart1";
			this.chart1.Visible = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(393, 220);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Report Preview";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.statusStrip1.Location = new System.Drawing.Point(0, 534);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(998, 22);
			this.statusStrip1.TabIndex = 10;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.saveTlBar});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(998, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// saveTlBar
			// 
			this.saveTlBar.Name = "saveTlBar";
			this.saveTlBar.Size = new System.Drawing.Size(80, 20);
			this.saveTlBar.Text = "Save As Pdf";
			this.saveTlBar.Click += new System.EventHandler(this.SaveTlBarClick);
			// 
			// monthMskBox
			// 
			this.monthMskBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.monthMskBox.Location = new System.Drawing.Point(103, 181);
			this.monthMskBox.Mask = "00";
			this.monthMskBox.Name = "monthMskBox";
			this.monthMskBox.Size = new System.Drawing.Size(33, 24);
			this.monthMskBox.TabIndex = 4;
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Location = new System.Drawing.Point(276, 37);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(332, 180);
			this.dataGridView1.TabIndex = 8;
			// 
			// yearMskTxtbx
			// 
			this.yearMskTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yearMskTxtbx.Location = new System.Drawing.Point(140, 181);
			this.yearMskTxtbx.Mask = "0000";
			this.yearMskTxtbx.Name = "yearMskTxtbx";
			this.yearMskTxtbx.Size = new System.Drawing.Size(46, 24);
			this.yearMskTxtbx.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(82, 161);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Enter Month/Year (Optional)";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.allItemsRdBtn);
			this.groupBox1.Controls.Add(this.leastUsedRdBtn);
			this.groupBox1.Controls.Add(this.mostUsedRdBtn);
			this.groupBox1.Location = new System.Drawing.Point(55, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 115);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filter";
			// 
			// allItemsRdBtn
			// 
			this.allItemsRdBtn.Location = new System.Drawing.Point(30, 16);
			this.allItemsRdBtn.Name = "allItemsRdBtn";
			this.allItemsRdBtn.Size = new System.Drawing.Size(121, 24);
			this.allItemsRdBtn.TabIndex = 1;
			this.allItemsRdBtn.TabStop = true;
			this.allItemsRdBtn.Text = "Overall Summary";
			this.allItemsRdBtn.UseVisualStyleBackColor = true;
			// 
			// leastUsedRdBtn
			// 
			this.leastUsedRdBtn.Location = new System.Drawing.Point(30, 76);
			this.leastUsedRdBtn.Name = "leastUsedRdBtn";
			this.leastUsedRdBtn.Size = new System.Drawing.Size(139, 24);
			this.leastUsedRdBtn.TabIndex = 3;
			this.leastUsedRdBtn.TabStop = true;
			this.leastUsedRdBtn.Text = "Order by least used";
			this.leastUsedRdBtn.UseVisualStyleBackColor = true;
			// 
			// mostUsedRdBtn
			// 
			this.mostUsedRdBtn.Location = new System.Drawing.Point(30, 46);
			this.mostUsedRdBtn.Name = "mostUsedRdBtn";
			this.mostUsedRdBtn.Size = new System.Drawing.Size(139, 24);
			this.mostUsedRdBtn.TabIndex = 2;
			this.mostUsedRdBtn.TabStop = true;
			this.mostUsedRdBtn.Text = "Order by most used";
			this.mostUsedRdBtn.UseVisualStyleBackColor = true;
			// 
			// Reports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(998, 556);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Reports";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Report Generator";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportsFormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.ToolStripMenuItem saveTlBar;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MaskedTextBox yearMskTxtbx;
		private System.Windows.Forms.MaskedTextBox monthMskBox;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button genrateReportBtn;
		private System.Windows.Forms.RadioButton leastUsedRdBtn;
		private System.Windows.Forms.RadioButton mostUsedRdBtn;
		private System.Windows.Forms.RadioButton allItemsRdBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
	}
}
