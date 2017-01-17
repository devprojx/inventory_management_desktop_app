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
	public partial class RequestForm : Form
	{
		List<string>  itemCodeList = new List<string>();
		
		private Request newRequest = new Request();
		Item newItem = new Item();
		OleDbCommand cmd = null;
		OleDbDataReader accessReader;
        int userId;
        string username;
        public RequestForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			//
			// 
			//
		}

        public RequestForm(string name, int id)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            userId = id;
            username = name;
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

			try
			{
                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {
                    double perCost = 0;
                    OleDbCommand cmd = new OleDbCommand();
                    Request newRequest = new Request();
                    accessConnection.Open();
                    cmd.Connection = accessConnection;
                    //Populate Object
                    newRequest.ItemCode = itemCodeList[itemNameCmb.SelectedIndex];
                    newRequest.DateRequested = DateTime.Today.ToShortDateString();
                    cmd.CommandText = @"SELECT ItemBalance,ItemUsed ,ItemName, cost From ItemTbl where itemCode = [0] and statusId = 1";
                    cmd.Parameters.AddWithValue("0", newRequest.ItemCode);
                    newRequest.AmountIssued = double.Parse(amountRequestedTxt.Text);
                    OleDbDataReader accessReader = cmd.ExecuteReader();

                    while (accessReader.Read())
                    {
                        newItem.Balance = accessReader.GetDouble(0);
                        newItem.ItemUsed = accessReader.GetDouble(1);
                        newItem.ItemName = accessReader.GetString(2);
                        perCost = accessReader.GetDouble(3);
                    }
                    if (newItem.Balance < newRequest.AmountIssued)
                    {
                        accessConnection.Close();
                        MessageBox.Show("\n" +
                                    newItem.Balance + " " + newItem.ItemName + " Remaining", "Item quantity is low", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    accessReader.Close();

                    newRequest.AmountRequested = double.Parse(amountRequestedTxt.Text);
                    //Insert Items into Request table
                    cmd = new OleDbCommand();
                    cmd.Connection = accessConnection;
                    cmd.CommandText = @"INSERT INTO RequestTbl(ItemCode, DateRequested, AmountRequested, IssuedBy, AmountIssued, DateIssued,
				                                 ReceivedBy, DateReceived, ItemName, status, PerCost)" +
                                        "VALUES     ([0], [1], [2], ' ', [4], [5], [6], [7], [8], 'R', [9])";

                    cmd.Parameters.AddWithValue("0", newRequest.ItemCode);
                    cmd.Parameters.AddWithValue("1", newRequest.DateRequested);
                    cmd.Parameters.AddWithValue("2", newRequest.AmountRequested);
                    cmd.Parameters.AddWithValue("4", newRequest.AmountIssued);
                    cmd.Parameters.AddWithValue("5", newRequest.DateRequested);
                    cmd.Parameters.AddWithValue("6", this.username);
                    cmd.Parameters.AddWithValue("7", newRequest.DateRequested);
                    cmd.Parameters.AddWithValue("8", newItem.ItemName);
                    cmd.Parameters.AddWithValue("9", perCost);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Request Made Successfully");  //inform the user

                    if (mainForm != null)
                    {
                        mainForm.RefreshItemStatus();
                        mainForm.getNotifications();
                        mainForm.RequestedItems();
                    }

                }
					       
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
                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {
                    cmd = new OleDbCommand();
                    accessConnection.Open();
                    
                    cmd.CommandText = @"SELECT  ItemName, itemCode FROM ItemTbl where statusId = 1";
                    cmd.Connection = accessConnection;

                    using (OleDbDataReader accessReader = cmd.ExecuteReader())
                    {

                        while (accessReader.Read())
                        {
                            itemNameCmb.Items.Add(accessReader.GetString(0));
                            itemCodeList.Add(accessReader.GetString(1));
                        }
                    }
                }
			}
			catch(Exception n)	
			{
				MessageBox.Show("Unexpected Error: d\n" + n, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );	
				
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

            itemNameCmb.Text = "";
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
            LoginForm loginForm = Application.OpenForms["LoginForm"] as LoginForm;

            if (loginForm != null)
                loginForm.Show();

        }
	
		//Load quantity of item in stock
		public void LoadQuantity(string name)
		{
		
			try
			{
                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {
                    OleDbCommand cmd = new OleDbCommand();
                    accessConnection.Open();
                    cmd.Connection = accessConnection;
                    cmd.CommandText = @"SELECT  ItemBalance, Unit FROM ItemTbl where ItemName = [0] and statusId = 1";
                    cmd.Parameters.AddWithValue("0", name);
                    cmd.Connection = accessConnection;

                    using (OleDbDataReader accessReader = cmd.ExecuteReader())
                    {

                        while (accessReader.Read())
                        {
                            label4.Text = "" + accessReader.GetDouble(0).ToString() + " " + accessReader.GetString(1);
                        }
                    }
                }
			}
			catch(Exception e)
			{
				  MessageBox.Show("Unexpected Error: Item quantity could not be loaded\n" +e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );	
			}
			
		}
		
	
		void ItemNameCmbSelectedIndexChanged(object sender, EventArgs e)
		{
				
				LoadQuantity(itemNameCmb.SelectedItem.ToString());
		}
	}
}
