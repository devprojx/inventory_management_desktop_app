/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 22/07/2015
 * Time: 09:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.OleDb;
using Inventory_System.Classes;
using System.Windows.Forms;
namespace Inventory_System
{
	/// <summary>
	/// Description of DataAccess.
	/// </summary>
	public class DataAccess 
	{
		private static OleDbConnection accessConnection = new OleDbConnection();
		private Request newRequest = new Request();
		Item newItem = new Item();
		private static OleDbCommand cmd = new OleDbCommand();
		private static OleDbDataReader accessReader;
		
		public DataAccess()
		{
			accessConnection.ConnectionString = Connection.getConnectionString();
		}
			
		//Load quantity of item in stock
		public static void LoadQuantity(string name, string label)
		{
			accessConnection.ConnectionString = Connection.getConnectionString();
			try
			{
				accessConnection.Open();				 
				cmd = new OleDbCommand();
				cmd.Connection = accessConnection;
			     cmd.CommandText =  @"SELECT  ItemBalance, Unit FROM ItemTbl where ItemCode = [0]";
			     cmd.Parameters.AddWithValue("0", name);
				cmd.Connection = accessConnection;
			 
				 accessReader =  cmd.ExecuteReader();
			  
				while(accessReader.Read())
				{
					label = "" + accessReader.GetDouble(0).ToString() + " " + accessReader.GetString(1);
				}
			}
			catch(Exception e)
			{
				 MessageBox.Show("Database cannot be found" +e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				//Close Reader and Connection to access
				accessReader.Close();
				accessConnection.Close();
			}
		}
		
	}
}
