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
	partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.iconPic = new System.Windows.Forms.PictureBox();
            this.passwordTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.forgetLink = new System.Windows.Forms.LinkLabel();
            this.errLb = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.passwordLb = new System.Windows.Forms.Label();
            this.usernameLb = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerLbl = new System.Windows.Forms.Label();
            this.headingPic = new System.Windows.Forms.PictureBox();
            this.footerLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headingPic)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPic
            // 
            this.iconPic.BackColor = System.Drawing.Color.Transparent;
            //this.iconPic.Image = global::Inventory_System.Resource1._1438206761_preferences_desktop_cryptography;
            this.iconPic.Location = new System.Drawing.Point(76, 140);
            this.iconPic.Name = "iconPic";
            this.iconPic.Size = new System.Drawing.Size(102, 92);
            this.iconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPic.TabIndex = 27;
            this.iconPic.TabStop = false;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(183, 202);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '•';
            this.passwordTxtBox.Size = new System.Drawing.Size(250, 29);
            this.passwordTxtBox.TabIndex = 2;
            // 
            // forgetLink
            // 
            this.forgetLink.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.forgetLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.forgetLink.BackColor = System.Drawing.Color.Transparent;
            this.forgetLink.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forgetLink.LinkColor = System.Drawing.Color.Brown;
            this.forgetLink.Location = new System.Drawing.Point(417, 343);
            this.forgetLink.Name = "forgetLink";
            this.forgetLink.Size = new System.Drawing.Size(157, 29);
            this.forgetLink.TabIndex = 4;
            this.forgetLink.TabStop = true;
            this.forgetLink.Text = "Forgot Password?";
            this.forgetLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgetLinkLinkClicked);
            // 
            // errLb
            // 
            this.errLb.BackColor = System.Drawing.Color.Transparent;
            this.errLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.errLb.Location = new System.Drawing.Point(181, 234);
            this.errLb.Name = "errLb";
            this.errLb.Size = new System.Drawing.Size(253, 27);
            this.errLb.TabIndex = 25;
            this.errLb.Text = "*Username or Password is Invalid";
            this.errLb.Visible = false;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(182, 141);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(249, 29);
            this.username.TabIndex = 2;
            // 
            // passwordLb
            // 
            this.passwordLb.BackColor = System.Drawing.Color.Transparent;
            this.passwordLb.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLb.Location = new System.Drawing.Point(178, 176);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(102, 23);
            this.passwordLb.TabIndex = 24;
            this.passwordLb.Text = "Password";
            // 
            // usernameLb
            // 
            this.usernameLb.BackColor = System.Drawing.Color.Transparent;
            this.usernameLb.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLb.Location = new System.Drawing.Point(177, 116);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(107, 23);
            this.usernameLb.TabIndex = 23;
            this.usernameLb.Text = "Username";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.loginBtn.Location = new System.Drawing.Point(238, 261);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(127, 36);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtnClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.linkLabel1.Location = new System.Drawing.Point(3, 2);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 31);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Exit";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // headerLbl
            // 
            this.headerLbl.BackColor = System.Drawing.Color.Transparent;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.headerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.headerLbl.Location = new System.Drawing.Point(161, 32);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(348, 66);
            this.headerLbl.TabIndex = 30;
            this.headerLbl.Text = "Consumables Inventory Management System";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // headingPic
            // 
            this.headingPic.Image = ((System.Drawing.Image)(resources.GetObject("headingPic.Image")));
            this.headingPic.Location = new System.Drawing.Point(75, 26);
            this.headingPic.Name = "headingPic";
            this.headingPic.Size = new System.Drawing.Size(88, 76);
            this.headingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headingPic.TabIndex = 31;
            this.headingPic.TabStop = false;
            // 
            // footerLbl
            // 
            this.footerLbl.BackColor = System.Drawing.Color.Transparent;
            this.footerLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.footerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.footerLbl.Location = new System.Drawing.Point(-1, 356);
            this.footerLbl.Name = "footerLbl";
            this.footerLbl.Size = new System.Drawing.Size(253, 29);
            this.footerLbl.TabIndex = 32;
            this.footerLbl.Text = "© 2015 VTDI Mandeville";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(573, 377);
            this.Controls.Add(this.footerLbl);
            this.Controls.Add(this.headingPic);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.iconPic);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.forgetLink);
            this.Controls.Add(this.errLb);
            this.Controls.Add(this.username);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.usernameLb);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            ((System.ComponentModel.ISupportInitialize)(this.iconPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headingPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.PictureBox iconPic;
		public System.Windows.Forms.Label usernameLb;
		private System.Windows.Forms.Label passwordLb;
		private System.Windows.Forms.LinkLabel forgetLink;
		private System.Windows.Forms.Label errLb;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.MaskedTextBox passwordTxtBox;
		private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.PictureBox headingPic;
        private System.Windows.Forms.Label footerLbl;
    }
}
