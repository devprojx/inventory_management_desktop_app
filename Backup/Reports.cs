/*
 * Created by SharpDevelop.
 * User: Vstudent
 * Date: 7/27/2015
 * Time: 5:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Inventory_System.Classes;
using Inventory_System.Data_Access;
using System.Data;
using System.ComponentModel;
namespace Inventory_System
{
	/// <summary>
	/// Description of Reports.
	/// </summary>
	public partial class Reports : Form
	{
			DataTable table = new DataTable();
			string date;
		public Reports()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		//Fill datagridview with data based on the filtered fields
		void GenrateReportBtnClick(object sender, EventArgs e)
		{
		
			date =  monthMskBox.Text + "/" + yearMskTxtbx.Text;
			if(allItemsRdBtn.Checked && monthMskBox.MaskCompleted && yearMskTxtbx.MaskCompleted)
			{
				Data_Access.DataAccess.GetInstance().GetAllReportByMonthAndYear( monthMskBox.Text, yearMskTxtbx.Text, out table);
				dataGridView1.DataSource = table;
			
			
			}
			else if(allItemsRdBtn.Checked && !monthMskBox.MaskCompleted && !yearMskTxtbx.MaskCompleted)
			{
				Data_Access.DataAccess.GetInstance().GetOverallReport(out table);
				dataGridView1.DataSource = table;
			   
			}
			else if(mostUsedRdBtn.Checked &&  monthMskBox.MaskCompleted && yearMskTxtbx.MaskCompleted)
			{
				Data_Access.DataAccess.GetInstance().GetAllReportByMonthAndYear( monthMskBox.Text, yearMskTxtbx.Text, out table);
				dataGridView1.DataSource = table;
				dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
				
			}
			else if(leastUsedRdBtn.Checked &&  monthMskBox.MaskCompleted && yearMskTxtbx.MaskCompleted)
			{
				Data_Access.DataAccess.GetInstance().GetAllReportByMonthAndYear( monthMskBox.Text, yearMskTxtbx.Text, out table);
				dataGridView1.DataSource = table;
				dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
					chart1.DataSource= table;
				chart1.Visible = true;
				chart1.Series["Items"].XValueMember = "ItemName";
				chart1.Series["Items"].YValueMembers = "'Total'";
				chart1.DataBind();
				double ploty = 0;
				if(chart1.Series["Items"].Points.Count > 0)
				{
					ploty = chart1.Series["Items"].Points[chart1.Series["Items"].Points.Count - 1].YValues[0];
				}
				for( int x = 0; x < table.Rows.Count; x++)
				{
					ploty = Convert.ToInt16(table.Rows[x]["'Total'"]);
					chart1.Series["Items"].Points.Add(ploty);
				}
			}
			else if(mostUsedRdBtn.Checked &&  !monthMskBox.MaskCompleted && !yearMskTxtbx.MaskCompleted)
			{
				Data_Access.DataAccess.GetInstance().GetOverallReport(out table);
				dataGridView1.DataSource = table;
				dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
				
			}
			else if(leastUsedRdBtn.Checked && !monthMskBox.MaskCompleted && !yearMskTxtbx.MaskCompleted)
			{
				Data_Access.DataAccess.GetInstance().GetOverallReport(out table);
				dataGridView1.DataSource = table;
				dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
				
			}
		}
		
		
		//Enable parent form on Report form close event
		void ReportsFormClosed(object sender, FormClosedEventArgs e)
		{
			MainForm mainform = Application.OpenForms["MainForm"] as MainForm;
			mainform.Enabled = true;
		}
		
		//Export the data in datagrid view as pdf
		void SaveTlBarClick(object sender, EventArgs e)
		{
			 date = monthMskBox.Text + "/" + yearMskTxtbx.Text;
			if(allItemsRdBtn.Checked && monthMskBox.MaskCompleted && yearMskTxtbx.MaskCompleted)
			{
				Report.GetInstance().AmountUsed(dataGridView1, "Item Amount Used For The Month Of "+ date);
			}
			else if(allItemsRdBtn.Checked && !monthMskBox.MaskCompleted && !yearMskTxtbx.MaskCompleted)
			{
				
			    Report.GetInstance().AmountUsed(dataGridView1, "Item amount Used");
			}
			else if(mostUsedRdBtn.Checked &&  monthMskBox.MaskCompleted && yearMskTxtbx.MaskCompleted)
			{
				
				Report.GetInstance().AmountUsed(dataGridView1, @"Item Amount Used For The Month Of "+ date);
			}
			else if(leastUsedRdBtn.Checked &&  monthMskBox.MaskCompleted && yearMskTxtbx.MaskCompleted)
			{
				
				Report.GetInstance().AmountUsed(dataGridView1, @"Item Amount Used For The Month Of "+ date);
			}
			else if(mostUsedRdBtn.Checked &&  !monthMskBox.MaskCompleted && !yearMskTxtbx.MaskCompleted)
			{
				
				Report.GetInstance().AmountUsed(dataGridView1, @"Items Amount Used");
			}
			else if(leastUsedRdBtn.Checked && !monthMskBox.MaskCompleted && !yearMskTxtbx.MaskCompleted)
			{
			
				Report.GetInstance().AmountUsed(dataGridView1, @"Item Amount Used");
			}
		}
	}
}
