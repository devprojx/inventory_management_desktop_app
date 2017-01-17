/*
 * Created by SharpDevelop.
 * User: Olewis
 * Date: 9/7/2015
 * Time: 6:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using Inventory_System.Classes;
using System.Collections.Generic;

namespace Inventory_System
{
	/// <summary>
	/// Description of ReceivableForm.
	/// </summary>
	public partial class ReceivableForm : Form
	{
		private OleDbConnection accessConnection = new OleDbConnection();
		OleDbDataAdapter adapter = new OleDbDataAdapter();
		OleDbCommand cmd = new OleDbCommand();
		OleDbDataReader accessReader ;
		List<string> itemCodeList = new List<string>();
		List<int> supplierIdList = new List<int>();
		Receivable newReceivable = new Receivable();
		Item newItem = new Item();
	
		public ReceivableForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			accessConnection.ConnectionString = Connection.getConnectionString();
			this.LoadItemName();
			this.LoadSupplier();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		public void LoadItemName()
		{
			
			try
			{
				accessConnection.Open();
		        //Populate item combo box
				cmd.CommandText =  @"SELECT ItemCode, ItemName FROM ItemTbl where statusId = 1";
	            cmd.Connection = accessConnection;
			 
				 accessReader =  cmd.ExecuteReader();
			
				while(accessReader.Read())
				{
					itemNameCmb.Items.Add(accessReader.GetString(1) );
					itemCodeList.Add(accessReader.GetString(0));
				}
			}
			catch(Exception e)
			{
				 MessageBox.Show("Database cannot be found\n"+e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );	
			}
			finally
			{
				//Close Reader and Connection to access
				accessReader.Close();
				accessConnection.Close();
			}
	     }
		
		public void LoadSupplier()
		{
			supplierCmbox.Items.Clear();
			supplierIdList.Clear();
			try
			{
				accessConnection.Open();
		        //Populate item combo box
				cmd.CommandText =  @"SELECT * FROM SupplierTbl";
	           cmd.Connection = accessConnection;
			 
				 accessReader =  cmd.ExecuteReader();
			  
				while(accessReader.Read())
				{
					supplierCmbox.Items.Add(accessReader.GetString(1) );
					supplierIdList.Add(accessReader.GetInt32(0));
				}
			}
			catch(Exception e)
			{
				 MessageBox.Show("Database cannot be found\n"+e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );	
			}
			finally
			{
				//Close Reader and Connection to access
				accessReader.Close();
				accessConnection.Close();
			}
		}
		
		
		void SaveReceivables()
		{
			string query = @"INSERT INTO ReceivedLogTbl(ItemCode, DateReceived, QuantityReceived, SupplierId, Cost)"+
				           "VALUES ([0],[1],[2],[3],[4]);";
			try
			{
				accessConnection.Open();
				cmd.Connection = accessConnection;
				cmd.CommandText = query;
				cmd.Parameters.AddWithValue("0", newReceivable.ItemCode);
				cmd.Parameters.AddWithValue("1", newReceivable.DateReceived);
				cmd.Parameters.AddWithValue("2", newReceivable.QuantityReceived);
				cmd.Parameters.AddWithValue("3", newReceivable.SupplierId);
				cmd.Parameters.AddWithValue("4", newReceivable.Cost);
				cmd.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				 MessageBox.Show("Database cannot be found\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				accessConnection.Close();
				
			}
			
		}
		

		void SaveBtnClick(object sender, EventArgs e)
		{
			bool errCheck = false;
			if(itemNameCmb.SelectedIndex > -1 && itemNameCmb.SelectedIndex < itemNameCmb.Items.Count)
			{
			   newReceivable.ItemCode = itemCodeList[itemNameCmb.SelectedIndex].ToString();
			   err4.Visible = false;
			}
			else
			{
				 errCheck = true;
				 err4.Visible = true;
			}
			double result = 0;
			if(double.TryParse(costTxtbox.Text, out result))
			{
			   err1.Visible = false;
			   newReceivable.Cost = result;
			    
			}
			else
			{
				errCheck = true;
				err1.Visible = true;
			}
			if(double.TryParse(quantityTxtbox.Text, out result))
			{
				err2.Visible = false;
				newReceivable.QuantityReceived = result;
			}
			else
			{
				err2.Visible = true;
				errCheck = true;
			}
			newReceivable.DateReceived = datepicker.Value.ToString("dd/MM/yyyy");
			
			if(supplierCmbox.SelectedIndex > -1 && itemNameCmb.SelectedIndex < itemNameCmb.Items.Count)
			{
			  newReceivable.SupplierId = supplierIdList[supplierCmbox.SelectedIndex];
			  err3.Visible = false;
			}
			else
			{
				errCheck = true;
				err3.Visible = true;
			}
			if(ValidatePassword.getInstance().IsEmpty(panel1))
			{
				errCheck = true;
				errorLb1.Visible = true;
			}
			errorLb1.Visible = false;
			if(errCheck)
			{
				return;
			}
			this.SaveReceivables();
			this.UpdateQuantity();
			ValidatePassword.getInstance().Clear(panel1);
		}
		
		void AddNewSupplierLinkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SupplierForm newForm = new SupplierForm();
			this.Enabled = false;
			newForm.Show();
		}
		void UpdateQuantity()
		{
			MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
			double temp = 0;
			newItem.Balance = newReceivable.QuantityReceived;
			newItem.ItemName = itemNameCmb.SelectedItem.ToString();
				 try
				 {
				 	//Update Item table
				 	accessConnection.Open();				 
					cmd = new OleDbCommand();
					cmd.Connection = accessConnection;
					 cmd.CommandText =  @"SELECT ItemQuantity, ItemBalance FROM ItemTbl where ItemName = [0]";
			         cmd.Parameters.AddWithValue("0", newItem.ItemName);
				cmd.Connection = accessConnection;
			 
				 accessReader =  cmd.ExecuteReader();
			  
				while(accessReader.Read())
				{
					 newItem.InitialQuantity= accessReader.GetDouble(0);
					 temp = accessReader.GetDouble(1);
				}
				     cmd = new OleDbCommand();
					cmd.Connection = accessConnection;
					newItem.InitialQuantity += temp;
				    newItem.Balance += temp;
				  	cmd.CommandText =  "UPDATE ItemTbl SET ItemBalance = [0], ItemQuantity = [2], LastUpdated = Date() WHERE ItemName = [3]";
				    cmd.Parameters.AddWithValue("0", newItem.Balance);
				    cmd.Parameters.AddWithValue("2", newItem.InitialQuantity);
				    cmd.Parameters.AddWithValue("3", newItem.ItemName);
				    cmd.ExecuteNonQuery();
					
					mainForm.RefreshItemStatus();
					mainForm.getNotifications();
				 }
				 catch(Exception ex)
				 {
				 	  MessageBox.Show("Unexpected Error: Data could not be updated\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );	
				 }
				 finally
				 {
				 	accessReader.Close();
				 	//Close connection to database
				 	accessConnection.Close();
				 }
		}
		
		void ItemNameCmbSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void ReceivableFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Form newForm = Application.OpenForms["Add_Item"] as Add_Item;
			if(newForm == null)
			{
				newForm =  Application.OpenForms["MainForm"] as MainForm;
				newForm.Enabled = true;
			}
			else
			{
				newForm.Enabled = true;
			}
		}
  }
}
