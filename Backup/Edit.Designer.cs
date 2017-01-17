/*
 * Created by SharpDevelop.
 * User: Vstudent
 * Date: 7/22/2015
 * Time: 4:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class Edit
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.ItemlistBox = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.errorlb1 = new System.Windows.Forms.Label();
			this.errorlb = new System.Windows.Forms.Label();
			this.unitCmbBox = new System.Windows.Forms.ComboBox();
			this.errlbl1 = new System.Windows.Forms.Label();
			this.saveQuantityBtn = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.ReorderTxtBx = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.initialQuantityTxtBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.SaveBasicBtn = new System.Windows.Forms.Button();
			this.errLb2 = new System.Windows.Forms.Label();
			this.itemNameTxtbox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.itemDescriptionTxtBox = new System.Windows.Forms.TextBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(489, 383);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.ItemlistBox);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(157, 384);
			this.panel2.TabIndex = 33;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(34, 25);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 21);
			this.label7.TabIndex = 30;
			this.label7.Text = "Item List";
			// 
			// ItemlistBox
			// 
			this.ItemlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemlistBox.FormattingEnabled = true;
			this.ItemlistBox.ItemHeight = 18;
			this.ItemlistBox.Location = new System.Drawing.Point(4, 50);
			this.ItemlistBox.Name = "ItemlistBox";
			this.ItemlistBox.Size = new System.Drawing.Size(149, 328);
			this.ItemlistBox.TabIndex = 0;
			this.ItemlistBox.SelectedIndexChanged += new System.EventHandler(this.ItemlistBoxSelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox2.Controls.Add(this.errorlb1);
			this.groupBox2.Controls.Add(this.errorlb);
			this.groupBox2.Controls.Add(this.unitCmbBox);
			this.groupBox2.Controls.Add(this.errlbl1);
			this.groupBox2.Controls.Add(this.saveQuantityBtn);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.ReorderTxtBx);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.initialQuantityTxtBox);
			this.groupBox2.Location = new System.Drawing.Point(163, 204);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(326, 180);
			this.groupBox2.TabIndex = 31;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Quantity Information";
			// 
			// errorlb1
			// 
			this.errorlb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorlb1.ForeColor = System.Drawing.Color.Red;
			this.errorlb1.Location = new System.Drawing.Point(217, 91);
			this.errorlb1.Name = "errorlb1";
			this.errorlb1.Size = new System.Drawing.Size(10, 23);
			this.errorlb1.TabIndex = 43;
			this.errorlb1.Text = "!";
			this.errorlb1.Visible = false;
			// 
			// errorlb
			// 
			this.errorlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorlb.ForeColor = System.Drawing.Color.Red;
			this.errorlb.Location = new System.Drawing.Point(219, 39);
			this.errorlb.Name = "errorlb";
			this.errorlb.Size = new System.Drawing.Size(10, 23);
			this.errorlb.TabIndex = 42;
			this.errorlb.Text = "!";
			this.errorlb.Visible = false;
			// 
			// unitCmbBox
			// 
			this.unitCmbBox.FormattingEnabled = true;
			this.unitCmbBox.Location = new System.Drawing.Point(161, 65);
			this.unitCmbBox.Name = "unitCmbBox";
			this.unitCmbBox.Size = new System.Drawing.Size(76, 21);
			this.unitCmbBox.TabIndex = 7;
			// 
			// errlbl1
			// 
			this.errlbl1.ForeColor = System.Drawing.Color.Red;
			this.errlbl1.Location = new System.Drawing.Point(201, 129);
			this.errlbl1.Name = "errlbl1";
			this.errlbl1.Size = new System.Drawing.Size(125, 17);
			this.errlbl1.TabIndex = 40;
			this.errlbl1.Text = "*Fields cannot be empty";
			this.errlbl1.Visible = false;
			// 
			// saveQuantityBtn
			// 
			this.saveQuantityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveQuantityBtn.Location = new System.Drawing.Point(224, 149);
			this.saveQuantityBtn.Name = "saveQuantityBtn";
			this.saveQuantityBtn.Size = new System.Drawing.Size(92, 25);
			this.saveQuantityBtn.TabIndex = 9;
			this.saveQuantityBtn.Text = "Save Changes";
			this.saveQuantityBtn.UseVisualStyleBackColor = true;
			this.saveQuantityBtn.Click += new System.EventHandler(this.SaveQuantityBtnClick);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Location = new System.Drawing.Point(117, 66);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 15);
			this.label6.TabIndex = 33;
			this.label6.Text = "Unit";
			// 
			// ReorderTxtBx
			// 
			this.ReorderTxtBx.Location = new System.Drawing.Point(162, 92);
			this.ReorderTxtBx.Name = "ReorderTxtBx";
			this.ReorderTxtBx.Size = new System.Drawing.Size(54, 20);
			this.ReorderTxtBx.TabIndex = 8;
			this.ReorderTxtBx.Leave += new System.EventHandler(this.ReorderTxtBxLeave);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(53, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 23);
			this.label3.TabIndex = 30;
			this.label3.Text = "Reorder Level";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(92, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 23);
			this.label4.TabIndex = 29;
			this.label4.Text = "Quantity";
			// 
			// initialQuantityTxtBox
			// 
			this.initialQuantityTxtBox.Location = new System.Drawing.Point(161, 39);
			this.initialQuantityTxtBox.Name = "initialQuantityTxtBox";
			this.initialQuantityTxtBox.Size = new System.Drawing.Size(56, 20);
			this.initialQuantityTxtBox.TabIndex = 5;
			this.initialQuantityTxtBox.Leave += new System.EventHandler(this.InitialQuantityTxtBoxLeave);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.SaveBasicBtn);
			this.groupBox1.Controls.Add(this.errLb2);
			this.groupBox1.Controls.Add(this.itemNameTxtbox);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.itemDescriptionTxtBox);
			this.groupBox1.Location = new System.Drawing.Point(163, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(326, 196);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Item Information";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label8.Location = new System.Drawing.Point(11, 134);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 19);
			this.label8.TabIndex = 43;
			this.label8.Text = "Status";
			// 
			// SaveBasicBtn
			// 
			this.SaveBasicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveBasicBtn.Location = new System.Drawing.Point(219, 161);
			this.SaveBasicBtn.Name = "SaveBasicBtn";
			this.SaveBasicBtn.Size = new System.Drawing.Size(92, 25);
			this.SaveBasicBtn.TabIndex = 4;
			this.SaveBasicBtn.Text = "Save Changes";
			this.SaveBasicBtn.UseVisualStyleBackColor = true;
			this.SaveBasicBtn.Click += new System.EventHandler(this.SaveBasicBtnClick);
			// 
			// errLb2
			// 
			this.errLb2.ForeColor = System.Drawing.Color.Red;
			this.errLb2.Location = new System.Drawing.Point(201, 141);
			this.errLb2.Name = "errLb2";
			this.errLb2.Size = new System.Drawing.Size(125, 17);
			this.errLb2.TabIndex = 41;
			this.errLb2.Text = "*Fields cannot be empty";
			this.errLb2.Visible = false;
			// 
			// itemNameTxtbox
			// 
			this.itemNameTxtbox.Location = new System.Drawing.Point(100, 32);
			this.itemNameTxtbox.Name = "itemNameTxtbox";
			this.itemNameTxtbox.Size = new System.Drawing.Size(117, 20);
			this.itemNameTxtbox.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label5.Location = new System.Drawing.Point(115, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 23);
			this.label5.TabIndex = 36;
			this.label5.Text = "Item Name";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 19);
			this.label2.TabIndex = 35;
			this.label2.Text = "Item Description";
			// 
			// itemDescriptionTxtBox
			// 
			this.itemDescriptionTxtBox.Location = new System.Drawing.Point(11, 78);
			this.itemDescriptionTxtBox.Multiline = true;
			this.itemDescriptionTxtBox.Name = "itemDescriptionTxtBox";
			this.itemDescriptionTxtBox.Size = new System.Drawing.Size(308, 53);
			this.itemDescriptionTxtBox.TabIndex = 3;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(12, 156);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(62, 24);
			this.radioButton1.TabIndex = 45;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Active";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(80, 156);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 46;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Inactive";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// Edit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(489, 383);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Edit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditFormClosed);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label errorlb1;
		private System.Windows.Forms.Label errorlb;
		private System.Windows.Forms.ComboBox unitCmbBox;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label errLb2;
		private System.Windows.Forms.Label errlbl1;
		private System.Windows.Forms.Button saveQuantityBtn;
		private System.Windows.Forms.Button SaveBasicBtn;
		private System.Windows.Forms.TextBox itemDescriptionTxtBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox itemNameTxtbox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox initialQuantityTxtBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ReorderTxtBx;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListBox ItemlistBox;
		private System.Windows.Forms.Panel panel1;
	}
}
