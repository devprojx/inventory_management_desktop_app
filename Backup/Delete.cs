/*
 * Created by SharpDevelop.
 * User: Vstudent
 * Date: 7/17/2015
 * Time: 9:57 AM
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
	/// Description of Delete.
	/// </summary>
	public partial class Delete : Form
	{
		private OleDbConnection accessConnection = new OleDbConnection();
		OleDbDataAdapter adapter = new OleDbDataAdapter();
		OleDbCommand cmd = new OleDbCommand();
		OleDbDataReader accessReader ;
		Item newItem = new Item();
		public Delete()
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
		
		void DeleteBtnClick(object sender, EventArgs e)
		{
			 DeleteItem();
		}
		public void DeleteItem()
		{
			DialogResult dialog = new DialogResult();
			if(string.IsNullOrEmpty(newItem.ItemName))
			   {
			   	return;
			   }
			dialog =  MessageBox.Show("Are you sure you want to delete item? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			     MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
				try
				{
					if(dialog == DialogResult.Yes)
					{
						int x = 2;
					accessConnection.Open();
			        //Populate item combo box
					cmd.CommandText =  @"Update ItemTbl Set Status  = [0] WHERE ItemName = [1]";
					cmd.Parameters.AddWithValue("0", x);
					cmd.Parameters.AddWithValue("1", newItem.ItemName);
					 cmd.Connection = accessConnection;
				    
					 accessReader =  cmd.ExecuteReader();
					 if(accessReader.HasRows)
					 {
						while(accessReader.Read())
						{
							itemNameCmb.Items.Add(accessReader.GetString(0));
						}
					}
					 MessageBox.Show("Item was Deleted");
					 mainForm.RefreshItemStatus();
					 mainForm.getNotifications();
					}
					else
					{
						MessageBox.Show("Item was not Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);	
					}
				}
				catch(Exception e)
				{
					MessageBox.Show("Unexpected Error: " );
				}
				finally
				{
					itemNameCmb.Text = "";
					//Close Reader and Connection to access
					accessReader.Close();
					accessConnection.Close();
					refreshNames();
				}
			
		}
		
		void ItemNameCmbSelectedIndexChanged(object sender, EventArgs e)
		{
			newItem.ItemName = itemNameCmb.SelectedItem.ToString();
		}
		
		void DeleteLoad(object sender, EventArgs e)
		{
			refreshNames();
		}
		void refreshNames()
		{
			try
			{
				itemNameCmb.Items.Clear();
				accessConnection.Open();
		        //Populate item combo box
		        cmd = new OleDbCommand();
				cmd.CommandText =  @"SELECT ItemName FROM ItemTbl Where Status = 1";
				cmd.Connection = accessConnection;
			 
				 accessReader =  cmd.ExecuteReader();
			  
				while(accessReader.Read())
				{
					itemNameCmb.Items.Add(accessReader.GetString(0));
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Connection Issue...  ");
			}
			finally
			{
				//Close Reader and Connection to access
				accessReader.Close();
				accessConnection.Close();
			}
		}
		
		void DeleteFormClosed(object sender, FormClosedEventArgs e)
		{
			MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
			mainForm.Enabled = true;
		}
		

		
	}
}
