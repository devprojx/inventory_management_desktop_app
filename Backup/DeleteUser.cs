/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 26/07/2015
 * Time: 10:11 AM
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
	/// Description of DeleteUser.
	/// </summary>
	public partial class DeleteUser : Form
	{
		    OleDbCommand cmd = new OleDbCommand();
			OleDbConnection accessConnection = new OleDbConnection();
			OleDbDataReader accessReader;
			
		public DeleteUser()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			accessConnection.ConnectionString = Connection.getConnectionString();
			LoadUsersInList();
			//
		}
		/// <summary>
		///  Loads users from database into a combo box
		/// </summary>
		void LoadUsersInList()
		{
			try
			{
				cmd = new OleDbCommand();
				accessConnection.Open();
				cmd.CommandText =  @"SELECT Username  FROM LoginTbl";
				cmd.Connection = accessConnection;
			
				accessReader =  cmd.ExecuteReader();
			  
				while(accessReader.Read())
				{
					usernameCmbBox.Items.Add(accessReader.GetString(0));
				}
			}
			catch(Exception ex)	
			{
				MessageBox.Show(""+ex);
			}
			finally
			{
				accessReader.Close();
				accessConnection.Close();
			}
		}
		/// <summary>
		///  Deletes an existing user
		/// </summary>
		/// <param name="username">username string</param>
		void DeleteExisitingUser(string username)
		{
			try
			{
				DialogResult dialog =  MessageBox.Show("Are you sure you want to delete User? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			     MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
				if(dialog == DialogResult.Yes)
				{
					accessConnection.Open();
					cmd.CommandText =  @"DELETE *  FROM LoginTbl Where Username = [0]";
					cmd.Parameters.AddWithValue("0", username);
					cmd.Connection = accessConnection;
					cmd.ExecuteNonQuery();
					 MessageBox.Show("User was Deleted");
					 usernameCmbBox.Items.Clear();
					 
					 passwordTxtBox.Text = "";
				}
			}
			catch(Exception)	
			{
				
			}
			finally
			{
				accessConnection.Close();
				LoadUsersInList();
			}
		}
		
		//Delete user on Delete Button click event
		void DeleteBtnClick(object sender, EventArgs e)
		{
			errorlb2.Visible = false;
			errelb.Visible = false;
			if(usernameCmbBox.SelectedIndex < 0 || passwordTxtBox.Text == "")
			{
				errelb.Visible = true;
			}
			
			string password = XOREncryption.getInstance().EncryptPassword(passwordTxtBox.Text, XOREncryption.getInstance().key);
			if(!ValidatePassword.getInstance().ValidateUser(usernameCmbBox.SelectedItem.ToString(),password))
			{
				errorlb2.Visible = true;
				return;
			}
			
			DeleteExisitingUser(usernameCmbBox.SelectedItem.ToString());
		}
		
		void DeleteUserFormClosed(object sender, FormClosedEventArgs e)
		{
			Form form = Application.OpenForms["CreateUser"] as CreateUser;
			form.Enabled = true;
		}
		
	}
}
