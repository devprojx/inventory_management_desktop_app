/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 26/07/2015
 * Time: 05:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using Inventory_System.Classes;

namespace Inventory_System
{
	/// <summary>
	/// Description of ForgetPassword.
	/// </summary>
	public partial class ForgetPassword : Form
	{
		OleDbCommand cmd = new OleDbCommand();
			OleDbConnection accessConnection = new OleDbConnection();
			OleDbDataReader accessReader ;
			User newUser1 = new User();
				string key = @"$#%^&*((*@!_)*(@&&@&*&^#^&@(*@(*!)(@&@*())@*&&#&^*&^*(#)*#&^#&*(#)#(*&";
		public ForgetPassword()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			accessConnection.ConnectionString = Connection.getConnectionString();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void UsernameLeave(object sender, EventArgs e)
		{
			if(username.Text == "" || username.Text == " ")
			{
				username.Text= "";
				questionLbl.Text = "";
				return;
			}
			questionLbl.Text = getQuestion(username.Text).SecretQuestion;
			newUser1.Username = username.Text;
		}
		public User getQuestion(string user)
		{
			User newUser = new User();
		   try
		   {
		   	 accessConnection.Open();
		   	 cmd = new OleDbCommand();
			 cmd.Connection = accessConnection;
		     cmd.CommandText = "SELECT SecretQuestion, Answer From LoginTbl where Username = [0]";
		     cmd.Parameters.AddWithValue("0", user);
			 accessReader = cmd.ExecuteReader();
			 while(accessReader.Read())
			 {
			 	newUser.SecretQuestion = accessReader.GetString(0);
			 	newUser.Answer = accessReader.GetString(1);
			 }
			 accessReader.Close();
		   }
		   catch(Exception)
		   {
		   	
		   }
		   finally
		   {
		   	accessConnection.Close();
		   }
		   return newUser;
	    }
		public bool ValidateQuestion(string ans, string user)
		{
			bool isTrue = false;
		   try
		   {
		   	 accessConnection.Open();
		   	 cmd = new OleDbCommand();
			 cmd.Connection = accessConnection;
		     cmd.CommandText = "SELECT * From LoginTbl where Username = [0] AND Answer = [1] ";
		     cmd.Parameters.AddWithValue("0", user);
		     cmd.Parameters.AddWithValue("1", ans.ToLower());
			 accessReader = cmd.ExecuteReader();
			 if(accessReader.HasRows)
			 {
			 	isTrue = true;
			 }
			 accessReader.Close();
		   }
		   catch(Exception e)
		   {
		   	MessageBox.Show("" +e);
		   }
		   finally
		   {
		   	accessConnection.Close();
		   }
		   return isTrue;
	    }
		
		public void ChangePassword(User newUser)
		{
			
		  try
			{
		  	cmd = new OleDbCommand();
				accessConnection.Open();
				cmd.Connection = accessConnection;
				cmd.CommandText = @"UPDATE LoginTbl SET UserPassword = [0] WHERE Username = [1]";
				cmd.Parameters.AddWithValue("0", newUser.Password);
				cmd.Parameters.AddWithValue("1",newUser.Username);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Password changed successfully");
			}
			catch(Exception e)
			{
				MessageBox.Show(""+e);
			}
			finally
			{
				accessConnection.Close();
			}
		}
		
		void ResetBtnClick(object sender, EventArgs e)
		{
			errorLb3.Visible = false;
			errorLb2.Visible = false;
		
				if(ValidatePassword.getInstance().IsEmpty(groupBox1))
				{
			     	errorLb2.Visible = true;
			     	return;
			    }
				if(newPasswordTxtbox.Text != newPasswordTxtbox2.Text)
				{
					errorLb3.Visible = true;
					return;
				}
				if(newPasswordTxtbox.Text.Length <= 8 && newPasswordTxtbox.Text.Length >= 12)
				{
					MessageBox.Show("Password length must ave 8 characters but cannot exceed 12 characters");
					return;
				    
				}
				newUser1.Password = XOREncryption.getInstance().EncryptPassword(newPasswordTxtbox.Text, key);
				ChangePassword(newUser1);
				ValidatePassword.getInstance().Clear(groupBox1);
		}
		
		void AnswerLeave(object sender, EventArgs e)
		{
			error1.Visible = false;
			string ans = XOREncryption.getInstance().EncryptPassword(answer.Text, key);
			if(!ValidateQuestion(ans, username.Text))
			 {
				error1.Visible = true;
			   	return;
			 }
			
		}
		
		
		void ForgetPasswordFormClosed(object sender, FormClosedEventArgs e)
		{
			Form newform = Application.OpenForms["SplahScreen"] as SplahScreen;
			newform.Enabled = true;
		}
	}
}
