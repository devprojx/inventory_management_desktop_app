/*
 * Created by SharpDevelop.
 * User: VStudent
 * Date: 16/07/2015
 * Time: 07:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections.Generic;

using Inventory_System.Classes;

namespace Inventory_System
{
	/// <summary>
	/// Description of NewRequest.
	/// </summary>
	public partial class NewRequest : Form
	{
		List<string>  itemCodeList = new List<string>();
		private OleDbConnection accessConnection = new OleDbConnection();
		private Request newRequest = new Request();
		Item newItem = new Item();
		OleDbCommand cmd = new OleDbCommand();
		OleDbDataReader accessReader;
		public NewRequest()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			accessConnection.ConnectionString = Connection.getConnectionString();
			//
			// 
			//
		}
		
		
		
		public void InsertRequest()
		{
			 MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
		  	if(IsEmpty() || itemNameCmb.SelectedIndex < 0)
				{
					errorLb1.Visible = true;
				  return;
				}
		     errorLb1.Visible = false;
			OleDbCommand cmd = new OleDbCommand();
			cmd.Connection = accessConnection;
		
			try
			{
			     //Populate Object
		        accessConnection.Open();
		        newRequest.ItemCode = itemCodeList[itemNameCmb.SelectedIndex];
				newRequest.DateRequested = dateRequested.Value.Date.ToString("dd/MM/yyyy");
				newRequest.Issuedby = issuedByTxt.Text;
				newRequest.DateIssued = dateIssued.Value.Date.ToString("dd/MM/yyyy");
				newRequest.ReceivedBy = receivedByTxt.Text;
				newRequest.DateReceived = dateReceived.Value.Date.ToString("dd/MM/yyyy");
					  
				  cmd.CommandText = @"SELECT ItemBalance,ItemUsed ,ItemName From ItemTbl where itemCode = [0] and statusId = 1";
				  cmd.Parameters.AddWithValue("0", newRequest.ItemCode);
				  accessReader = cmd.ExecuteReader();
		    		  
		    		  while(accessReader.Read())
					  {
						newItem.Balance =  accessReader.GetDouble(0);
						newItem.ItemUsed = accessReader.GetDouble(1);
						newItem.ItemName = accessReader.GetString(2);
					  } 
		    		  if(newItem.Balance < newRequest.AmountIssued)
		    		  {
		    		  	accessConnection.Close();
		    		  	MessageBox.Show("\n" +
				  	                newItem.Balance + " " + newItem.ItemName + " Remaining", "Item quantity is low", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		    		  	return;
		    		  }
		    		 accessReader.Close();
		    		        
		    		 		//Calculates Item remaining after request
				    		newItem.Balance -= newRequest.AmountIssued;
							newItem.ItemUsed += newRequest.AmountIssued;
				    		
						
							//Insert Items into Request table
						    cmd = new OleDbCommand();
							cmd.Connection =  accessConnection;
							cmd.CommandText =  @"INSERT INTO RequestTbl(ItemCode, DateRequested, AmountRequested, IssuedBy, AmountIssued, DateIssued,
				                                 ReceivedBy, DateReceived, ItemName)" +
					            				"VALUES     ([0], [1], [2], [3], [4], [5], [6], [7], [8])";
							cmd.Parameters.AddWithValue("0", newRequest.ItemCode);
							cmd.Parameters.AddWithValue("1", newRequest.DateRequested);
							cmd.Parameters.AddWithValue("2", newRequest.AmountRequested);
							cmd.Parameters.AddWithValue("3", newRequest.Issuedby);
							cmd.Parameters.AddWithValue("4", newRequest.AmountIssued);
							cmd.Parameters.AddWithValue("5", newRequest.DateIssued);
							cmd.Parameters.AddWithValue("6", newRequest.ReceivedBy);
							cmd.Parameters.AddWithValue("7", newRequest.DateReceived);
							cmd.Parameters.AddWithValue("8", newItem.ItemName);
							
				    		cmd.ExecuteNonQuery();
				    		    
				    	    //Update Item table
				    		cmd = new OleDbCommand();
				    		cmd.Connection = accessConnection;
						  	cmd.CommandText =  @"UPDATE ItemTbl SET ItemBalance = [0], ItemUsed = [1] WHERE ItemCode = [2]";
						    cmd.Parameters.AddWithValue("0", newItem.Balance);
						    cmd.Parameters.AddWithValue("1", newItem.ItemUsed);
						    cmd.Parameters.AddWithValue("2", newRequest.ItemCode);
						    cmd.ExecuteNonQuery();
						    AddToItemUsedTbl(newItem, newRequest);
							 MessageBox.Show("Record inserted Successfully");  //inform the user
							 
							 mainForm.RefreshItemStatus();
					       mainForm.getNotifications();
					       
				}
				catch(Exception c)
				{
					 MessageBox.Show("Unexpected Error: Data could not be saved\n" + c, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );	
				}
				finally
				{
					Clear();
				}	
		}
		public void LoadItemCode()
		{
			try
			{
				accessConnection.Open();
				cmd = new OleDbCommand();
				cmd.CommandText =  @"SELECT  ItemName, itemCode FROM ItemTbl where statusId = 1";
				cmd.Connection = accessConnection;
			
				 accessReader =  cmd.ExecuteReader();
			  
				while(accessReader.Read())
				{
					itemNameCmb.Items.Add(accessReader.GetString(0));
					itemCodeList.Add(accessReader.GetString(1));
				}
			}
			catch(Exception n)	
			{
				MessageBox.Show("Unexpected Error: d\n" + n, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );	
				
			}
			finally
			{
			
				accessConnection.Close();
			}
		}
		
		//Check if controls are empty
		public bool IsEmpty()
		{
			foreach(Control control in panel1.Controls)
			{
				if(control.GetType().Name.ToString()== "TextBox")
				{
					if(String.IsNullOrEmpty(control.Text))
					return true;
				}
			}
			return false;
		}
		void NewRequestLoad(object sender, EventArgs e)
		{
			LoadItemCode();
		}
		
		void SubmitClick(object sender, EventArgs e)
		{
			InsertRequest();   
			accessConnection.Close();
			if(itemNameCmb.SelectedIndex >= 0)
			{
				LoadQuantity(itemNameCmb.SelectedItem.ToString());
			}
		}
		

		void AmountRequestedTxtLeave(object sender, EventArgs e)
		{
					
			double value;
			
				if(Double.TryParse(amountRequestedTxt.Text, out value))
				{
					errorLbl2.Visible = false;
					newRequest.AmountRequested = value;
				}
				else
				{
					amountRequestedTxt.Text = "";
					errorLbl2.Visible = true;
				}
		}
		
		
		void AmountIssuedTxtLeave(object sender, EventArgs e)
		{
			double value;
			
				if(Double.TryParse(amountIssuedTxt.Text, out value))
				{
					errorLbl3.Visible = false;
					newRequest.AmountIssued = value;
				}
				else
				{
					amountIssuedTxt.Text = "";
					errorLbl3.Visible = true;	
				}
			
		}
		public void Clear()
		{
			foreach(Control c in panel1.Controls)
			{
				if(c.GetType() .Name.ToString()== "TextBox")
				{
					c.Text = "";
				}
			}
		}

		void NewRequestFormClosed(object sender, FormClosedEventArgs e)
		{
			MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
			mainForm.Enabled = true;
		
		}
	
		//Load quantity of item in stock
		public void LoadQuantity(string name)
		{
			accessConnection.Open();
			try
			{
								 
				cmd = new OleDbCommand();
				cmd.Connection = accessConnection;
			     cmd.CommandText =  @"SELECT  ItemBalance, Unit FROM ItemTbl where ItemName = [0] and statusId = 1";
			     cmd.Parameters.AddWithValue("0", name);
				cmd.Connection = accessConnection;
			 
				 accessReader =  cmd.ExecuteReader();
			  
				while(accessReader.Read())
				{
					label4.Text = "" + accessReader.GetDouble(0).ToString() + " " + accessReader.GetString(1);
				}
			}
			catch(Exception e)
			{
				  MessageBox.Show("Unexpected Error: Item quantity could not be loaded\n" +e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );	
			}
			finally
			{
				//Close Reader and Connection to access
				accessReader.Close();
				accessConnection.Close();
			}
		}
		
		void AddToItemUsedTbl(Item newItem, Request newResquest)
		{
				  try
				  {
						    cmd = new OleDbCommand();
							cmd.Connection =  accessConnection;
							cmd.CommandText =  @"INSERT INTO ItemUsageTbl(ItemCode, ItemName, AmountUsed, UsedDate)" +
					            				"VALUES ([0], [1], [2], [3])";
							cmd.Parameters.AddWithValue("0", newRequest.ItemCode);
							cmd.Parameters.AddWithValue("1", newItem.ItemName);
							cmd.Parameters.AddWithValue("2", newRequest.AmountIssued);
							cmd.Parameters.AddWithValue("3", newRequest.DateRequested);
		
				    		 cmd.ExecuteNonQuery();
	
				}
				catch(Exception t)
				{
					 MessageBox.Show("Unexpected Error: Data could not be saved\n" +t , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );	
				}
				finally
				{
					//close the connection
					Clear();	
					
				}	
		}
		
		void ItemNameCmbSelectedIndexChanged(object sender, EventArgs e)
		{
				
				LoadQuantity(itemNameCmb.SelectedItem.ToString());
		}
	}
}
