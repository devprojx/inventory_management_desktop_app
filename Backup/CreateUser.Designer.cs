/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 25/07/2015
 * Time: 11:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class CreateUser
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.errorLb4 = new System.Windows.Forms.Label();
			this.errorLb3 = new System.Windows.Forms.Label();
			this.newPasswordTxtbox2 = new System.Windows.Forms.MaskedTextBox();
			this.newPasswordTxtbox = new System.Windows.Forms.MaskedTextBox();
			this.oldPasswordTxtBox = new System.Windows.Forms.MaskedTextBox();
			this.changeBtn = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.username2Txtbox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.errorLb1 = new System.Windows.Forms.Label();
			this.answer = new System.Windows.Forms.MaskedTextBox();
			this.password2 = new System.Windows.Forms.MaskedTextBox();
			this.password1 = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.secretQuestion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.createBtn = new System.Windows.Forms.Button();
			this.username = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel1.Controls.Add(this.statusStrip1);
			this.panel1.Controls.Add(this.menuStrip1);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(863, 408);
			this.panel1.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.statusStrip1.Location = new System.Drawing.Point(0, 386);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(863, 22);
			this.statusStrip1.TabIndex = 14;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(863, 24);
			this.menuStrip1.TabIndex = 15;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
			this.groupBox2.Controls.Add(this.linkLabel1);
			this.groupBox2.Controls.Add(this.errorLb4);
			this.groupBox2.Controls.Add(this.errorLb3);
			this.groupBox2.Controls.Add(this.newPasswordTxtbox2);
			this.groupBox2.Controls.Add(this.newPasswordTxtbox);
			this.groupBox2.Controls.Add(this.oldPasswordTxtBox);
			this.groupBox2.Controls.Add(this.changeBtn);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.username2Txtbox);
			this.groupBox2.Location = new System.Drawing.Point(464, 30);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(393, 304);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Change Password";
			// 
			// linkLabel1
			// 
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.LinkColor = System.Drawing.SystemColors.WindowText;
			this.linkLabel1.Location = new System.Drawing.Point(298, 280);
			this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(90, 18);
			this.linkLabel1.TabIndex = 12;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Delete User";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// errorLb4
			// 
			this.errorLb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLb4.ForeColor = System.Drawing.Color.Tomato;
			this.errorLb4.Location = new System.Drawing.Point(171, 210);
			this.errorLb4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorLb4.Name = "errorLb4";
			this.errorLb4.Size = new System.Drawing.Size(180, 18);
			this.errorLb4.TabIndex = 26;
			this.errorLb4.Text = "*Password are not equal";
			this.errorLb4.Visible = false;
			// 
			// errorLb3
			// 
			this.errorLb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLb3.ForeColor = System.Drawing.Color.Tomato;
			this.errorLb3.Location = new System.Drawing.Point(138, 105);
			this.errorLb3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorLb3.Name = "errorLb3";
			this.errorLb3.Size = new System.Drawing.Size(241, 18);
			this.errorLb3.TabIndex = 25;
			this.errorLb3.Text = "*Incorrect username and password";
			this.errorLb3.Visible = false;
			// 
			// newPasswordTxtbox2
			// 
			this.newPasswordTxtbox2.Location = new System.Drawing.Point(173, 180);
			this.newPasswordTxtbox2.Margin = new System.Windows.Forms.Padding(4);
			this.newPasswordTxtbox2.Name = "newPasswordTxtbox2";
			this.newPasswordTxtbox2.PasswordChar = '•';
			this.newPasswordTxtbox2.Size = new System.Drawing.Size(176, 22);
			this.newPasswordTxtbox2.TabIndex = 10;
			// 
			// newPasswordTxtbox
			// 
			this.newPasswordTxtbox.Location = new System.Drawing.Point(173, 148);
			this.newPasswordTxtbox.Margin = new System.Windows.Forms.Padding(4);
			this.newPasswordTxtbox.Name = "newPasswordTxtbox";
			this.newPasswordTxtbox.PasswordChar = '•';
			this.newPasswordTxtbox.Size = new System.Drawing.Size(176, 22);
			this.newPasswordTxtbox.TabIndex = 9;
			// 
			// oldPasswordTxtBox
			// 
			this.oldPasswordTxtBox.Location = new System.Drawing.Point(173, 78);
			this.oldPasswordTxtBox.Margin = new System.Windows.Forms.Padding(4);
			this.oldPasswordTxtBox.Name = "oldPasswordTxtBox";
			this.oldPasswordTxtBox.PasswordChar = '•';
			this.oldPasswordTxtBox.Size = new System.Drawing.Size(176, 22);
			this.oldPasswordTxtBox.TabIndex = 8;
			// 
			// changeBtn
			// 
			this.changeBtn.BackColor = System.Drawing.Color.GreenYellow;
			this.changeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.changeBtn.Location = new System.Drawing.Point(173, 238);
			this.changeBtn.Margin = new System.Windows.Forms.Padding(4);
			this.changeBtn.Name = "changeBtn";
			this.changeBtn.Size = new System.Drawing.Size(148, 28);
			this.changeBtn.TabIndex = 11;
			this.changeBtn.Text = "Change Password";
			this.changeBtn.UseVisualStyleBackColor = false;
			this.changeBtn.Click += new System.EventHandler(this.ChangeBtnClick);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 187);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(173, 28);
			this.label9.TabIndex = 24;
			this.label9.Text = "Re-enter New Password";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(27, 151);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(155, 28);
			this.label8.TabIndex = 23;
			this.label8.Text = "Enter New Password";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(27, 82);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(137, 28);
			this.label6.TabIndex = 22;
			this.label6.Text = "Enter Old Password";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(49, 44);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 23);
			this.label7.TabIndex = 21;
			this.label7.Text = "Enter Username";
			// 
			// username2Txtbox
			// 
			this.username2Txtbox.Location = new System.Drawing.Point(173, 41);
			this.username2Txtbox.Margin = new System.Windows.Forms.Padding(4);
			this.username2Txtbox.Name = "username2Txtbox";
			this.username2Txtbox.Size = new System.Drawing.Size(176, 22);
			this.username2Txtbox.TabIndex = 7;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.errorLb1);
			this.groupBox1.Controls.Add(this.answer);
			this.groupBox1.Controls.Add(this.password2);
			this.groupBox1.Controls.Add(this.password1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.secretQuestion);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.createBtn);
			this.groupBox1.Controls.Add(this.username);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox1.Location = new System.Drawing.Point(6, 29);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(454, 353);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Create New User";
			// 
			// errorLb1
			// 
			this.errorLb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLb1.ForeColor = System.Drawing.Color.Tomato;
			this.errorLb1.Location = new System.Drawing.Point(56, 312);
			this.errorLb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorLb1.Name = "errorLb1";
			this.errorLb1.Size = new System.Drawing.Size(390, 18);
			this.errorLb1.TabIndex = 27;
			this.errorLb1.Text = "*Password length cannot be less than 8 or greater than 12 characters";
			this.errorLb1.Visible = false;
			// 
			// answer
			// 
			this.answer.Location = new System.Drawing.Point(159, 251);
			this.answer.Margin = new System.Windows.Forms.Padding(4);
			this.answer.Name = "answer";
			this.answer.PasswordChar = '•';
			this.answer.Size = new System.Drawing.Size(176, 22);
			this.answer.TabIndex = 5;
			// 
			// password2
			// 
			this.password2.Location = new System.Drawing.Point(161, 101);
			this.password2.Margin = new System.Windows.Forms.Padding(4);
			this.password2.Name = "password2";
			this.password2.PasswordChar = '•';
			this.password2.Size = new System.Drawing.Size(195, 22);
			this.password2.TabIndex = 3;
			// 
			// password1
			// 
			this.password1.Location = new System.Drawing.Point(161, 66);
			this.password1.Margin = new System.Windows.Forms.Padding(4);
			this.password1.Name = "password1";
			this.password1.PasswordChar = '•';
			this.password1.Size = new System.Drawing.Size(195, 22);
			this.password1.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(56, 248);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 28);
			this.label5.TabIndex = 23;
			this.label5.Text = "Your Answer";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(20, 168);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 37);
			this.label4.TabIndex = 21;
			this.label4.Text = "Secret Question";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// secretQuestion
			// 
			this.secretQuestion.Location = new System.Drawing.Point(159, 171);
			this.secretQuestion.Margin = new System.Windows.Forms.Padding(4);
			this.secretQuestion.Multiline = true;
			this.secretQuestion.Name = "secretQuestion";
			this.secretQuestion.Size = new System.Drawing.Size(259, 62);
			this.secretQuestion.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 103);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 28);
			this.label3.TabIndex = 18;
			this.label3.Text = "Re-enter Password";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 64);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 28);
			this.label2.TabIndex = 17;
			this.label2.Text = "Enter Password";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 16;
			this.label1.Text = "Enter Username";
			// 
			// createBtn
			// 
			this.createBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.createBtn.Location = new System.Drawing.Point(201, 281);
			this.createBtn.Margin = new System.Windows.Forms.Padding(4);
			this.createBtn.Name = "createBtn";
			this.createBtn.Size = new System.Drawing.Size(108, 28);
			this.createBtn.TabIndex = 6;
			this.createBtn.Text = "Create";
			this.createBtn.UseVisualStyleBackColor = false;
			this.createBtn.Click += new System.EventHandler(this.CreateBtnClick);
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(162, 27);
			this.username.Margin = new System.Windows.Forms.Padding(4);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(193, 22);
			this.username.TabIndex = 0;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Administrator",
									"Standard User"});
			this.comboBox1.Location = new System.Drawing.Point(161, 136);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(115, 24);
			this.comboBox1.TabIndex = 28;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(72, 138);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 23);
			this.label10.TabIndex = 29;
			this.label10.Text = "Privilege";
			// 
			// CreateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(863, 408);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "CreateUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User Options";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateUserFormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Label errorLb4;
		private System.Windows.Forms.Label errorLb3;
		private System.Windows.Forms.Button changeBtn;
		private System.Windows.Forms.Label errorLb1;
		private System.Windows.Forms.MaskedTextBox newPasswordTxtbox2;
		private System.Windows.Forms.MaskedTextBox newPasswordTxtbox;
		private System.Windows.Forms.MaskedTextBox oldPasswordTxtBox;
		private System.Windows.Forms.TextBox username2Txtbox;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.MaskedTextBox answer;
		private System.Windows.Forms.TextBox secretQuestion;
		private System.Windows.Forms.Button createBtn;
		private System.Windows.Forms.MaskedTextBox password2;
		private System.Windows.Forms.MaskedTextBox password1;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
	}
}
