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
	partial class 
Reports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.genrateReportBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.categoryCmbox = new System.Windows.Forms.ComboBox();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.limitNumeric = new System.Windows.Forms.NumericUpDown();
            this.toLbl = new System.Windows.Forms.Label();
            this.reportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGraphImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.leastExpenseRdBtn = new System.Windows.Forms.RadioButton();
            this.mostExpenseRdBtn = new System.Windows.Forms.RadioButton();
            this.leastUsedRdBtn = new System.Windows.Forms.RadioButton();
            this.mostUsedRdBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // genrateReportBtn
            // 
            this.genrateReportBtn.Location = new System.Drawing.Point(127, 246);
            this.genrateReportBtn.Name = "genrateReportBtn";
            this.genrateReportBtn.Size = new System.Drawing.Size(100, 31);
            this.genrateReportBtn.TabIndex = 6;
            this.genrateReportBtn.Text = "Generate Report";
            this.genrateReportBtn.UseVisualStyleBackColor = true;
            this.genrateReportBtn.Click += new System.EventHandler(this.GenrateReportBtnClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.categoryLbl);
            this.panel1.Controls.Add(this.categoryCmbox);
            this.panel1.Controls.Add(this.fromDatePicker);
            this.panel1.Controls.Add(this.toDatePicker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.limitNumeric);
            this.panel1.Controls.Add(this.toLbl);
            this.panel1.Controls.Add(this.reportChart);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.genrateReportBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 635);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // categoryLbl
            // 
            this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryLbl.Location = new System.Drawing.Point(32, 119);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(72, 19);
            this.categoryLbl.TabIndex = 23;
            this.categoryLbl.Text = "Category";
            // 
            // categoryCmbox
            // 
            this.categoryCmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCmbox.FormattingEnabled = true;
            this.categoryCmbox.Location = new System.Drawing.Point(108, 119);
            this.categoryCmbox.Name = "categoryCmbox";
            this.categoryCmbox.Size = new System.Drawing.Size(163, 21);
            this.categoryCmbox.TabIndex = 22;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDatePicker.Location = new System.Drawing.Point(63, 174);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(93, 20);
            this.fromDatePicker.TabIndex = 21;
            // 
            // toDatePicker
            // 
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDatePicker.Location = new System.Drawing.Point(193, 173);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(86, 20);
            this.toDatePicker.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Top";
            // 
            // limitNumeric
            // 
            this.limitNumeric.Location = new System.Drawing.Point(146, 218);
            this.limitNumeric.Name = "limitNumeric";
            this.limitNumeric.Size = new System.Drawing.Size(59, 20);
            this.limitNumeric.TabIndex = 17;
            // 
            // toLbl
            // 
            this.toLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLbl.Location = new System.Drawing.Point(162, 174);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(26, 23);
            this.toLbl.TabIndex = 16;
            this.toLbl.Text = "To";
            // 
            // reportChart
            // 
            this.reportChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.reportChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.reportChart.Legends.Add(legend2);
            this.reportChart.Location = new System.Drawing.Point(0, 287);
            this.reportChart.Name = "reportChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.reportChart.Series.Add(series2);
            this.reportChart.Size = new System.Drawing.Size(998, 345);
            this.reportChart.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveReportToolStripMenuItem,
            this.exportToExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 29);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveReportToolStripMenuItem
            // 
            this.saveReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsPDFToolStripMenuItem,
            this.saveGraphImageToolStripMenuItem});
            this.saveReportToolStripMenuItem.Image = global::Inventory_System.Resource1.report;
            this.saveReportToolStripMenuItem.Name = "saveReportToolStripMenuItem";
            this.saveReportToolStripMenuItem.Size = new System.Drawing.Size(122, 25);
            this.saveReportToolStripMenuItem.Text = "Save Report";
            // 
            // saveAsPDFToolStripMenuItem
            // 
            this.saveAsPDFToolStripMenuItem.Image = global::Inventory_System.Resource1.pdf;
            this.saveAsPDFToolStripMenuItem.Name = "saveAsPDFToolStripMenuItem";
            this.saveAsPDFToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.saveAsPDFToolStripMenuItem.Text = "Save as PDF";
            this.saveAsPDFToolStripMenuItem.Click += new System.EventHandler(this.saveAsPDFToolStripMenuItem_Click);
            // 
            // saveGraphImageToolStripMenuItem
            // 
            this.saveGraphImageToolStripMenuItem.Image = global::Inventory_System.Resource1.png;
            this.saveGraphImageToolStripMenuItem.Name = "saveGraphImageToolStripMenuItem";
            this.saveGraphImageToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.saveGraphImageToolStripMenuItem.Text = "Save Graph as PNG";
            this.saveGraphImageToolStripMenuItem.Click += new System.EventHandler(this.saveGraphImageToolStripMenuItem_Click);
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Image = global::Inventory_System.Resource1.excel;
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(138, 25);
            this.exportToExcelToolStripMenuItem.Text = "Export to Excel";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(355, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 222);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(105, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Month/Year (Optional)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.leastExpenseRdBtn);
            this.groupBox1.Controls.Add(this.mostExpenseRdBtn);
            this.groupBox1.Controls.Add(this.leastUsedRdBtn);
            this.groupBox1.Controls.Add(this.mostUsedRdBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // leastExpenseRdBtn
            // 
            this.leastExpenseRdBtn.Location = new System.Drawing.Point(181, 45);
            this.leastExpenseRdBtn.Name = "leastExpenseRdBtn";
            this.leastExpenseRdBtn.Size = new System.Drawing.Size(139, 24);
            this.leastExpenseRdBtn.TabIndex = 5;
            this.leastExpenseRdBtn.TabStop = true;
            this.leastExpenseRdBtn.Text = "Order by least expense";
            this.leastExpenseRdBtn.UseVisualStyleBackColor = true;
            // 
            // mostExpenseRdBtn
            // 
            this.mostExpenseRdBtn.Location = new System.Drawing.Point(29, 46);
            this.mostExpenseRdBtn.Name = "mostExpenseRdBtn";
            this.mostExpenseRdBtn.Size = new System.Drawing.Size(139, 24);
            this.mostExpenseRdBtn.TabIndex = 4;
            this.mostExpenseRdBtn.TabStop = true;
            this.mostExpenseRdBtn.Text = "Order by most expense";
            this.mostExpenseRdBtn.UseVisualStyleBackColor = true;
            // 
            // leastUsedRdBtn
            // 
            this.leastUsedRdBtn.Location = new System.Drawing.Point(181, 15);
            this.leastUsedRdBtn.Name = "leastUsedRdBtn";
            this.leastUsedRdBtn.Size = new System.Drawing.Size(139, 24);
            this.leastUsedRdBtn.TabIndex = 3;
            this.leastUsedRdBtn.TabStop = true;
            this.leastUsedRdBtn.Text = "Order by least used";
            this.leastUsedRdBtn.UseVisualStyleBackColor = true;
            // 
            // mostUsedRdBtn
            // 
            this.mostUsedRdBtn.Location = new System.Drawing.Point(30, 15);
            this.mostUsedRdBtn.Name = "mostUsedRdBtn";
            this.mostUsedRdBtn.Size = new System.Drawing.Size(139, 24);
            this.mostUsedRdBtn.TabIndex = 2;
            this.mostUsedRdBtn.TabStop = true;
            this.mostUsedRdBtn.Text = "Order by most used";
            this.mostUsedRdBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Report Preview";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "excel.png");
            // 
            // Reports
            // 
            this.AcceptButton = this.genrateReportBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 635);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportsFormClosed);
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button genrateReportBtn;
		private System.Windows.Forms.RadioButton leastUsedRdBtn;
		private System.Windows.Forms.RadioButton mostUsedRdBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart reportChart;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown limitNumeric;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.ToolStripMenuItem saveReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGraphImageToolStripMenuItem;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.ComboBox categoryCmbox;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.RadioButton leastExpenseRdBtn;
        private System.Windows.Forms.RadioButton mostExpenseRdBtn;
        private System.Windows.Forms.ImageList imageList1;
    }
}
