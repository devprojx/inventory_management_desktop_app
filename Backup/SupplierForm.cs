/*
 * Created by SharpDevelop.
 * User: vstudent
 * Date: 9/9/2015
 * Time: 11:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Inventory_System.Classes;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Inventory_System
{
	/// <summary>
	/// Description of SupplierForm.
	/// </summary>
	public partial class SupplierForm : Form
	{
		Supplier newSupplier;
		OleDbConnection oleDbConnection = new OleDbConnection();
		OleDbCommand oleDbCommand = new OleDbCommand();
		MainForm nform = Application.OpenForms["MainForm"] as MainForm;
		OleDbDataReader accessReader = null;
		List<int> listParishId = new List<int>();
		
		public SupplierForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			newSupplier = new Supplier();
			oleDbConnection.ConnectionString = Connection.getConnectionString();
			LoadParish();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

		void SaveBtnClick(object sender, EventArgs e)
		{
			if(ValidatePassword.getInstance().IsEmpty(panel1))
			{
				errorLb1.Visible = true;
				return;
			}
			
			errorLb1.Visible = false;
		    newSupplier.SupplierName = SupplierTxtbox.Text;
		    newSupplier.Location = LocationTxtBox.Text;
		    newSupplier.Email = EmailMskBx.Text;
		    newSupplier.PhoneNumber1 = Phone1Mskbx.Text;
		    newSupplier.PhoneNumber2 = Phone2Mskbox.Text;
		    newSupplier.FaxNumber = FaxMskBox.Text;
		    newSupplier.ParishId = ParishCmBox.SelectedIndex + 1;
		    if(!ValidatePassword.getInstance().IsValidEmail(newSupplier.Email))
		    {
		    	MessageBox.Show("Invalid email", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		    	return;
		    }
		    /*if(Exist())
		    {
		    	MessageBox.Show("Supplier already exist","Invalid Supplier Name", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
		    }*/
		    this.SaveSupplier();
		    nform.getSupplier();
		}
		
		void SaveSupplier()
		{
			string query = @"INSERT INTO SupplierTbl(SupplierName, Location, ParishId, PhoneNumber1, PhoneNumber2, FaxNumber, Email)"+"" +
				           "VALUES ([0],[1],[2],[3],[4],[5],[6]);";
			try
			{
				oleDbConnection.Open();
				oleDbCommand.Connection = oleDbConnection;
				oleDbCommand.CommandText = query;
				oleDbCommand.Parameters.AddWithValue("0", newSupplier.SupplierName);
				oleDbCommand.Parameters.AddWithValue("1", newSupplier.Location);
				oleDbCommand.Parameters.AddWithValue("2", newSupplier.ParishId);
				oleDbCommand.Parameters.AddWithValue("3", newSupplier.PhoneNumber1);
				oleDbCommand.Parameters.AddWithValue("4", newSupplier.PhoneNumber2);
				oleDbCommand.Parameters.AddWithValue("5", newSupplier.FaxNumber);
				oleDbCommand.Parameters.AddWithValue("6", newSupplier.Email);
				oleDbCommand.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				 MessageBox.Show("Database cannot be found\n" +ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				oleDbConnection.Close();
				ValidatePassword.getInstance().Clear(panel1);
			}
			
		}
		void LoadParish()
		{
			string query = @"SELECT * FROM ParishTbl";
			try
			{
				oleDbConnection.Open();
				oleDbCommand.Connection = oleDbConnection;
				oleDbCommand.CommandText = query;
			    accessReader =  oleDbCommand.ExecuteReader();
			  
				while(accessReader.Read())
				{
					ParishCmBox.Items.Add(accessReader.GetString(1) );
					listParishId.Add(accessReader.GetInt32(0));
					
				}
			
			}
			catch(Exception ex)
			{
				 MessageBox.Show("Database cannot be found\n"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				oleDbConnection.Close();
				ValidatePassword.getInstance().Clear(panel1);
			}
			
		
		}
		void SupplierFormFormClosed(object sender, FormClosedEventArgs e)
		{
			
				Add_Item newform = Application.OpenForms["Add_Item"] as Add_Item;
				newform.Enabled = true;
				newform.LoadSupplier();
		}
		
		bool Exist()
		{
			string query = @"SELECT ParishName FROM ParishTbl Where ParishName = [0]";
			try
			{
				oleDbConnection.Open();
				oleDbCommand.Connection = oleDbConnection;
				oleDbCommand.CommandText = query;
					oleDbCommand.Parameters.AddWithValue("0", newSupplier.SupplierName);
			    accessReader =  oleDbCommand.ExecuteReader();
			     
				if(accessReader.HasRows)
				{
					return true;
				}
			
			}
			catch(Exception ex)
			{
				 MessageBox.Show("Database cannot be found\n"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				oleDbConnection.Close();
				
			}
				
					return false;
				
		}
		
		
		
	}
}
