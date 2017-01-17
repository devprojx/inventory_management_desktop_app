/*
 * Created by SharpDevelop.
 * User: VStudent
 * Date: 16/07/2015
 * Time: 05:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using Inventory_System.Classes;
namespace Inventory_System
{
	/// <summary>
	/// Description of InventoryTransaction.
	/// </summary>
	public partial class InventoryTransaction : Form
	{
		
		
		 private OleDbConnection accessConnection = new OleDbConnection();
		 OleDbDataAdapter adapter = new OleDbDataAdapter();
		  
		public InventoryTransaction()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			//Set connection string
			accessConnection.ConnectionString = Connection.getConnectionString();
			
			//
			//
		}
		
		//Retrieve Items from inventory
		void LoadTransactionLog()
		{
			try
			{
				accessConnection.Open();
				string sql  = "SELECT *  FROM RequestTbl ";
			    DataTable datatable = new DataTable();
				dataGridView1.DataSource = datatable;
	        	OleDbDataAdapter adapter = new OleDbDataAdapter(sql,accessConnection);
	    		adapter.Fill(datatable);
			}
			catch(Exception)
			{
				 MessageBox.Show("Database cannot be found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				accessConnection.Close();
			}
		}
		
		//Load items in inventory on Shown event
		void InventoryTransactionShown(object sender, EventArgs e)
		{
			LoadTransactionLog();
		}
		
		//Enable Parent form onclosed event
		void InventoryTransactionFormClosed(object sender, FormClosedEventArgs e)
		{
			MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
			mainForm.Enabled = true;
		}
		
		//Stores data into datagridview on button click event based on the filter fields
		void Button1Click(object sender, EventArgs e)
		{
			if(dateMskTxtbx.MaskCompleted && nameTxtBox.Text == "" && itemnameTxtBox.Text == "")
			{
			   string temp;
			   temp = "%" + dateMskTxtbx.Text + "%";
			   FindTransactionByDate(temp);
			   return;
			}
			else if(itemnameTxtBox.Text != "" && !dateMskTxtbx.MaskCompleted && nameTxtBox.Text == "")
			{
				FindTransactionByItemName(itemnameTxtBox.Text);
				return;
			}
			else if(itemnameTxtBox.Text != "" && dateMskTxtbx.MaskCompleted && nameTxtBox.Text != "")
			{
				 string temp;
			     temp = "%" + dateMskTxtbx.Text + "%";
				FindTransactionByDateNameAndItemname(temp, nameTxtBox.Text, itemnameTxtBox.Text);
				return;
			}
			else if(itemnameTxtBox.Text != "" && nameTxtBox.Text != "" && !dateMskTxtbx.MaskCompleted)
			{
				FindTransactionByNameAndItemname(nameTxtBox.Text, itemnameTxtBox.Text);
				return;
			}
			else if(itemnameTxtBox.Text != "" && dateMskTxtbx.MaskCompleted && nameTxtBox.Text == "")
			{
				 string temp;
			     temp = "%" + dateMskTxtbx.Text + "%";
				FindTransactionByDateAndItemname(temp, itemnameTxtBox.Text);
				return;
			}
			else if(nameTxtBox.Text != "" && (!dateMskTxtbx.MaskCompleted) && itemnameTxtBox.Text == "")
			{
			   FindTransactionByName(nameTxtBox.Text);
			   return;
			}
			else if(dateMskTxtbx.MaskCompleted && nameTxtBox.Text != "" && itemnameTxtBox.Text == "")
			{
				 string temp;
			     temp = "%" + dateMskTxtbx.Text + "%";
				 FindTransactionByDateAndName(temp, nameTxtBox.Text);
				return;
			}
			LoadTransactionLog();
		}
		
		//Get data from data base on the date and store them in a datatable
		void FindTransactionByDate(string date)
		{
			try
			{
				accessConnection.Open();
				string sql  = "SELECT *  FROM RequestTbl Where  DateIssued like [0]";
				OleDbCommand cmd = new OleDbCommand();
				cmd.Connection = accessConnection;
				cmd.CommandText = sql;
				cmd.Parameters.AddWithValue("0", date);
			    DataTable datatable = new DataTable();
				dataGridView1.DataSource = datatable;
	        	OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
	    		adapter.Fill(datatable);
			}
			catch(Exception e)
			{
				 MessageBox.Show("Database cannot be found" +e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				accessConnection.Close();
			}
		}
		//Get data from data base on the itemname and store them in a datatable
		void FindTransactionByItemName(string itemname)
		{
			try
			{
				accessConnection.Open();
				string sql  = "SELECT *  FROM RequestTbl Where ItemName like [0] ";
				OleDbCommand cmd = new OleDbCommand();
				cmd.Connection = accessConnection;
				cmd.CommandText = sql;
				itemname = itemname+"%";
				cmd.Parameters.AddWithValue("0", itemname);
			    DataTable datatable = new DataTable();
				dataGridView1.DataSource = datatable;
	        	OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
	    		adapter.Fill(datatable);
			}
			catch(Exception e)
			{
				 MessageBox.Show("Database cannot be found" +e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				accessConnection.Close();
			}
		}
		//Get data from data base on the username, date and itemname and store them in a datatable
		void FindTransactionByDateNameAndItemname(string date, string name, string itemname)
		{
			try
			{
				accessConnection.Open();
				string sql  = "SELECT *  FROM RequestTbl Where  DateIssued like [0] and IssuedBy like [1] and ItemName like [2]";
				OleDbCommand cmd = new OleDbCommand();
				cmd.Connection = accessConnection;
				cmd.CommandText = sql;
				name = name+"%";
				itemname = itemname + "%";
				cmd.Parameters.AddWithValue("0", date);
				cmd.Parameters.AddWithValue("1", name);
				cmd.Parameters.AddWithValue("2", itemname);
			    DataTable datatable = new DataTable();
				dataGridView1.DataSource = datatable;
	        	OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
	    		adapter.Fill(datatable);
			}
			catch(Exception e)
			{
				 MessageBox.Show("Database cannot be found" +e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				accessConnection.Close();
			}
		}
		
		//Get data from database based on the username and itemname and store them in a datatable
		void FindTransactionByNameAndItemname( string name, string itemname)
		{
			try
			{
				accessConnection.Open();
				string sql  = "SELECT *  FROM RequestTbl Where IssuedBy like [1] and Itemname like [2]";
				OleDbCommand cmd = new OleDbCommand();
				cmd.Connection = accessConnection;
				cmd.CommandText = sql;
				name = name+"%";
				itemname = itemname + "%";
				cmd.Parameters.AddWithValue("1", name);
				cmd.Parameters.AddWithValue("2", itemname);
			    DataTable datatable = new DataTable();
				dataGridView1.DataSource = datatable;
	        	OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
	    		adapter.Fill(datatable);
			}
			catch(Exception e)
			{
				 MessageBox.Show("Database cannot be found" +e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				accessConnection.Close();
			}
		}
		//Get data from data base on the date and itemname and store them in a datatable
		void FindTransactionByDateAndItemname(string date, string itemname)
		{
			try
			{
				accessConnection.Open();
				string sql  = "SELECT *  FROM RequestTbl Where DateIssued like [0] and Itemname like [2]";
				OleDbCommand cmd = new OleDbCommand();
				cmd.Connection = accessConnection;
				cmd.CommandText = sql;
				
				itemname = itemname + "%";
				cmd.Parameters.AddWithValue("0", date);
				cmd.Parameters.AddWithValue("2", itemname);
			    DataTable datatable = new DataTable();
				dataGridView1.DataSource = datatable;
	        	OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
	    		adapter.Fill(datatable);
			}
			catch(Exception e)
			{
				 MessageBox.Show("Database cannot be found" +e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				accessConnection.Close();
			}
		}
		
			//Get data from database based on the date and username and store them in a datatable
		void FindTransactionByDateAndName(string date, string name)
		{
			try
			{
				accessConnection.Open();
				string sql  = "SELECT *  FROM RequestTbl Where DateIssued like [0] and IssuedBy like [1]";
				OleDbCommand cmd = new OleDbCommand();
				cmd.Connection = accessConnection;
				cmd.CommandText = sql;
				name = name+"%";
				cmd.Parameters.AddWithValue("0", date);
				cmd.Parameters.AddWithValue("1", name);
			    DataTable datatable = new DataTable();
				dataGridView1.DataSource = datatable;
	        	OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
	    		adapter.Fill(datatable);
			}
			catch(Exception e)
			{
				 MessageBox.Show("Database cannot be found" +e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				accessConnection.Close();
			}
		}
		//Get data from database based on the username and store them in a datatable
		void FindTransactionByName(string name)
		{
			try
			{
				accessConnection.Open();
				string sql  = "SELECT *  FROM RequestTbl Where IssuedBy like [0]";
				OleDbCommand cmd = new OleDbCommand();
				cmd.Connection = accessConnection;
				cmd.CommandText = sql;
				name = name+"%";
				cmd.Parameters.AddWithValue("0", name);
			    DataTable datatable = new DataTable();
				dataGridView1.DataSource = datatable;
	        	OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
	    		adapter.Fill(datatable);
			}
			catch(Exception e)
			{
				 MessageBox.Show("Database cannot be found" +e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				accessConnection.Close();
			}
		}
		
		//Refresh button click event
		void RefreshClick(object sender, EventArgs e)
		{
			refresh.BackColor = Color.LightSteelBlue;
			LoadTransactionLog();
		}
		
/*----------------------Create animation effect on refresh button----------------------*/
		void RefreshMouseEnter(object sender, EventArgs e)
		{
			refresh.Width = 35;
			refresh.Height = 28;
			
		}
		void RefreshMouseLeave(object sender, EventArgs e)
		{
			refresh.Width = 32;
			refresh.Height = 23;
			refresh.BackColor = Color.Transparent;
		}
