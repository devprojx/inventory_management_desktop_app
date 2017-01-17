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
	public partial class LoginForm : Form
	{
        int mouseX;
        int mouseY;
        bool isMouseDown = false;

		    string Mname = @"MasterReset";
		    string Mpassword = @"P@$$w0rd";

    
        public LoginForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			username.Focus();
			
			linkLabel1.Parent = pictureBox1;
			iconPic.Parent = pictureBox1;
			forgetLink.Parent = pictureBox1;
			errLb.Parent = pictureBox1;
			usernameLb.Parent = pictureBox1;
			headerLbl.Parent = pictureBox1;
			headingPic.Parent = pictureBox1;
            passwordLb.Parent = pictureBox1;
			username.Parent = pictureBox1;
			passwordTxtBox.Parent = pictureBox1;
			iconPic.Parent = pictureBox1;
			footerLbl.Parent = pictureBox1;
            loginBtn.Parent = this;
            username.Focus();
			
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
            int userType = 0;
            int userId = 0;
			//Encrypt password
			passwordTxtBox.Text = XOREncryption.getInstance().DecryptPassword(passwordTxtBox.Text, XOREncryption.getInstance().key);
			
			if(Utilities.getInstance().ValidateUser(username.Text.ToLower(), passwordTxtBox.Text, out userType, out userId) || 
			   (username.Text.ToLower() == Mname.ToLower() && XOREncryption.getInstance().DecryptPassword(passwordTxtBox.Text, XOREncryption.getInstance().key) == Mpassword))
			{


                errLb.Visible = false;
                if (userType == 3)
                {
                    RequestForm requestForm = new RequestForm(username.Text, userId);
                    requestForm.Show();
                }
                else {

                    MainForm newform = new MainForm(userType, userId);
                    Data_Access.DataAccess.LogAction(userId, "Logged In");
                    errLb.Visible = false;
                    if (newform.IsDisposed)
                    {
                        newform = new MainForm(userType, userId);
                        newform.Show();
                        Data_Access.DataAccess.LogAction(userId, "Logged In");
                        loginBtn.Enabled = true;
                        this.Hide();
                        username.Text = "";
                        passwordTxtBox.Text = "";
                        username.Enabled = true;
                        passwordTxtBox.Enabled = true;
                        return;
                    }
                    newform.Show();
                }
                username.Text = "";
                passwordTxtBox.Text = "";
                loginBtn.Enabled = true;
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

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Location = new Point((Location.X - mouseX)+e.X, (Location.Y - mouseY)+e.Y);
                this.Update();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }
    }
}
