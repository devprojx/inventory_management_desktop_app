/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 11/09/2015
 * Time: 12:53 PM
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
	/// Description of ReceivedLog.
	/// </summary>
	public partial class ReceivedLog : Form
	{
		private OleDbConnection accessConnection = new OleDbConnection();
		 OleDbDataAdapter adapter = new OleDbDataAdapter();
		public ReceivedLog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			accessConnection.ConnectionString = Connection.getConnectionString();
			InitializeComponent();
			LoadReceivedLog();
			//LoadReceivedLog();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	
		void FindTransactionByItemNameSupplierAndDate(string itemname, string date, string supplier)
		{
			try
			{
				accessConnection.Open();
				string sql  = @"SELECT ItemTbl.ItemName as `Item`,SupplierTbl.SupplierName as `Supplier`, ReceivedLogTbl.DateReceived as `Date Received`, ReceivedLogTbl.QuantityReceived as `Quantity Received`, 
                                (ReceivedLogTbl.QuantityReceived * PerCost) as `Cost` FROM (ReceivedLogTbl " +
					                        "INNER JOIN  ItemTbl ON ReceivedLogTbl.ItemCode = ItemTbl.ItemCode) INNER JOIN SupplierTbl ON ReceivedLogTbl.SupplierId = SupplierTbl.SupplierId" +
                                            " Where ItemTbl.ItemName like [0] AND ReceivedLogTbl.DateReceived like [1] AND SupplierTbl.SupplierName like [2] order by ReceivedLogTbl.DateReceived Desc";
				OleDbCommand cmd = new OleDbCommand();
				cmd.Connection = accessConnection;
				cmd.CommandText = sql;
				itemname = itemname + "%";
				supplier = supplier + "%";
				date = "%"+date+ "%";
				cmd.Parameters.AddWithValue("0", itemname);
				cmd.Parameters.AddWithValue("1", date);
				cmd.Parameters.AddWithValue("2", supplier);
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

		void LoadReceivedLog()
		{
			try
			{
				accessConnection.Open();
				string sql  = @"SELECT ItemTbl.ItemName as `Item`,SupplierTbl.SupplierName as `Supplier`, ReceivedLogTbl.DateReceived as `Date Received`, ReceivedLogTbl.QuantityReceived as `Quantity Received`, 
                                (ReceivedLogTbl.QuantityReceived * PerCost) as `Cost` FROM (ReceivedLogTbl " +
                              "INNER JOIN  ItemTbl ON ReceivedLogTbl.ItemCode = ItemTbl.ItemCode) INNER JOIN SupplierTbl ON ReceivedLogTbl.SupplierId = SupplierTbl.SupplierId order by ReceivedLogTbl.DateReceived Desc";
			    DataTable datatable = new DataTable();
				dataGridView1.DataSource = datatable;
	        	OleDbDataAdapter adapter = new OleDbDataAdapter(sql,accessConnection);
	    		adapter.Fill(datatable);
			}
			catch(Exception e)
			{
				 MessageBox.Show("Database cannot be found" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				accessConnection.Close();
			}
		}
		
		void SearchBtnClick(object sender, EventArgs e)
		{
			
			FindTransactionByItemNameSupplierAndDate(itemnameTxtBox.Text, dateMskTxtbx.Text, supplierTxtbox.Text);
		
		}
		
		void RefreshClick(object sender, EventArgs e)
		{
			LoadReceivedLog();
		}
		
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
		
		void FileToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dateMskTxtbx.MaskCompleted && supplierTxtbox.Text == "")
			{
				if(dataGridView1.Rows.Count != 0)
				{
					Report.GetInstance().ExportReceivableLog(dataGridView1, "Transaction logged for the month of "+dataGridView1[3,0].Value.ToString().Remove(0,2));
				}
			}
			else if(supplierTxtbox.Text != "" && supplierTxtbox.Text != " " && !dateMskTxtbx.MaskCompleted)
			{
				if(dataGridView1.Rows.Count != 0)
				{
				  Report.GetInstance().ExportReceivableLog(dataGridView1, "Transactions logged by "+dataGridView1[5,0].Value.ToString());
				}
			}
			else if(dateMskTxtbx.MaskCompleted && supplierTxtbox.Text != "")
			{
				if(dataGridView1.Rows.Count != 0)
				{
					Report.GetInstance().ExportReceivableLog(dataGridView1, "Transactions logged by "+dataGridView1[5, 0].Value.ToString() + " in the month of "+ dataGridView1[3,0].Value.ToString().Remove(0, 2));
				}
			}
			else if(itemnameTxtBox.Text != "" && dateMskTxtbx.MaskCompleted && supplierTxtbox.Text != "")
			{
				if(dataGridView1.Rows.Count != 0)
				{
					Report.GetInstance().ExportReceivableLog(dataGridView1, "Transactions for "+ dataGridView1[2, 0].Value.ToString() +" logged by "+dataGridView1[5, 0].Value.ToString() + " in the month of "+ dataGridView1[3,0].Value.ToString().Remove(0, 2));
				}
			}
			else if(itemnameTxtBox.Text != "" && !dateMskTxtbx.MaskCompleted && supplierTxtbox.Text == "")
			{
				if(dataGridView1.Rows.Count != 0)
				{
					Report.GetInstance().ExportReceivableLog(dataGridView1, "Transactions for "+ dataGridView1[2, 0].Value.ToString());
				}
			}
			else if(itemnameTxtBox.Text != "" && dateMskTxtbx.MaskCompleted && supplierTxtbox.Text == "")
			{
				if(dataGridView1.Rows.Count != 0)
				{
					Report.GetInstance().ExportReceivableLog(dataGridView1, "Transactions for "+ dataGridView1[2, 0].Value.ToString() +" logged by in the month of "+ dataGridView1[3,0].Value.ToString().Remove(0, 2));
				}
			}
			else if(itemnameTxtBox.Text != "" && !dateMskTxtbx.MaskCompleted && supplierTxtbox.Text != "")
			{
				if(dataGridView1.Rows.Count != 0)
				{
					Report.GetInstance().ExportReceivableLog(dataGridView1, "Transactions for "+ dataGridView1[2, 0].Value.ToString() +" logged by "+ dataGridView1[5, 0].Value.ToString());
				}
			}
			else
			{
		       Report.GetInstance().ExportReceivableLog(dataGridView1, "All");
			}
		}

        private void ReceivedLog_Load(object sender, EventArgs e)
        {

        }

        private void dateMskTxtbx_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