/*--------------------------------------------------------------------------------------*/
	
	    //Create pdf file based on the items generated in datagridview
		void SaveAsPdfToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dateMskTxtbx.MaskCompleted && nameTxtBox.Text == "")
			{
				if(dataGridView1.Rows.Count != 0)
				{
					Report.GetInstance().ExportTransactionLog(dataGridView1, "Transaction logged for the month of "+dataGridView1[3,0].Value.ToString().Remove(0,2));
				}
			}
			else if(nameTxtBox.Text != "" && nameTxtBox.Text != " " && !dateMskTxtbx.MaskCompleted)
			{
				if(dataGridView1.Rows.Count != 0)
				{
				  Report.GetInstance().ExportTransactionLog(dataGridView1, "Transactions logged by "+dataGridView1[5,0].Value.ToString());
				}
			}
			else if(dateMskTxtbx.MaskCompleted && nameTxtBox.Text != "")
			{
				if(dataGridView1.Rows.Count != 0)
				{
					Report.GetInstance().ExportTransactionLog(dataGridView1, "Transactions logged by "+dataGridView1[5, 0].Value.ToString() + " in the month of "+ dataGridView1[3,0].Value.ToString().Remove(0, 2));
				}
			}
			else if(itemnameTxtBox.Text != "" && dateMskTxtbx.MaskCompleted && nameTxtBox.Text != "")
			{
				if(dataGridView1.Rows.Count != 0)
				{
					Report.GetInstance().ExportTransactionLog(dataGridView1, "Transactions for "+ dataGridView1[2, 0].Value.ToString() +" logged by "+dataGridView1[5, 0].Value.ToString() + " in the month of "+ dataGridView1[3,0].Value.ToString().Remove(0, 2));
				}
			}
			else if(itemnameTxtBox.Text != "" && !dateMskTxtbx.MaskCompleted && nameTxtBox.Text == "")
			{
				if(dataGridView1.Rows.Count != 0)
				{
					Report.GetInstance().ExportTransactionLog(dataGridView1, "Transactions for "+ dataGridView1[2, 0].Value.ToString());
				}
			}
			else if(itemnameTxtBox.Text != "" && dateMskTxtbx.MaskCompleted && nameTxtBox.Text == "")
			{
				if(dataGridView1.Rows.Count != 0)
				{
					Report.GetInstance().ExportTransactionLog(dataGridView1, "Transactions for "+ dataGridView1[2, 0].Value.ToString() +" logged by in the month of "+ dataGridView1[3,0].Value.ToString().Remove(0, 2));
				}
			}
			else if(itemnameTxtBox.Text != "" && !dateMskTxtbx.MaskCompleted && nameTxtBox.Text != "")
			{
				if(dataGridView1.Rows.Count != 0)
				{
					Report.GetInstance().ExportTransactionLog(dataGridView1, "Transactions for "+ dataGridView1[2, 0].Value.ToString() +" logged by "+ dataGridView1[5, 0].Value.ToString());
				}
			}
			else
			{
		       Report.GetInstance().ExportTransactionLog(dataGridView1, "All Transactions ");
			}
		}
		
		
		void ExportAsPdfToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
	}
}
