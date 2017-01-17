/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 17/07/2015
 * Time: 03:07 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class SplahScreen
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
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.titleLb = new System.Windows.Forms.Label();
			this.iconPic = new System.Windows.Forms.PictureBox();
			this.passwordTxtBox = new System.Windows.Forms.MaskedTextBox();
			this.forgetLink = new System.Windows.Forms.LinkLabel();
			this.errLb = new System.Windows.Forms.Label();
			this.username = new System.Windows.Forms.TextBox();
			this.passwordLb = new System.Windows.Forms.Label();
			this.usernameLb = new System.Windows.Forms.Label();
			this.loginBtn = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox3.Location = new System.Drawing.Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(404, 281);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// titleLb
			// 
			this.titleLb.BackColor = System.Drawing.Color.Transparent;
			this.titleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLb.Location = new System.Drawing.Point(87, 49);
			this.titleLb.Name = "titleLb";
			this.titleLb.Size = new System.Drawing.Size(235, 55);
			this.titleLb.TabIndex = 1;
			this.titleLb.Text = "Inventory Management System";
			this.titleLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.titleLb.Visible = false;
			// 
			// iconPic
			// 
			this.iconPic.BackColor = System.Drawing.Color.Transparent;
			this.iconPic.Image = global::Inventory_System.Resource1._1438206761_preferences_desktop_cryptography;
			this.iconPic.Location = new System.Drawing.Point(281, 151);
			this.iconPic.Name = "iconPic";
			this.iconPic.Size = new System.Drawing.Size(64, 58);
			this.iconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.iconPic.TabIndex = 27;
			this.iconPic.TabStop = false;
			// 
			// passwordTxtBox
			// 
			this.passwordTxtBox.Location = new System.Drawing.Point(116, 190);
			this.passwordTxtBox.Name = "passwordTxtBox";
			this.passwordTxtBox.PasswordChar = '•';
			this.passwordTxtBox.Size = new System.Drawing.Size(161, 20);
			this.passwordTxtBox.TabIndex = 2;
			// 
			// forgetLink
			// 
			this.forgetLink.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.forgetLink.ActiveLinkColor = System.Drawing.Color.Transparent;
			this.forgetLink.BackColor = System.Drawing.Color.Transparent;
			this.forgetLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forgetLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.forgetLink.LinkColor = System.Drawing.Color.Brown;
			this.forgetLink.Location = new System.Drawing.Point(259, 257);
			this.forgetLink.Name = "forgetLink";
			this.forgetLink.Size = new System.Drawing.Size(136, 18);
			this.forgetLink.TabIndex = 4;
			this.forgetLink.TabStop = true;
			this.forgetLink.Text = "Forgot Password?";
			this.forgetLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgetLinkLinkClicked);
			// 
			// errLb
			// 
			this.errLb.BackColor = System.Drawing.Color.Transparent;
			this.errLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errLb.ForeColor = System.Drawing.Color.Red;
			this.errLb.Location = new System.Drawing.Point(112, 135);
			this.errLb.Name = "errLb";
			this.errLb.Size = new System.Drawing.Size(194, 14);
			this.errLb.TabIndex = 25;
			this.errLb.Text = "*Username or Password is Invalid";
			this.errLb.Visible = false;
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(117, 156);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(160, 20);
			this.username.TabIndex = 2;
			// 
			// passwordLb
			// 
			this.passwordLb.BackColor = System.Drawing.Color.Transparent;
			this.passwordLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordLb.Location = new System.Drawing.Point(33, 188);
			this.passwordLb.Name = "passwordLb";
			this.passwordLb.Size = new System.Drawing.Size(82, 23);
			this.passwordLb.TabIndex = 24;
			this.passwordLb.Text = "Password";
			// 
			// usernameLb
			// 
			this.usernameLb.BackColor = System.Drawing.Color.Transparent;
			this.usernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameLb.Location = new System.Drawing.Point(29, 154);
			this.usernameLb.Name = "usernameLb";
			this.usernameLb.Size = new System.Drawing.Size(87, 23);
			this.usernameLb.TabIndex = 23;
			this.usernameLb.Text = "Username";
			// 
			// loginBtn
			// 
			this.loginBtn.BackColor = System.Drawing.Color.DarkCyan;
			this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.loginBtn.Location = new System.Drawing.Point(148, 226);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(92, 25);
			this.loginBtn.TabIndex = 3;
			this.loginBtn.Text = "Login";
			this.loginBtn.UseVisualStyleBackColor = false;
			this.loginBtn.Click += new System.EventHandler(this.LoginBtnClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Inventory_System.Resource1.login;
			this.pictureBox1.Location = new System.Drawing.Point(3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(398, 276);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Transparent;
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel1.LinkColor = System.Drawing.SystemColors.HotTrack;
			this.linkLabel1.Location = new System.Drawing.Point(6, 259);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(33, 18);
			this.linkLabel1.TabIndex = 5;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Exit";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// SplahScreen
			// 
			this.AcceptButton = this.loginBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(404, 281);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.titleLb);
			this.Controls.Add(this.iconPic);
			this.Controls.Add(this.passwordTxtBox);
			this.Controls.Add(this.forgetLink);
			this.Controls.Add(this.errLb);
			this.Controls.Add(this.username);
			this.Controls.Add(this.passwordLb);
			this.Controls.Add(this.usernameLb);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SplahScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SplahScreen";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label titleLb;
		private System.Windows.Forms.PictureBox iconPic;
		public System.Windows.Forms.Label usernameLb;
		private System.Windows.Forms.Label passwordLb;
		private System.Windows.Forms.LinkLabel forgetLink;
		private System.Windows.Forms.Label errLb;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.MaskedTextBox passwordTxtBox;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		
		
	}
}
