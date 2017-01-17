/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 16/07/2015
 * Time: 08:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.OleDb;
using System.Data;

namespace Inventory_System
{
	/// <summary>
	/// Description of Connection.
	/// </summary>
	public class Connection
	{
		//Connection string for access database
	    private static string  connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database\Inventory.mdb;Persist Security Info=True";
		private Connection()
		{
			
		}
		public static string getConnectionString()
		{		
			return connectionString;
		}
	}
}
