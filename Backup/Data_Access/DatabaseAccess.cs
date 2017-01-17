/*
 * Created by SharpDevelop.
 * User: Vstudent
 * Date: 7/30/2015
 * Time: 2:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using Inventory_System.Classes;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Inventory_System.Data_Access
{
	/// <summary>
	/// Description of DataAccess.
	/// </summary>
	public class DataAccess
	{	
		OleDbConnection accessConnection = new OleDbConnection();
		OleDbCommand cmd = new OleDbCommand();
		OleDbDataAdapter accessAdapter;
		DataTable table = new DataTable();
		
		
		private static DataAccess instance = null;
		
		private DataAccess()
		{
			accessConnection.ConnectionString = Connection.getConnectionString();
		}
		public static DataAccess GetInstance()
		{
			if(instance == null)
			{
				instance = new DataAccess();
			}
			return instance;
		}
		
		public void GetOverallReport(out DataTable table2)
		{
			table = new DataTable();
			table2 = table;
			accessConnection.Open();
			try
			{
				cmd = new OleDbCommand();
				cmd.Connection = accessConnection;
				cmd.CommandText = @"Select ItemUsageTbl.ItemName,  SUM(ItemUsageTbl.AmountUsed) AS 'Total', ItemTbl.Unit FROM ItemUsageTbl INNER JOIN ItemTbl ON (ItemUsageTbl.ItemCode = ItemTbl.ItemCode) GROUP BY ItemUsageTbl.ItemName, ItemTbl.Unit";		
				accessAdapter = new OleDbDataAdapter(cmd);
				accessAdapter.Fill(table);
				table2 = table;
				
			}
			catch(Exception e)
			{
				MessageBox.Show(""+e);
			}
			finally
			{
				accessConnection.Close();
			}
			
		}
		public void GetAllReportByMonthAndYear( string month, string year, out DataTable table2)
		{
			table = new DataTable();
			table2 = table;
			string date;
			accessConnection.Open();
			
				try
				{
					cmd = new OleDbCommand();
					cmd.Connection = accessConnection;
					if(month != null)
					{
					date =  "%" + month + "/" + year + "%";
					}
					else
					{
						date =  "%" + year + "%";
					}
					cmd.CommandText = @"Select ItemUsageTbl.ItemName,  SUM(ItemUsageTbl.AmountUsed) AS 'Total', ItemTbl.Unit FROM ItemUsageTbl INNER JOIN ItemTbl ON (ItemUsageTbl.ItemCode = ItemTbl.ItemCode) WHERE ItemUsageTbl.UsedDate LIKE [1]GROUP BY ItemUsageTbl.ItemName, ItemTbl.Unit";
					cmd.Parameters.AddWithValue("1", date);
					accessAdapter = new OleDbDataAdapter(cmd);
					accessAdapter.Fill(table);
					table2 = table;
					
				}
				catch(Exception e)
				{
					MessageBox.Show(""+e);
				}
				finally
				{
					accessConnection.Close();
				}
			
			
		}
	}
}
