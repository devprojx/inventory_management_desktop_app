/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 25/07/2015
 * Time: 11:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace Inventory_System.Classes
{
	/// <summary>
	/// Description of Validate.
	/// </summary>
	public class Utilities
	{
		public static Utilities instance = null;
			OleDbCommand cmd = new OleDbCommand();
			OleDbConnection accessConnection = new OleDbConnection();
			OleDbDataReader accessReader ;
			
		private Utilities()
		{
			
		}

        public static string getDate( int monthDif = 3)
        {
            string day, month,date;

            if (DateTime.Now.Month == 2)
            {
                monthDif = 1;
            }
            else if (DateTime.Now.Month == 1)
            {
                monthDif = 0;
            }
            
            day = (DateTime.Now.Day <= 9) ? (DateTime.Now.Day.ToString("D" + 2)).ToString() : DateTime.Now.Day.ToString();
            month = ((DateTime.Now.Month - monthDif) <= 9) ? ((DateTime.Now.Month - monthDif).ToString("D"+2)).ToString() : (DateTime.Now.Month - monthDif).ToString();
            date = day + "/"+month + "/" + DateTime.Now.Year;
            return date;
        }
        public static string getTodayDate()
        {
            string day, month, date;

            day = (DateTime.Now.Day <= 9) ? (DateTime.Now.Day.ToString("D" + 2)).ToString() : DateTime.Now.Day.ToString();
            month = (DateTime.Now.Month  <= 9) ? (DateTime.Now.Month.ToString("D" + 2)).ToString() : DateTime.Now.Month.ToString();
            date = day + "/" + month + "/" + DateTime.Now.Year;
            return date;
        }
        public static MainForm GetOpenFormInstance() 
        {
            MainForm mainForm = System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm;
            return mainForm;
        }
		
		public bool IsValidEmail(string email)
		{
			try{
				var mail = new System.Net.Mail.MailAddress(email);
				return true;
			}
			catch{
				return false;
			}
		}
		
		public static Utilities getInstance()
		{
			if(instance == null)
			{
				instance = new Utilities();
			}
			return instance;
		}
		
		public bool IsEmpty(Control temp)
		{
			foreach(Control check in temp.Controls)
			{
				if(check.GetType() .Name.ToString()== "TextBox")
				{
					if(String.IsNullOrEmpty(check.Text))
					{
					return true;
					}
				}
				if(check.GetType().Name.ToString() == "MaskedTextBox" && !check.Name.Equals("EmailMskBx"))
				 {
					if(String.IsNullOrEmpty(check.Text))
					{
					  return true;
					}
				}
			}
			return false;
		}
		public void Clear(Control control)
		{
			foreach(Control temp in control.Controls)
			{
				if(temp.GetType() .Name.ToString()== "TextBox")
				{
					temp.Text = "";
				}
				if(temp.GetType().Name.ToString() == "MaskedTextBox")
				 {
					temp.Text = "";
				}
			}
		}
		public bool CheckIfUserExist(string user)
		{
		   bool isTrue = false;
          
		   try
		   {
		   	 accessConnection.Open();
		   	 cmd = new OleDbCommand();
			 cmd.Connection = accessConnection;
		     cmd.CommandText = "SELECT * From LoginTbl where Username = [0]";
		     cmd.Parameters.AddWithValue("0", user);
			 accessReader = cmd.ExecuteReader();
				 if(accessReader.HasRows)
                {
                  
                    isTrue =  true ;
				 } 
                
		   }
		   catch(Exception)
		   {
		   	
		   }
		   finally
		   {
                accessConnection.Close();
            }
		   return isTrue;
	    }

        public static bool IsFileInUse(string filename)
        {
            if (File.Exists(filename))
            {
                FileStream fileStream = null;
                try
                {
                    using (fileStream = File.Open(filename, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                    {

                    }
                    return false;
                }
                catch (IOException ex)
                {

                    return true;
                }
            }
            return false;
        }

        public bool ValidateUser(string username, string password, out int t, out int i)
		{
			bool valid = false;

           int userTy = 0;
            int userId = 0;

            accessConnection.ConnectionString = Connection.getConnectionString();
			try
			{
				cmd = new OleDbCommand();
				accessConnection.Open();
				cmd.Connection = accessConnection;
				cmd.CommandText = @"SELECT * FROM LoginTbl WHERE Username = [0] AND UserPassword = [1]";
				cmd.Parameters.AddWithValue("0", username);
				cmd.Parameters.AddWithValue("1",password);
			    accessReader = cmd.ExecuteReader();
				 if(accessReader.HasRows)
				 {
					valid =  true ;
                    while (accessReader.Read())
                    {
                        userTy = accessReader.GetInt32(5);
                        userId = accessReader.GetInt32(0);
                    }
                } 
				
			}catch(Exception e)
			{
				
			}
			finally
			{
                t = userTy;
                i = userId;
				//accessReader.Close();
				accessConnection.Close();
			}
			return valid;
		}

        public static void ExportReportToExcel(DataGridView dataGridView)
        {
            if(dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No data to export");
                return;
            }

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            Workbook workbook = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Range chartRange;
            Worksheet worksheet = (Worksheet)workbook.Worksheets[1];
            excel.Visible = true;
           
            worksheet.Cells[1, 1] = "Item";
            worksheet.Cells[1, 2] = "Total";
            worksheet.Cells[1, 3] = "Unit";

            ChartObjects xlCharts = (ChartObjects)worksheet.ChartObjects(Type.Missing);
            ChartObject myChart = (ChartObject)xlCharts.Add(10, 80, 300, 250);
            Chart chartPage = myChart.Chart;
           
         
            for (int i = 0; i <= dataGridView.RowCount - 1; i++)
            {
                for (int j = 0; j <= dataGridView.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView[j, i];
                    worksheet.Cells[(i +4)-2, (j + 3) - 2] = cell.Value;
                }
            }
            
            chartRange = worksheet.get_Range("A2", "B"+ dataGridView.RowCount);
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = XlChartType.xlColumnClustered;

        }

    }
}
