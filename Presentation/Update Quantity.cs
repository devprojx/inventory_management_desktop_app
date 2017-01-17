/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 17/07/2015
 * Time: 01:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using Inventory_System.Classes;
namespace Inventory_System
{
	/// <summary>
	/// Description of Update_Quantity.
	/// </summary>
	public partial class Update_Quantity : Form
	{
		//Declaration of Objects and Variables
		private OleDbConnection accessConnection = new OleDbConnection();
		OleDbDataAdapter adapter = new OleDbDataAdapter();
		OleDbCommand cmd = new OleDbCommand();
		OleDbDataReader accessReader ;
		Item newItem = new Item();
        int userId;
		public Update_Quantity()
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

        public Update_Quantity(int id)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            accessConnection.ConnectionString = Connection.getConnectionString();
            //
            // 
            //
            this.userId = id;
        }

        public void LoadItemName()
		{
			try
			{
				accessConnection.Open();
				//Populate item combo box
				cmd.CommandText =  @"SELECT ItemName FROM ItemTbl where statusId = 1";
				cmd.Connection = accessConnection;
				accessReader =  cmd.ExecuteReader();
				
				while(accessReader.Read())
				{
					itemNameCmb.Items.Add(accessReader.GetString(0) );
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
		
		void Update_QuantityLoad(object sender, EventArgs e)
		{
			LoadItemName();
		}
		//Check if textboxes are empty
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
		
		void UpdateBtnClick(object sender, EventArgs e)
		{
			MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
			if(IsEmpty() || itemNameCmb.SelectedIndex < 0)
			{
				errorlbl1.Visible = true;
				return;
			}
			newItem.ItemName = itemNameCmb.SelectedItem.ToString();
			errorlbl1.Visible = false;
			try
			{
				accessConnection.Open();
				cmd = new OleDbCommand();
				cmd.Connection = accessConnection;
				cmd.CommandText =  "UPDATE ItemTbl SET ItemBalance = [0], LastUpdated = Date() WHERE ItemName = [3]";
				cmd.Parameters.AddWithValue("0", newItem.Balance);
				cmd.Parameters.AddWithValue("3", newItem.ItemName);
				cmd.ExecuteNonQuery();
				mainForm.RefreshItemStatus();
				mainForm.getNotifications();
                Data_Access.DataAccess.LogAction(userId, "Updated item Quantity: " + newItem.ItemName + " to " + newItem.Balance);
                Utilities.GetOpenFormInstance().loadActivity();
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
				quantityTxt.Text = "";
				this.LoadQuantity(itemNameCmb.SelectedItem.ToString());
			}
		}
		//Load Items when the Item within the combo box is changed
		void ItemNameCmbSelectedIndexChanged(object sender, EventArgs e)
		{
			newItem.ItemName = itemNameCmb.SelectedItem.ToString();
			LoadQuantity(itemNameCmb.SelectedItem.ToString());
		}
		
		//Check if a number was entered
		void QuantityTxtLeave(object sender, EventArgs e)
		{
			double value;
			
			if(Double.TryParse(quantityTxt.Text, out value))
			{
				errorLbl.Visible = false;
				newItem.Balance = value;
				newItem.InitialQuantity = value;
			}
			else
			{
				errorLbl.Visible = true;
				quantityTxt.Text = "";
			}
		}
		
		//Load quantity of items in stock
		public void LoadQuantity(string name)
		{
			try
			{
				accessConnection.Open();
				cmd = new OleDbCommand();
				cmd.Connection = accessConnection;
				cmd.CommandText =  @"SELECT ItemBalance, Unit FROM ItemTbl where ItemName = [0] And statusId = 1";
				cmd.Parameters.AddWithValue("0", name);
				cmd.Connection = accessConnection;
				
				accessReader =  cmd.ExecuteReader();
				
				while(accessReader.Read())
				{
					label3.Text = " " +accessReader.GetDouble(0).ToString() + " " + accessReader.GetString(1);;
				}
			}
			catch(Exception e)
			{
				MessageBox.Show("Unexpected Error: Data could not be Load\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
			finally
			{
				//Close Reader and Connection to access
				accessReader.Close();
				accessConnection.Close();
			}
		}
		
		//Performs the following actions when the form is closed 
		void Update_QuantityFormClosed(object sender, FormClosedEventArgs e)
		{
			MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
			mainForm.Enabled = true;
		}
	}
}
