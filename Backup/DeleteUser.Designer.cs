/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 26/07/2015
 * Time: 10:11 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class DeleteUser
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.errorlb2 = new System.Windows.Forms.Label();
			this.errelb = new System.Windows.Forms.Label();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.usernameCmbBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.passwordTxtBox = new System.Windows.Forms.MaskedTextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.statusStrip1);
			this.panel1.Controls.Add(this.errorlb2);
			this.panel1.Controls.Add(this.errelb);
			this.panel1.Controls.Add(this.deleteBtn);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.usernameCmbBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.passwordTxtBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(263, 165);
			this.panel1.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 143);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(263, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// errorlb2
			// 
			this.errorlb2.ForeColor = System.Drawing.Color.Red;
			this.errorlb2.Location = new System.Drawing.Point(113, 96);
			this.errorlb2.Name = "errorlb2";
			this.errorlb2.Size = new System.Drawing.Size(113, 14);
			this.errorlb2.TabIndex = 6;
			this.errorlb2.Text = "*Password is incorrect";
			this.errorlb2.Visible = false;
			// 
			// errelb
			// 
			this.errelb.ForeColor = System.Drawing.Color.Red;
			this.errelb.Location = new System.Drawing.Point(50, 9);
			this.errelb.Name = "errelb";
			this.errelb.Size = new System.Drawing.Size(202, 14);
			this.errelb.TabIndex = 5;
			this.errelb.Text = "*Username or password cannot be empty";
			this.errelb.Visible = false;
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(100, 112);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(75, 23);
			this.deleteBtn.TabIndex = 4;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.DeleteBtnClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Enter Password";
			// 
			// usernameCmbBox
			// 
			this.usernameCmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.usernameCmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.usernameCmbBox.FormattingEnabled = true;
			this.usernameCmbBox.Location = new System.Drawing.Point(113, 39);
			this.usernameCmbBox.Name = "usernameCmbBox";
			this.usernameCmbBox.Size = new System.Drawing.Size(104, 21);
			this.usernameCmbBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Username";
			// 
			// passwordTxtBox
			// 
			this.passwordTxtBox.Location = new System.Drawing.Point(113, 73);
			this.passwordTxtBox.Name = "passwordTxtBox";
			this.passwordTxtBox.PasswordChar = '•';
			this.passwordTxtBox.Size = new System.Drawing.Size(121, 20);
			this.passwordTxtBox.TabIndex = 0;
			// 
			// DeleteUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 165);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "DeleteUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delete User";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteUserFormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Label errorlb2;
		private System.Windows.Forms.Label errelb;
		private System.Windows.Forms.MaskedTextBox passwordTxtBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox usernameCmbBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Panel panel1;
	}
}
