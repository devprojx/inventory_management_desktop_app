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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.transactionLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportItemListAsPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.receivableLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addItemRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateItemQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createOrEditExistingUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.dataSet1 = new System.Data.DataSet();
			this.dataTable1 = new System.Data.DataTable();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.receivablePic = new System.Windows.Forms.PictureBox();
			this.editItem = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.about = new System.Windows.Forms.PictureBox();
			this.CreateUserPic = new System.Windows.Forms.PictureBox();
			this.updatePic = new System.Windows.Forms.PictureBox();
			this.DeletePic = new System.Windows.Forms.PictureBox();
			this.LogRequestPic = new System.Windows.Forms.PictureBox();
			this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
			this.panel3 = new System.Windows.Forms.Panel();
			this.result = new System.Windows.Forms.Label();
			this.countLb = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.uptodatePic = new System.Windows.Forms.PictureBox();
			this.uptodatePic2 = new System.Windows.Forms.PictureBox();
			this.statusLbl = new System.Windows.Forms.Label();
			this.binkLbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.receivablePic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.editItem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.about)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CreateUserPic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.updatePic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DeletePic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LogRequestPic)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uptodatePic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uptodatePic2)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.viewToolStripMenuItem,
									this.optionsToolStripMenuItem,
									this.reportsToolStripMenuItem,
									this.createOrEditExistingUserToolStripMenuItem,
									this.aboutToolStrip});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(642, 25);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.TabStop = true;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.transactionLogsToolStripMenuItem,
									this.receivableLogsToolStripMenuItem,
									this.exportItemListAsPDFToolStripMenuItem});
			this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
			this.viewToolStripMenuItem.Text = "View Logs";
			// 
			// transactionLogsToolStripMenuItem
			// 
			this.transactionLogsToolStripMenuItem.Name = "transactionLogsToolStripMenuItem";
			this.transactionLogsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.transactionLogsToolStripMenuItem.Text = "Transaction Logs";
			this.transactionLogsToolStripMenuItem.Click += new System.EventHandler(this.TransactionLogsToolStripMenuItemClick);
			// 
			// exportItemListAsPDFToolStripMenuItem
			// 
			this.exportItemListAsPDFToolStripMenuItem.Name = "exportItemListAsPDFToolStripMenuItem";
			this.exportItemListAsPDFToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.exportItemListAsPDFToolStripMenuItem.Text = "Export Item List As PDF";
			this.exportItemListAsPDFToolStripMenuItem.Click += new System.EventHandler(this.ExportItemListAsPDFToolStripMenuItemClick);
			// 
			// receivableLogsToolStripMenuItem
			// 
			this.receivableLogsToolStripMenuItem.Name = "receivableLogsToolStripMenuItem";
			this.receivableLogsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.receivableLogsToolStripMenuItem.Text = "Receivable Logs";
			this.receivableLogsToolStripMenuItem.Click += new System.EventHandler(this.ReceivableLogsToolStripMenuItemClick);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.addNewItemToolStripMenuItem,
									this.addItemRequestToolStripMenuItem,
									this.updateItemQuantityToolStripMenuItem,
									this.editItemToolStripMenuItem,
									this.deleteItemToolStripMenuItem});
			this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// addNewItemToolStripMenuItem
			// 
			this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
			this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.addNewItemToolStripMenuItem.Text = "Add New Item";
			this.addNewItemToolStripMenuItem.Click += new System.EventHandler(this.AddNewItemToolStripMenuItemClick);
			// 
			// addItemRequestToolStripMenuItem
			// 
			this.addItemRequestToolStripMenuItem.Name = "addItemRequestToolStripMenuItem";
			this.addItemRequestToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.addItemRequestToolStripMenuItem.Text = "Add Item Request";
			this.addItemRequestToolStripMenuItem.Click += new System.EventHandler(this.AddItemRequestToolStripMenuItemClick);
			// 
			// updateItemQuantityToolStripMenuItem
			// 
			this.updateItemQuantityToolStripMenuItem.Name = "updateItemQuantityToolStripMenuItem";
			this.updateItemQuantityToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.updateItemQuantityToolStripMenuItem.Text = "Update Item Quantity";
			this.updateItemQuantityToolStripMenuItem.Click += new System.EventHandler(this.UpdateItemQuantityToolStripMenuItemClick);
			// 
			// editItemToolStripMenuItem
			// 
			this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
			this.editItemToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.editItemToolStripMenuItem.Text = "Edit Item";
			this.editItemToolStripMenuItem.Click += new System.EventHandler(this.EditItemToolStripMenuItemClick);
			// 
			// deleteItemToolStripMenuItem
			// 
			this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
			this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.deleteItemToolStripMenuItem.Text = "Delete Item";
			this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.DeleteItemToolStripMenuItemClick);
			// 
			// reportsToolStripMenuItem
			// 
			this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
			this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.reportsToolStripMenuItem.Text = "Reports";
			this.reportsToolStripMenuItem.Click += new System.EventHandler(this.ReportsToolStripMenuItemClick);
			// 
			// createOrEditExistingUserToolStripMenuItem
			// 
			this.createOrEditExistingUserToolStripMenuItem.Name = "createOrEditExistingUserToolStripMenuItem";
			this.createOrEditExistingUserToolStripMenuItem.Size = new System.Drawing.Size(158, 21);
			this.createOrEditExistingUserToolStripMenuItem.Text = "Create or edit existing user";
			this.createOrEditExistingUserToolStripMenuItem.Click += new System.EventHandler(this.CreateOrEditExistingUserToolStripMenuItemClick);
			// 
			// aboutToolStrip
			// 
			this.aboutToolStrip.Name = "aboutToolStrip";
			this.aboutToolStrip.Size = new System.Drawing.Size(52, 21);
			this.aboutToolStrip.Text = "About";
			this.aboutToolStrip.Click += new System.EventHandler(this.AboutToolStripClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.HotTrack = true;
			this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.tabControl1.Location = new System.Drawing.Point(48, 60);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(595, 372);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage1.Location = new System.Drawing.Point(4, 26);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(587, 342);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Notifications";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
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
			this.dataGridView1.Size = new System.Drawing.Size(581, 336);
			this.dataGridView1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage2.Location = new System.Drawing.Point(4, 26);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(587, 342);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Item Status";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.tabPage2.Enter += new System.EventHandler(this.TabPage2Enter);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(3, 3);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
			this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView2.Size = new System.Drawing.Size(581, 336);
			this.dataGridView2.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dataGridView3);
			this.tabPage3.Location = new System.Drawing.Point(4, 26);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(587, 342);
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
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSeaGreen;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView3.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.dataGridView3.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dataGridView3.Size = new System.Drawing.Size(581, 336);
			this.dataGridView3.TabIndex = 1;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "1438207582_Recycle_Bin_-_empty.png");
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
			this.linkLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
			this.linkLabel1.Location = new System.Drawing.Point(578, 5);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(65, 15);
			this.linkLabel1.TabIndex = 5;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Log out";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.BackColor = System.Drawing.Color.Honeydew;
			this.panel2.Controls.Add(this.receivablePic);
			this.panel2.Controls.Add(this.editItem);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.about);
			this.panel2.Controls.Add(this.CreateUserPic);
			this.panel2.Controls.Add(this.updatePic);
			this.panel2.Controls.Add(this.DeletePic);
			this.panel2.Controls.Add(this.LogRequestPic);
			this.panel2.Location = new System.Drawing.Point(0, 61);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(49, 381);
			this.panel2.TabIndex = 1;
			this.ToolTips.SetToolTip(this.panel2, "Quick access toolbar");
			// 
			// receivablePic
			// 
			this.receivablePic.Image = global::Inventory_System.Resource1._1438206469_Add;
			this.receivablePic.Location = new System.Drawing.Point(8, 55);
			this.receivablePic.Name = "receivablePic";
			this.receivablePic.Size = new System.Drawing.Size(33, 28);
			this.receivablePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.receivablePic.TabIndex = 14;
			this.receivablePic.TabStop = false;
			this.ToolTips.SetToolTip(this.receivablePic, "About");
			this.receivablePic.MouseLeave += new System.EventHandler(this.ReceivablePicMouseLeave);
			this.receivablePic.Click += new System.EventHandler(this.ReceivablePicClick);
			this.receivablePic.MouseEnter += new System.EventHandler(this.ReceivablePicMouseEnter);
			// 
			// editItem
			// 
			this.editItem.Image = global::Inventory_System.Resource1._1438215397_edit_find_replace;
			this.editItem.Location = new System.Drawing.Point(8, 235);
			this.editItem.Name = "editItem";
			this.editItem.Size = new System.Drawing.Size(33, 28);
			this.editItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.editItem.TabIndex = 13;
			this.editItem.TabStop = false;
			this.ToolTips.SetToolTip(this.editItem, "Edit item in inventory");
			this.editItem.MouseLeave += new System.EventHandler(this.EditItemMouseLeave);
			this.editItem.Click += new System.EventHandler(this.PictureBox2Click);
			this.editItem.MouseEnter += new System.EventHandler(this.EditItemMouseEnter);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::Inventory_System.Resource1._1438216279_icon_81_document_add;
			this.pictureBox1.Location = new System.Drawing.Point(8, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(33, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			this.ToolTips.SetToolTip(this.pictureBox1, "Add new item");
			this.pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox1MouseLeave);
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			this.pictureBox1.MouseEnter += new System.EventHandler(this.PictureBox1MouseEnter);
			// 
			// about
			// 
			this.about.Image = global::Inventory_System.Resource1._1438206491_Information;
			this.about.Location = new System.Drawing.Point(8, 328);
			this.about.Name = "about";
			this.about.Size = new System.Drawing.Size(33, 28);
			this.about.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.about.TabIndex = 11;
			this.about.TabStop = false;
			this.ToolTips.SetToolTip(this.about, "About");
			this.about.MouseLeave += new System.EventHandler(this.AboutMouseLeave);
			this.about.Click += new System.EventHandler(this.AboutClick);
			this.about.MouseEnter += new System.EventHandler(this.AboutMouseEnter);
			// 
			// CreateUserPic
			// 
			this.CreateUserPic.Image = global::Inventory_System.Resource1._1438206747_user_group_new;
			this.CreateUserPic.Location = new System.Drawing.Point(8, 281);
			this.CreateUserPic.Name = "CreateUserPic";
			this.CreateUserPic.Size = new System.Drawing.Size(33, 28);
			this.CreateUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CreateUserPic.TabIndex = 10;
			this.CreateUserPic.TabStop = false;
			this.ToolTips.SetToolTip(this.CreateUserPic, "Create new user");
			this.CreateUserPic.MouseLeave += new System.EventHandler(this.CreateUserPicMouseLeave);
			this.CreateUserPic.Click += new System.EventHandler(this.CreateUserPicClick);
			this.CreateUserPic.MouseEnter += new System.EventHandler(this.CreateUserPicMouseEnter);
			// 
			// updatePic
			// 
			this.updatePic.Image = global::Inventory_System.Resource1._1438206541_Stock_Index_Up;
			this.updatePic.Location = new System.Drawing.Point(8, 145);
			this.updatePic.Name = "updatePic";
			this.updatePic.Size = new System.Drawing.Size(33, 28);
			this.updatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.updatePic.TabIndex = 9;
			this.updatePic.TabStop = false;
			this.ToolTips.SetToolTip(this.updatePic, "Update item in inventory");
			this.updatePic.MouseLeave += new System.EventHandler(this.UpdatePicMouseLeave);
			this.updatePic.Click += new System.EventHandler(this.UpdatePicClick);
			this.updatePic.MouseEnter += new System.EventHandler(this.UpdatePicMouseEnter);
			// 
			// DeletePic
			// 
			this.DeletePic.Image = global::Inventory_System.Resource1._1438207582_Recycle_Bin___empty;
			this.DeletePic.Location = new System.Drawing.Point(8, 190);
			this.DeletePic.Name = "DeletePic";
			this.DeletePic.Size = new System.Drawing.Size(33, 28);
			this.DeletePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DeletePic.TabIndex = 8;
			this.DeletePic.TabStop = false;
			this.ToolTips.SetToolTip(this.DeletePic, "Delete item form inventory");
			this.DeletePic.MouseLeave += new System.EventHandler(this.DeletePicMouseLeave);
			this.DeletePic.Click += new System.EventHandler(this.DeletePicClick);
			this.DeletePic.MouseEnter += new System.EventHandler(this.DeletePicMouseEnter);
			// 
			// LogRequestPic
			// 
			this.LogRequestPic.Image = global::Inventory_System.Resource1._1438206555_Edit;
			this.LogRequestPic.Location = new System.Drawing.Point(8, 99);
			this.LogRequestPic.Name = "LogRequestPic";
			this.LogRequestPic.Size = new System.Drawing.Size(33, 28);
			this.LogRequestPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.LogRequestPic.TabIndex = 7;
			this.LogRequestPic.TabStop = false;
			this.ToolTips.SetToolTip(this.LogRequestPic, "Log Request");
			this.LogRequestPic.MouseLeave += new System.EventHandler(this.LogRequestPicMouseLeave);
			this.LogRequestPic.Click += new System.EventHandler(this.LogRequestPicClick);
			this.LogRequestPic.MouseEnter += new System.EventHandler(this.LogRequestPicMouseEnter);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.result);
			this.panel3.Controls.Add(this.countLb);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 430);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(642, 26);
			this.panel3.TabIndex = 14;
			// 
			// result
			// 
			this.result.Location = new System.Drawing.Point(126, 6);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(60, 17);
			this.result.TabIndex = 1;
			// 
			// countLb
			// 
			this.countLb.Location = new System.Drawing.Point(0, 5);
			this.countLb.Name = "countLb";
			this.countLb.Size = new System.Drawing.Size(147, 13);
			this.countLb.TabIndex = 0;
			this.countLb.Text = "No. Of Items in Inventory: ";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1.Controls.Add(this.uptodatePic);
			this.panel1.Controls.Add(this.uptodatePic2);
			this.panel1.Controls.Add(this.statusLbl);
			this.panel1.Controls.Add(this.binkLbl);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(1, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(642, 36);
			this.panel1.TabIndex = 15;
			// 
			// uptodatePic
			// 
			this.uptodatePic.Image = global::Inventory_System.Resource1._1438228058_face_smile_big;
			this.uptodatePic.Location = new System.Drawing.Point(273, 0);
			this.uptodatePic.Name = "uptodatePic";
			this.uptodatePic.Size = new System.Drawing.Size(42, 36);
			this.uptodatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.uptodatePic.TabIndex = 16;
			this.uptodatePic.TabStop = false;
			this.uptodatePic.MouseLeave += new System.EventHandler(this.UptodatePicMouseLeave);
			this.uptodatePic.MouseEnter += new System.EventHandler(this.UptodatePicMouseEnter);
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
			this.uptodatePic2.MouseLeave += new System.EventHandler(this.UptodatePic2MouseLeave);
			this.uptodatePic2.MouseEnter += new System.EventHandler(this.UptodatePic2MouseEnter);
			// 
			// statusLbl
			// 
			this.statusLbl.BackColor = System.Drawing.Color.Transparent;
			this.statusLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.statusLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusLbl.ForeColor = System.Drawing.Color.LimeGreen;
			this.statusLbl.Location = new System.Drawing.Point(126, 7);
			this.statusLbl.Name = "statusLbl";
			this.statusLbl.Size = new System.Drawing.Size(327, 18);
			this.statusLbl.TabIndex = 9;
			this.statusLbl.Text = "Inventory is up to date ";
			// 
			// binkLbl
			// 
			this.binkLbl.BackColor = System.Drawing.Color.Transparent;
			this.binkLbl.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.binkLbl.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.binkLbl.Location = new System.Drawing.Point(110, 7);
			this.binkLbl.Name = "binkLbl";
			this.binkLbl.Size = new System.Drawing.Size(29, 22);
			this.binkLbl.TabIndex = 8;
			this.binkLbl.Text = "->";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label1.Location = new System.Drawing.Point(5, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Overall Status";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuBar;
			this.ClientSize = new System.Drawing.Size(642, 456);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = global::Inventory_System.Resource1.Aha_Soft_Standard_Portfolio_Inventory;
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(648, 444);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.receivablePic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.editItem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.about)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CreateUserPic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.updatePic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DeletePic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LogRequestPic)).EndInit();
			this.panel3.ResumeLayout(false);
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
		private System.Windows.Forms.Label result;
		private System.Windows.Forms.Label countLb;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox uptodatePic2;
		private System.Windows.Forms.PictureBox uptodatePic;
		private System.Windows.Forms.ToolTip ToolTips;
		private System.Windows.Forms.PictureBox editItem;
		private System.Windows.Forms.PictureBox updatePic;
		private System.Windows.Forms.PictureBox DeletePic;
		private System.Windows.Forms.PictureBox LogRequestPic;
		private System.Windows.Forms.PictureBox about;
		private System.Windows.Forms.PictureBox CreateUserPic;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.ToolStripMenuItem createOrEditExistingUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStrip;
		private System.Windows.Forms.Label binkLbl;
		private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem updateItemQuantityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addItemRequestToolStripMenuItem;
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
		
	}
}
