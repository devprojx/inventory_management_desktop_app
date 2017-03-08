/*
 * Created by SharpDevelop.
 * User: VStudent
 * Date: 16/07/2015
 * Time: 10:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivableLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportItemListAsPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReceivablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItemQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrEditExistingUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.printBtn = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.requestDialogBtn = new System.Windows.Forms.Button();
            this.requestGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.activityExportBtn = new System.Windows.Forms.Button();
            this.activityDatagrid = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.receivablePic = new System.Windows.Forms.PictureBox();
            this.editItem = new System.Windows.Forms.PictureBox();
            this.addPicbx = new System.Windows.Forms.PictureBox();
            this.about = new System.Windows.Forms.PictureBox();
            this.CreateUserPic = new System.Windows.Forms.PictureBox();
            this.updatePic = new System.Windows.Forms.PictureBox();
            this.DeletePic = new System.Windows.Forms.PictureBox();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.uptodatePic = new System.Windows.Forms.PictureBox();
            this.uptodatePic2 = new System.Windows.Forms.PictureBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receivablePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPicbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.about)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateUserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uptodatePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uptodatePic2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.createOrEditExistingUserToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.aboutToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionLogsToolStripMenuItem,
            this.receivableLogsToolStripMenuItem,
            this.exportItemListAsPDFToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.Image = global::Inventory_System.Resource1.view;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(105, 25);
            this.viewToolStripMenuItem.Text = "View Logs";
            // 
            // transactionLogsToolStripMenuItem
            // 
            this.transactionLogsToolStripMenuItem.Name = "transactionLogsToolStripMenuItem";
            this.transactionLogsToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.transactionLogsToolStripMenuItem.Text = "Transaction Logs";
            this.transactionLogsToolStripMenuItem.Click += new System.EventHandler(this.TransactionLogsToolStripMenuItemClick);
            // 
            // receivableLogsToolStripMenuItem
            // 
            this.receivableLogsToolStripMenuItem.Name = "receivableLogsToolStripMenuItem";
            this.receivableLogsToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.receivableLogsToolStripMenuItem.Text = "Receivable Logs";
            this.receivableLogsToolStripMenuItem.Click += new System.EventHandler(this.ReceivableLogsToolStripMenuItemClick);
            // 
            // exportItemListAsPDFToolStripMenuItem
            // 
            this.exportItemListAsPDFToolStripMenuItem.Name = "exportItemListAsPDFToolStripMenuItem";
            this.exportItemListAsPDFToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.exportItemListAsPDFToolStripMenuItem.Text = "Export Item List As PDF";
            this.exportItemListAsPDFToolStripMenuItem.Click += new System.EventHandler(this.ExportItemListAsPDFToolStripMenuItemClick);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewItemToolStripMenuItem,
            this.addSupplierToolStripMenuItem,
            this.addReceivablesToolStripMenuItem,
            this.addCategoryToolStripMenuItem,
            this.updateItemQuantityToolStripMenuItem,
            this.editItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToolStripMenuItem.Image = global::Inventory_System.Resource1.options;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addNewItemToolStripMenuItem
            // 
            this.addNewItemToolStripMenuItem.Image = global::Inventory_System.Resource1._1438216279_icon_81_document_add;
            this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.addNewItemToolStripMenuItem.Text = "Add New Item";
            this.addNewItemToolStripMenuItem.Click += new System.EventHandler(this.AddNewItemToolStripMenuItemClick);
            // 
            // addSupplierToolStripMenuItem
            // 
            this.addSupplierToolStripMenuItem.Image = global::Inventory_System.Resource1.add_icon;
            this.addSupplierToolStripMenuItem.Name = "addSupplierToolStripMenuItem";
            this.addSupplierToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.addSupplierToolStripMenuItem.Text = "Add Supplier";
            this.addSupplierToolStripMenuItem.Click += new System.EventHandler(this.addSupplierToolStripMenuItem_Click);
            // 
            // addReceivablesToolStripMenuItem
            // 
            this.addReceivablesToolStripMenuItem.Image = global::Inventory_System.Resource1._1438216260_icon_105_folder_add;
            this.addReceivablesToolStripMenuItem.Name = "addReceivablesToolStripMenuItem";
            this.addReceivablesToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.addReceivablesToolStripMenuItem.Text = "Add Receivables";
            this.addReceivablesToolStripMenuItem.Click += new System.EventHandler(this.addReceivablesToolStripMenuItem_Click);
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Image = global::Inventory_System.Resource1._1438206469_Add;
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.addCategoryToolStripMenuItem.Text = "Add Category";
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
            // 
            // updateItemQuantityToolStripMenuItem
            // 
            this.updateItemQuantityToolStripMenuItem.Image = global::Inventory_System.Resource1._1438206541_Stock_Index_Up;
            this.updateItemQuantityToolStripMenuItem.Name = "updateItemQuantityToolStripMenuItem";
            this.updateItemQuantityToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.updateItemQuantityToolStripMenuItem.Text = "Update Item Quantity";
            this.updateItemQuantityToolStripMenuItem.Click += new System.EventHandler(this.UpdateItemQuantityToolStripMenuItemClick);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Image = global::Inventory_System.Resource1._1438206555_Edit;
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.EditItemToolStripMenuItemClick);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Image = global::Inventory_System.Resource1._1438207582_Recycle_Bin___empty;
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.DeleteItemToolStripMenuItemClick);
            // 
            // createOrEditExistingUserToolStripMenuItem
            // 
            this.createOrEditExistingUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOrEditExistingUserToolStripMenuItem.Image = global::Inventory_System.Resource1.users;
            this.createOrEditExistingUserToolStripMenuItem.Name = "createOrEditExistingUserToolStripMenuItem";
            this.createOrEditExistingUserToolStripMenuItem.Size = new System.Drawing.Size(215, 25);
            this.createOrEditExistingUserToolStripMenuItem.Text = "Create or edit existing user";
            this.createOrEditExistingUserToolStripMenuItem.Click += new System.EventHandler(this.CreateOrEditExistingUserToolStripMenuItemClick);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Image = global::Inventory_System.Resource1.report;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.ReportsToolStripMenuItemClick);
            // 
            // aboutToolStrip
            // 
            this.aboutToolStrip.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStrip.Image = global::Inventory_System.Resource1.about;
            this.aboutToolStrip.Name = "aboutToolStrip";
            this.aboutToolStrip.Size = new System.Drawing.Size(80, 25);
            this.aboutToolStrip.Text = "About";
            this.aboutToolStrip.Click += new System.EventHandler(this.AboutToolStripClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(48, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 514);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage1.Controls.Add(this.printBtn);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(875, 481);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Notifications";
            // 
            // printBtn
            // 
            this.printBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.printBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printBtn.ImageIndex = 0;
            this.printBtn.ImageList = this.imageList2;
            this.printBtn.Location = new System.Drawing.Point(724, 4);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(147, 31);
            this.printBtn.TabIndex = 2;
            this.printBtn.Text = "Export to excel";
            this.printBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "excel.png");
            this.imageList2.Images.SetKeyName(1, "pdf.png");
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(3, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.Size = new System.Drawing.Size(868, 432);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.requestDialogBtn);
            this.tabPage6.Controls.Add(this.requestGridView);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(875, 481);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Requests";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // requestDialogBtn
            // 
            this.requestDialogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.requestDialogBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.requestDialogBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.requestDialogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestDialogBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.requestDialogBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.requestDialogBtn.Location = new System.Drawing.Point(688, 4);
            this.requestDialogBtn.Name = "requestDialogBtn";
            this.requestDialogBtn.Size = new System.Drawing.Size(181, 31);
            this.requestDialogBtn.TabIndex = 3;
            this.requestDialogBtn.Text = "Open Request Dialog";
            this.requestDialogBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.requestDialogBtn.UseVisualStyleBackColor = false;
            this.requestDialogBtn.Click += new System.EventHandler(this.requestToPdfBtn_Click);
            // 
            // requestGridView
            // 
            this.requestGridView.AllowUserToAddRows = false;
            this.requestGridView.AllowUserToDeleteRows = false;
            this.requestGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requestGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.requestGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.requestGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.requestGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestGridView.GridColor = System.Drawing.Color.DarkGray;
            this.requestGridView.Location = new System.Drawing.Point(3, 39);
            this.requestGridView.MultiSelect = false;
            this.requestGridView.Name = "requestGridView";
            this.requestGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.requestGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.requestGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Lavender;
            this.requestGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Menu;
            this.requestGridView.Size = new System.Drawing.Size(869, 439);
            this.requestGridView.TabIndex = 1;
            this.requestGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestTable_CellClick);
            this.requestGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestGridView_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportChart);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(875, 481);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Item Usage for last three (3) Mnths";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportChart
            // 
            this.reportChart.BackSecondaryColor = System.Drawing.Color.White;
            this.reportChart.BorderlineColor = System.Drawing.Color.Empty;
            chartArea1.Name = "ChartArea1";
            this.reportChart.ChartAreas.Add(chartArea1);
            this.reportChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.reportChart.Legends.Add(legend1);
            this.reportChart.Location = new System.Drawing.Point(3, 3);
            this.reportChart.Name = "reportChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.reportChart.Series.Add(series1);
            this.reportChart.Size = new System.Drawing.Size(869, 475);
            this.reportChart.SuppressExceptions = true;
            this.reportChart.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(875, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Items";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.TabPage2Enter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList2;
            this.button1.Location = new System.Drawing.Point(721, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Export to excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.Size = new System.Drawing.Size(869, 430);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(875, 481);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Suppliers\' Info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView3.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView3.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView3.Size = new System.Drawing.Size(869, 475);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.activityExportBtn);
            this.tabPage5.Controls.Add(this.activityDatagrid);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(875, 481);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Activity Log";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // activityExportBtn
            // 
            this.activityExportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activityExportBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.activityExportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.activityExportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activityExportBtn.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.activityExportBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.activityExportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activityExportBtn.ImageIndex = 0;
            this.activityExportBtn.ImageList = this.imageList2;
            this.activityExportBtn.Location = new System.Drawing.Point(712, 4);
            this.activityExportBtn.Name = "activityExportBtn";
            this.activityExportBtn.Size = new System.Drawing.Size(160, 31);
            this.activityExportBtn.TabIndex = 5;
            this.activityExportBtn.Text = "Export to excel";
            this.activityExportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.activityExportBtn.UseVisualStyleBackColor = false;
            this.activityExportBtn.Click += new System.EventHandler(this.activityExportBtn_Click);
            // 
            // activityDatagrid
            // 
            this.activityDatagrid.AllowUserToAddRows = false;
            this.activityDatagrid.AllowUserToDeleteRows = false;
            this.activityDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activityDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activityDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.activityDatagrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.activityDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityDatagrid.Location = new System.Drawing.Point(0, 40);
            this.activityDatagrid.Name = "activityDatagrid";
            this.activityDatagrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activityDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.activityDatagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.activityDatagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityDatagrid.Size = new System.Drawing.Size(875, 433);
            this.activityDatagrid.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1438207582_Recycle_Bin_-_empty.png");
            this.imageList1.Images.SetKeyName(1, "Aha-Soft-Standard-Portfolio-Inventory.ico");
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.TableName = "Table1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.linkLabel1.Location = new System.Drawing.Point(857, 4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 25);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.receivablePic);
            this.panel2.Controls.Add(this.editItem);
            this.panel2.Controls.Add(this.addPicbx);
            this.panel2.Controls.Add(this.about);
            this.panel2.Controls.Add(this.CreateUserPic);
            this.panel2.Controls.Add(this.updatePic);
            this.panel2.Controls.Add(this.DeletePic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 545);
            this.panel2.TabIndex = 1;
            this.ToolTips.SetToolTip(this.panel2, "Quick access toolbar");
            // 
            // receivablePic
            // 
            this.receivablePic.Image = global::Inventory_System.Resource1._1438216260_icon_105_folder_add;
            this.receivablePic.Location = new System.Drawing.Point(8, 55);
            this.receivablePic.Name = "receivablePic";
            this.receivablePic.Size = new System.Drawing.Size(33, 28);
            this.receivablePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.receivablePic.TabIndex = 14;
            this.receivablePic.TabStop = false;
            this.ToolTips.SetToolTip(this.receivablePic, "Receivables");
            this.receivablePic.Click += new System.EventHandler(this.ReceivablePicClick);
            this.receivablePic.MouseEnter += new System.EventHandler(this.ReceivablePicMouseEnter);
            this.receivablePic.MouseLeave += new System.EventHandler(this.ReceivablePicMouseLeave);
            // 
            // editItem
            // 
            this.editItem.Image = global::Inventory_System.Resource1._1438215397_edit_find_replace;
            this.editItem.Location = new System.Drawing.Point(8, 186);
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(33, 28);
            this.editItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editItem.TabIndex = 13;
            this.editItem.TabStop = false;
            this.ToolTips.SetToolTip(this.editItem, "Edit item in inventory");
            this.editItem.Click += new System.EventHandler(this.PictureBox2Click);
            this.editItem.MouseEnter += new System.EventHandler(this.EditItemMouseEnter);
            this.editItem.MouseLeave += new System.EventHandler(this.EditItemMouseLeave);
            // 
            // addPicbx
            // 
            this.addPicbx.BackColor = System.Drawing.Color.Transparent;
            this.addPicbx.Image = global::Inventory_System.Resource1._1438216279_icon_81_document_add;
            this.addPicbx.Location = new System.Drawing.Point(8, 9);
            this.addPicbx.Name = "addPicbx";
            this.addPicbx.Size = new System.Drawing.Size(33, 28);
            this.addPicbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addPicbx.TabIndex = 12;
            this.addPicbx.TabStop = false;
            this.ToolTips.SetToolTip(this.addPicbx, "Add new item");
            this.addPicbx.Click += new System.EventHandler(this.PictureBox1Click);
            this.addPicbx.MouseEnter += new System.EventHandler(this.PictureBox1MouseEnter);
            this.addPicbx.MouseLeave += new System.EventHandler(this.PictureBox1MouseLeave);
            // 
            // about
            // 
            this.about.Image = global::Inventory_System.Resource1._1438206491_Information;
            this.about.Location = new System.Drawing.Point(8, 277);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(33, 28);
            this.about.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.about.TabIndex = 11;
            this.about.TabStop = false;
            this.ToolTips.SetToolTip(this.about, "About");
            this.about.Click += new System.EventHandler(this.AboutClick);
            this.about.MouseEnter += new System.EventHandler(this.AboutMouseEnter);
            this.about.MouseLeave += new System.EventHandler(this.AboutMouseLeave);
            // 
            // CreateUserPic
            // 
            this.CreateUserPic.Image = global::Inventory_System.Resource1._1438206747_user_group_new;
            this.CreateUserPic.Location = new System.Drawing.Point(8, 230);
            this.CreateUserPic.Name = "CreateUserPic";
            this.CreateUserPic.Size = new System.Drawing.Size(33, 28);
            this.CreateUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CreateUserPic.TabIndex = 10;
            this.CreateUserPic.TabStop = false;
            this.ToolTips.SetToolTip(this.CreateUserPic, "Create new user");
            this.CreateUserPic.Click += new System.EventHandler(this.CreateUserPicClick);
            this.CreateUserPic.MouseEnter += new System.EventHandler(this.CreateUserPicMouseEnter);
            this.CreateUserPic.MouseLeave += new System.EventHandler(this.CreateUserPicMouseLeave);
            // 
            // updatePic
            // 
            this.updatePic.Image = global::Inventory_System.Resource1._1438206541_Stock_Index_Up;
            this.updatePic.Location = new System.Drawing.Point(8, 99);
            this.updatePic.Name = "updatePic";
            this.updatePic.Size = new System.Drawing.Size(33, 28);
            this.updatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updatePic.TabIndex = 9;
            this.updatePic.TabStop = false;
            this.ToolTips.SetToolTip(this.updatePic, "Update item in inventory");
            this.updatePic.Click += new System.EventHandler(this.UpdatePicClick);
            this.updatePic.MouseEnter += new System.EventHandler(this.UpdatePicMouseEnter);
            this.updatePic.MouseLeave += new System.EventHandler(this.UpdatePicMouseLeave);
            // 
            // DeletePic
            // 
            this.DeletePic.Image = global::Inventory_System.Resource1._1438207582_Recycle_Bin___empty;
            this.DeletePic.Location = new System.Drawing.Point(8, 142);
            this.DeletePic.Name = "DeletePic";
            this.DeletePic.Size = new System.Drawing.Size(33, 28);
            this.DeletePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeletePic.TabIndex = 8;
            this.DeletePic.TabStop = false;
            this.ToolTips.SetToolTip(this.DeletePic, "Delete item form inventory");
            this.DeletePic.Click += new System.EventHandler(this.DeletePicClick);
            this.DeletePic.MouseEnter += new System.EventHandler(this.DeletePicMouseEnter);
            this.DeletePic.MouseLeave += new System.EventHandler(this.DeletePicMouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.uptodatePic);
            this.panel1.Controls.Add(this.uptodatePic2);
            this.panel1.Controls.Add(this.statusLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(49, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 36);
            this.panel1.TabIndex = 15;
            // 
            // uptodatePic
            // 
            this.uptodatePic.Image = global::Inventory_System.Resource1._1438228058_face_smile_big;
            this.uptodatePic.Location = new System.Drawing.Point(282, 0);
            this.uptodatePic.Name = "uptodatePic";
            this.uptodatePic.Size = new System.Drawing.Size(42, 36);
            this.uptodatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uptodatePic.TabIndex = 16;
            this.uptodatePic.TabStop = false;
            this.uptodatePic.Visible = false;
            this.uptodatePic.MouseEnter += new System.EventHandler(this.UptodatePicMouseEnter);
            this.uptodatePic.MouseLeave += new System.EventHandler(this.UptodatePicMouseLeave);
            // 
            // uptodatePic2
            // 
            this.uptodatePic2.Image = global::Inventory_System.Resource1._1438228058_face_smile_big;
            this.uptodatePic2.Location = new System.Drawing.Point(358, 1);
            this.uptodatePic2.Name = "uptodatePic2";
            this.uptodatePic2.Size = new System.Drawing.Size(40, 35);
            this.uptodatePic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uptodatePic2.TabIndex = 11;
            this.uptodatePic2.TabStop = false;
            this.uptodatePic2.Visible = false;
            this.uptodatePic2.MouseEnter += new System.EventHandler(this.UptodatePic2MouseEnter);
            this.uptodatePic2.MouseLeave += new System.EventHandler(this.UptodatePic2MouseLeave);
            // 
            // statusLbl
            // 
            this.statusLbl.BackColor = System.Drawing.Color.Transparent;
            this.statusLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statusLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.statusLbl.Location = new System.Drawing.Point(133, 9);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(327, 18);
            this.statusLbl.TabIndex = 9;
            this.statusLbl.Text = "Inventory is up to date ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Overall Status :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(930, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::Inventory_System.Resource1.Aha_Soft_Standard_Portfolio_Inventory;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(946, 612);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " CIMS - Consumables Inventory Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activityDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receivablePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPicbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.about)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateUserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePic)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uptodatePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uptodatePic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.ToolStripMenuItem receivableLogsToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.PictureBox receivablePic;
		private System.Windows.Forms.ToolStripMenuItem exportItemListAsPDFToolStripMenuItem;
		private System.Windows.Forms.PictureBox uptodatePic2;
		private System.Windows.Forms.PictureBox uptodatePic;
		private System.Windows.Forms.ToolTip ToolTips;
		private System.Windows.Forms.PictureBox editItem;
		private System.Windows.Forms.PictureBox updatePic;
		private System.Windows.Forms.PictureBox DeletePic;
		private System.Windows.Forms.PictureBox about;
		private System.Windows.Forms.PictureBox CreateUserPic;
		private System.Windows.Forms.PictureBox addPicbx;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.ToolStripMenuItem createOrEditExistingUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStrip;
		private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem updateItemQuantityToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label statusLbl;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStripMenuItem transactionLogsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Data.DataTable dataTable1;
		private System.Data.DataSet dataSet1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ToolStripMenuItem addNewItemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addReceivablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSupplierToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart reportChart;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView activityDatagrid;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button activityExportBtn;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView requestGridView;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button requestDialogBtn;
    }
}
