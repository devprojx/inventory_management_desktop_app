/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 25/07/2015
 * Time: 11:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.OleDb;
using System.Data;
using Inventory_System.Classes;
using System.Windows.Forms;

namespace Inventory_System.Classes
{
	/// <summary>
	/// Description of Validate.
	/// </summary>
	public class ValidatePassword
	{
		public static ValidatePassword instance = null;
			OleDbCommand cmd = new OleDbCommand();
			OleDbConnection accessConnection = new OleDbConnection();
			OleDbDataReader accessReader ;
			
		private ValidatePassword()
		{
			
		}
		
		public bool IsValidEmail(string email)
		{
			try{
				var mail = new System.Net.Mail.MailAddress(email);
				return true;
			}
			catch{
				return false;
			}
		}
		
		public static ValidatePassword getInstance()
		{
			if(instance == null)
			{
				instance = new ValidatePassword();
			}
			return instance;
		}
		
		public bool IsEmpty(Control temp)
		{
			foreach(Control check in temp.Controls)
			{
				if(check.GetType() .Name.ToString()== "TextBox")
				{
					if(String.IsNullOrEmpty(check.Text))
					{
					return true;
					}
				}
				if(check.GetType().Name.ToString() == "MaskedTextBox")
				 {
					if(String.IsNullOrEmpty(check.Text))
					{
					  return true;
					}
				}
			}
			return false;
		}
		public void Clear(Control control)
		{
			foreach(Control temp in control.Controls)
			{
				if(temp.GetType() .Name.ToString()== "TextBox")
				{
					temp.Text = "";
				}
				if(temp.GetType().Name.ToString() == "MaskedTextBox")
				 {
					temp.Text = "";
				}
			}
		}
		public bool CheckIfUserExist(string user)
		{
		   bool isTrue = false;
		   try
		   {
		   	 accessConnection.Open();
		   	 cmd = new OleDbCommand();
			 cmd.Connection = accessConnection;
		     cmd.CommandText = "SELECT * From LoginTbl where Username = [0]";
		     cmd.Parameters.AddWithValue("0", user);
			 accessReader = cmd.ExecuteReader();
				 if(accessReader.HasRows)
				 {
			  	   
					isTrue =  true ;
				 } 
		   }
		   catch(Exception)
		   {
		   	
		   }
		   finally
		   {
		   	accessReader.Close();
		   	accessConnection.Close();
		   }
		   return isTrue;
	    }
		public bool ValidateUser(string username, string password)
		{
			bool valid = false;
			accessConnection.ConnectionString = Connection.getConnectionString();
			try
			{
				cmd = new OleDbCommand();
				accessConnection.Open();
				cmd.Connection = accessConnection;
				cmd.CommandText = @"SELECT * FROM LoginTbl WHERE Username = [0] AND UserPassword = [1]";
				cmd.Parameters.AddWithValue("0", username);
				cmd.Parameters.AddWithValue("1",password);
			    accessReader = cmd.ExecuteReader();
				 if(accessReader.HasRows)
				 {
					valid =  true ;
				 } 
				
			}catch(Exception e)
			{
				
			}
			finally
			{
				accessReader.Close();
				accessConnection.Close();
			}
			return valid;
		}
		
	}
}
