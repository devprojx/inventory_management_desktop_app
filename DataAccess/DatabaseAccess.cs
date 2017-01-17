
/*
 * Created by SharpDevelop.
 * User: Vstudent
 * Date: 7/30/2015
 * Time: 2:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

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
		
		public static string FindItemIndex(string itemname)
        {
            string index = "";
            try
            {
                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {
                    OleDbCommand cmd = new OleDbCommand();
                    accessConnection.Open();
                    cmd.CommandText = @"SELECT ItemCode, ItemName FROM ItemTbl where itemName = '"+itemname+"'";
                    cmd.Connection = accessConnection;

                    OleDbDataReader accessReader = cmd.ExecuteReader();

                    while (accessReader.Read())
                    {
                        index = accessReader.GetString(0);
                    }
                }


            }
            catch (Exception et)
            {
                MessageBox.Show("Database cannot be found\n" + et, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return index;
        }

        public static void  LogAction(int id, string action)
        {

            try
            {
                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {
                    accessConnection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = accessConnection;
                    cmd.CommandText = @"INSERT INTO UserActions(passwordID, Actions, [TimeStamp]) VALUES ([0], [1], NOW())";
                    cmd.Parameters.AddWithValue("0", id);
                    cmd.Parameters.AddWithValue("1", action);

                    cmd.ExecuteNonQuery();
                }
           
              
            }
            catch (Exception et)
            {
                MessageBox.Show("Database cannot be found\n" + et, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
             
            }
        }


        public void GetAllReportByMonthAndYear( string firstDate, string secondDate, int limit, out DataTable table2, int categoryId, int order)
		{
			table = new DataTable();
			table2 = table;
            DateTime toDate = DateTime.ParseExact(secondDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            
            DateTime fromDate = DateTime.ParseExact(firstDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
			accessConnection.Open();
            string categoryIdQuery = (categoryId > 1) ? " AND CategoryId = " + categoryId.ToString() : "";
            string ext = (limit>0)? "Top "+ limit: "";
				try
				{
					cmd = new OleDbCommand();
					cmd.Connection = accessConnection;
					if(order == 1)
					   cmd.CommandText = @"Select " + ext + " RequestTbl.ItemName as `Item`,  SUM(RequestTbl.AmountRequested) AS `Total`, ItemTbl.Unit, (PerCost * Sum(AmountRequested)) As `Cost ($)` FROM RequestTbl INNER JOIN ItemTbl ON RequestTbl.ItemCode = ItemTbl.ItemCode Where RequestTbl.DateReceived >= [2] AND RequestTbl.DateReceived <= [3] " + categoryIdQuery + " GROUP by RequestTbl.ItemName, ItemTbl.Unit, PerCost ";
                    else if(order == 2)
                       cmd.CommandText = @"Select " + ext + " RequestTbl.ItemName as `Item`,  SUM(RequestTbl.AmountRequested) AS `Total`, ItemTbl.Unit, (PerCost * Sum(AmountRequested)) As `Cost ($)` FROM RequestTbl INNER JOIN ItemTbl ON RequestTbl.ItemCode = ItemTbl.ItemCode Where RequestTbl.DateReceived >= [2] AND RequestTbl.DateReceived <= [3] " + categoryIdQuery + " GROUP by RequestTbl.ItemName, ItemTbl.Unit, PerCost  ";
                    else if(order == 3)
                       cmd.CommandText = @"Select " + ext + " RequestTbl.ItemName as `Item`,  SUM(RequestTbl.AmountRequested) AS `Total`, ItemTbl.Unit, (PerCost * Sum(AmountRequested)) As `Cost ($)` FROM RequestTbl INNER JOIN ItemTbl ON RequestTbl.ItemCode = ItemTbl.ItemCode Where RequestTbl.DateReceived >= [2] AND RequestTbl.DateReceived <= [3] And  PerCost <> 0 " + categoryIdQuery + " GROUP by RequestTbl.ItemName, ItemTbl.Unit, PerCost Order by PerCost  DESC";
                    else if (order == 4)
                      cmd.CommandText = @"Select " + ext + " RequestTbl.ItemName as `Item`,  SUM(RequestTbl.AmountRequested) AS `Total`, ItemTbl.Unit, (PerCost * Sum(AmountRequested)) As `Cost ($)` FROM RequestTbl INNER JOIN ItemTbl ON RequestTbl.ItemCode = ItemTbl.ItemCode Where RequestTbl.DateReceived >= [2] AND RequestTbl.DateReceived <= [3] And  PerCost <> 0 " + categoryIdQuery + " GROUP by RequestTbl.ItemName, ItemTbl.Unit, PerCost Order by PerCost  ASC";


                   cmd.Parameters.AddWithValue("2", fromDate);
                    cmd.Parameters.AddWithValue("3", toDate);
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
