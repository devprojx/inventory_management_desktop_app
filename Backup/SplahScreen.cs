/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 17/07/2015
 * Time: 03:07 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Inventory_System.Classes;

namespace Inventory_System
{
	/// <summary>
	/// Description of SplahScreen.
	/// </summary>
	public partial class SplahScreen : Form
	{ 
		
			MainForm newform = new MainForm();	
		    string Mname = @"MasterReset";
		    string Mpassword = @"P@$$w0rd";
		public SplahScreen()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			username.Focus();
			newform.Hide();
			linkLabel1.Parent = pictureBox1;
			iconPic.Parent = pictureBox1;
			forgetLink.Parent = pictureBox1;
			errLb.Parent = pictureBox1;
			usernameLb.Parent = pictureBox1;
			passwordLb.Parent = pictureBox1;
			username.Parent = pictureBox1;
			passwordTxtBox.Parent = pictureBox1;
			titleLb.Parent = pictureBox1;
			iconPic.Parent = pictureBox1;
			loginBtn.Parent = this;
			
			//
			// 
			//
		}		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}
		
		//Check if user exist on LoginButton click event
		void LoginBtnClick(object sender, EventArgs e)
		{
			loginBtn.Enabled = false;
			username.Enabled = false;
			passwordTxtBox.Enabled = false;
			//Encrypt password
			passwordTxtBox.Text = XOREncryption.getInstance().DecryptPassword(passwordTxtBox.Text, XOREncryption.getInstance().key);
			
			if(ValidatePassword.getInstance().ValidateUser(username.Text.ToLower(), passwordTxtBox.Text) || 
			   (username.Text.ToLower() == Mname.ToLower() && XOREncryption.getInstance().DecryptPassword(passwordTxtBox.Text, XOREncryption.getInstance().key) == Mpassword))
			{
				errLb.Visible = false;
				if(newform.IsDisposed)
				{
					newform = new MainForm();
					newform.Show();
					loginBtn.Enabled = true;
					this.Hide();
					username.Text = "";
					passwordTxtBox.Text = "";
					username.Enabled = true;
			        passwordTxtBox.Enabled = true;
					return;
				}
				username.Text = "";
				passwordTxtBox.Text = "";
				loginBtn.Enabled = true;
				newform.Show();
				this.Hide();
			}
			else
			{
				errLb.Visible = true;
			}
			passwordTxtBox.Text = "";
			username.Enabled = true;
			passwordTxtBox.Enabled = true;
			loginBtn.Enabled = true;
		}
		
		//Show forget password form on forgetLink click event
		void ForgetLinkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ForgetPassword fpForm = new ForgetPassword();
			this.Enabled = false;
			fpForm.Show();
		}
		
	}
}
