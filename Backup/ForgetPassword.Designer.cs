/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 26/07/2015
 * Time: 05:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class ForgetPassword
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
			this.errorLb2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.answer = new System.Windows.Forms.MaskedTextBox();
			this.errorLb3 = new System.Windows.Forms.Label();
			this.error1 = new System.Windows.Forms.Label();
			this.newPasswordTxtbox2 = new System.Windows.Forms.MaskedTextBox();
			this.newPasswordTxtbox = new System.Windows.Forms.MaskedTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.questionLbl = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.username = new System.Windows.Forms.TextBox();
			this.resetBtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.errorLb2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.resetBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(428, 338);
			this.panel1.TabIndex = 0;
			// 
			// errorLb2
			// 
			this.errorLb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLb2.ForeColor = System.Drawing.Color.Red;
			this.errorLb2.Location = new System.Drawing.Point(129, 284);
			this.errorLb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorLb2.Name = "errorLb2";
			this.errorLb2.Size = new System.Drawing.Size(202, 18);
			this.errorLb2.TabIndex = 50;
			this.errorLb2.Text = "*You cannot leave fields empty";
			this.errorLb2.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.groupBox1.Controls.Add(this.answer);
			this.groupBox1.Controls.Add(this.errorLb3);
			this.groupBox1.Controls.Add(this.error1);
			this.groupBox1.Controls.Add(this.newPasswordTxtbox2);
			this.groupBox1.Controls.Add(this.newPasswordTxtbox);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.questionLbl);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.username);
			this.groupBox1.Location = new System.Drawing.Point(7, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(410, 268);
			this.groupBox1.TabIndex = 36;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Reset Password";
			// 
			// answer
			// 
			this.answer.Location = new System.Drawing.Point(155, 127);
			this.answer.Name = "answer";
			this.answer.PasswordChar = '•';
			this.answer.Size = new System.Drawing.Size(126, 22);
			this.answer.TabIndex = 1;
			this.answer.Leave += new System.EventHandler(this.AnswerLeave);
			// 
			// errorLb3
			// 
			this.errorLb3.ForeColor = System.Drawing.Color.Red;
			this.errorLb3.Location = new System.Drawing.Point(140, 246);
			this.errorLb3.Name = "errorLb3";
			this.errorLb3.Size = new System.Drawing.Size(166, 17);
			this.errorLb3.TabIndex = 49;
			this.errorLb3.Text = "*Passwords are not equal";
			this.errorLb3.Visible = false;
			// 
			// error1
			// 
			this.error1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.error1.ForeColor = System.Drawing.Color.Red;
			this.error1.Location = new System.Drawing.Point(150, 153);
			this.error1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.error1.Name = "error1";
			this.error1.Size = new System.Drawing.Size(144, 18);
			this.error1.TabIndex = 47;
			this.error1.Text = "*Your answer is incorrect";
			this.error1.Visible = false;
			// 
			// newPasswordTxtbox2
			// 
			this.newPasswordTxtbox2.Location = new System.Drawing.Point(155, 217);
			this.newPasswordTxtbox2.Margin = new System.Windows.Forms.Padding(4);
			this.newPasswordTxtbox2.Name = "newPasswordTxtbox2";
			this.newPasswordTxtbox2.PasswordChar = '•';
			this.newPasswordTxtbox2.Size = new System.Drawing.Size(126, 22);
			this.newPasswordTxtbox2.TabIndex = 3;
			// 
			// newPasswordTxtbox
			// 
			this.newPasswordTxtbox.Location = new System.Drawing.Point(155, 185);
			this.newPasswordTxtbox.Margin = new System.Windows.Forms.Padding(4);
			this.newPasswordTxtbox.Name = "newPasswordTxtbox";
			this.newPasswordTxtbox.PasswordChar = '•';
			this.newPasswordTxtbox.Size = new System.Drawing.Size(126, 22);
			this.newPasswordTxtbox.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(1, 226);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(173, 28);
			this.label9.TabIndex = 46;
			this.label9.Text = "Re-enter New Password";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(19, 190);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(155, 28);
			this.label8.TabIndex = 45;
			this.label8.Text = "Enter New Password";
			// 
			// questionLbl
			// 
			this.questionLbl.Location = new System.Drawing.Point(148, 69);
			this.questionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.questionLbl.Name = "questionLbl";
			this.questionLbl.Size = new System.Drawing.Size(251, 52);
			this.questionLbl.TabIndex = 42;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(57, 127);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 28);
			this.label5.TabIndex = 41;
			this.label5.Text = "Your Answer";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(34, 59);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 37);
			this.label4.TabIndex = 40;
			this.label4.Text = "Secret Question";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(39, 36);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 39;
			this.label1.Text = "Enter Username";
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(153, 36);
			this.username.Margin = new System.Windows.Forms.Padding(4);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(129, 22);
			this.username.TabIndex = 0;
			this.username.Leave += new System.EventHandler(this.UsernameLeave);
			// 
			// resetBtn
			// 
			this.resetBtn.Location = new System.Drawing.Point(162, 304);
			this.resetBtn.Margin = new System.Windows.Forms.Padding(4);
			this.resetBtn.Name = "resetBtn";
			this.resetBtn.Size = new System.Drawing.Size(108, 30);
			this.resetBtn.TabIndex = 5;
			this.resetBtn.Text = "Reset";
			this.resetBtn.UseVisualStyleBackColor = true;
			this.resetBtn.Click += new System.EventHandler(this.ResetBtnClick);
			// 
			// ForgetPassword
			// 
			this.AcceptButton = this.resetBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 338);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ForgetPassword";
			this.Text = "Forgot Password?";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgetPasswordFormClosed);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label errorLb2;
		private System.Windows.Forms.Label errorLb3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label error1;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox answer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label questionLbl;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.MaskedTextBox newPasswordTxtbox;
		private System.Windows.Forms.MaskedTextBox newPasswordTxtbox2;
		private System.Windows.Forms.Button resetBtn;
		private System.Windows.Forms.Panel panel1;
	}
}
