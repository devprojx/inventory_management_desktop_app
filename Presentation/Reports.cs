
/*
 * Created by SharpDevelop.
 * User: Vstudent
 * toDate: 7/27/2015
 * Time: 5:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using Inventory_System.Classes;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Drawing;
using System.Data.OleDb;

namespace Inventory_System
{
	/// <summary>
	/// Description of Reports.
	/// </summary>
	public partial class Reports : Form
	{
        private OleDbConnection accessConnection = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader accessReader;
        DataTable table = new DataTable();
		string toDate;
        string fromDate;
        
		public Reports()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            reportChart.Series.Clear();

             getCateory();
            if(categoryCmbox.Items.Count > 0)
              categoryCmbox.SelectedIndex = 0;
        }

        void getCateory()
        {

            try
            {
                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {
                    accessConnection.Open();
                    cmd = new OleDbCommand();
                    cmd.Connection = accessConnection;
                    cmd.CommandText = @"SELECT CategoryId, Category From CategoryTbl";

                    using (OleDbDataReader accessReader = cmd.ExecuteReader())
                    {
                        var items = new System.Collections.Generic.List<object>();
                        categoryCmbox.DisplayMember = "Text";
                        categoryCmbox.ValueMember = "Value";
                        while (accessReader.Read())
                        {
                            items.Add(new { Text = accessReader.GetString(1), Value = accessReader.GetInt32(0) });
                        }
                        categoryCmbox.DataSource = items;
                    }
                }
            }
            catch (Exception ed)
            {

            }

        }

        //l datagridview with data based on the filtered fields
        void GenrateReportBtnClick(object sender, EventArgs e)
		{
           if(!DateValid()) return;
            fromDate = fromDatePicker.Value.Date.ToString("dd/MM/yyyy");
            toDate = toDatePicker.Value.Date.ToString("dd/MM/yyyy");


            bool costCheck = false;
            if (mostUsedRdBtn.Checked)
            {
                Data_Access.DataAccess.GetInstance().GetAllReportByMonthAndYear(fromDate, toDate, Int32.Parse(limitNumeric.Value.ToString()), out table, Int32.Parse(categoryCmbox.SelectedValue.ToString()), 1);
                dataGridView1.DataSource = table;
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
            }
            else if (leastUsedRdBtn.Checked)
            {
                Data_Access.DataAccess.GetInstance().GetAllReportByMonthAndYear(fromDate, toDate, Int32.Parse(limitNumeric.Value.ToString()), out table, Int32.Parse(categoryCmbox.SelectedValue.ToString()), 2);
                dataGridView1.DataSource = table;
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            }
            else if(mostExpenseRdBtn.Checked)
            {
                Data_Access.DataAccess.GetInstance().GetAllReportByMonthAndYear(fromDate, toDate, Int32.Parse(limitNumeric.Value.ToString()), out table, Int32.Parse(categoryCmbox.SelectedValue.ToString()), 3);
                dataGridView1.DataSource = table;
                costCheck = true;
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
            }
            else if(leastExpenseRdBtn.Checked)
            {
                Data_Access.DataAccess.GetInstance().GetAllReportByMonthAndYear(fromDate, toDate, Int32.Parse(limitNumeric.Value.ToString()), out table, Int32.Parse(categoryCmbox.SelectedValue.ToString()), 4);
                dataGridView1.DataSource = table;
                costCheck = true;
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            }
            
            int i = 0;
            double startPoint = 0.5;


            for (int x = 0; x < reportChart.Series.Count; x++)
            {
                reportChart.Series[x].Points.Clear();
                
            }

            reportChart.Series.Clear();

            try
            {
               
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if(i == dataGridView1.Rows.Count-1)
                    {
                        break;
                    }
                    string series = "";
                    if (!costCheck)
                      series = row.Cells[0].Value.ToString();
                    else
                      series = row.Cells[0].Value.ToString() + " - $" + row.Cells[3].Value.ToString();

                    if (!costCheck)
                      reportChart.Series.Add(series).Points.Add(Double.Parse( row.Cells["Total"].Value.ToString()));
                    else
                        reportChart.Series.Add(series).Points.Add(Double.Parse(row.Cells["Cost ($)"].Value.ToString()));

                    reportChart.Series[series].XValueType = ChartValueType.String;

                    
                        reportChart.Series[series].Points[0].Label = row.Cells[1].Value.ToString();

                    
                    reportChart.Legends[0].Docking = Docking.Bottom;

                    startPoint = startPoint + 1;
                   
                    i++;

                }
                reportChart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                reportChart.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
                reportChart.ChartAreas[0].AxisX.MinorTickMark.Enabled = false;
                reportChart.ChartAreas[0].AxisX.Interval = 0;

                reportChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                reportChart.ChartAreas[0].AxisX.LineWidth = 0;
                reportChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0; 
            }
            catch(Exception ec)
            {
               MessageBox.Show( ""+ec);
            }

            
		}
		
        private bool DateValid()
        {
            if(toDatePicker.Value < fromDatePicker.Value )
            {
                MessageBox.Show("Invalid Range of Dates. Check Both Dates", "Invalid Period", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
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
            
            
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void saveAsPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!DateValid()) return;
            int top = dataGridView1.Rows.Count - 1;
            bool dateIsNow = (toDatePicker.Value == DateTime.Now && fromDatePicker.Value == DateTime.Now) ? true : false;
            string category = (categoryCmbox.Text != "Misc") ? ""+categoryCmbox.Text: "";
            categoryCmbox.Focus();
            if (File.Exists(@"graph.png"))
                File.Delete(@"graph.png");
           
            this.reportChart.SaveImage(@"graph.png", ChartImageFormat.Png);
            if (mostUsedRdBtn.Checked && !dateIsNow && limitNumeric.Value > 0)
            {
                Report.GetInstance().AmountUsed(dataGridView1, @"Top " + top + " Most Used "+ category + " Items Between " + fromDatePicker.Value.Date.ToString("MMMM dd, yyyy") + " And " + toDatePicker.Value.Date.ToString("MMMM dd, yyyy"));
            }
            else if (leastUsedRdBtn.Checked && !dateIsNow && limitNumeric.Value > 0)
            {

                Report.GetInstance().AmountUsed(dataGridView1, @"Top " + top + " Least Used " + category + " Items Between " + fromDatePicker.Value.Date.ToString("MMMM dd, yyyy") + " And " + toDatePicker.Value.Date.ToString("MMMM dd, yyyy"));
            }
            else if (mostUsedRdBtn.Checked && dateIsNow && limitNumeric.Value > 0)
            {

                Report.GetInstance().AmountUsed(dataGridView1, @"Top " + top + " Most Used " + category + " Items For " + fromDatePicker.Value.Date.ToString("yyyy"));
            }
            else if (leastUsedRdBtn.Checked && dateIsNow && limitNumeric.Value > 0)
            {

                Report.GetInstance().AmountUsed(dataGridView1, @"Top " + top + " Least Used " + category + " Items For " + fromDatePicker.Value.Date.ToString("yyyy"));
            }
            if (mostUsedRdBtn.Checked && !dateIsNow && limitNumeric.Value == 0)
            {
                Report.GetInstance().AmountUsed(dataGridView1, @"Most Used " + category + " Items Between " + fromDatePicker.Value.Date.ToString("MMMM dd, yyyy") + " And " + toDatePicker.Value.Date.ToString("MMMM dd, yyyy"));
            }
            else if (leastUsedRdBtn.Checked && !dateIsNow && limitNumeric.Value == 0)
            {

                Report.GetInstance().AmountUsed(dataGridView1, @"Least Used " + category + " Items Between " + fromDatePicker.Value.Date.ToString("MMMM dd, yyyy") + " And " + toDatePicker.Value.Date.ToString("MMMM dd, yyyy"));
            }
            else if (mostUsedRdBtn.Checked && dateIsNow && limitNumeric.Value == 0)
            {
                Report.GetInstance().AmountUsed(dataGridView1, @"Most Used " + category + " Items For " + fromDatePicker.Value.Date.ToString("yyyy"));

            }
            else if (leastUsedRdBtn.Checked && dateIsNow && limitNumeric.Value == 0)
            {
                Report.GetInstance().AmountUsed(dataGridView1, @"Least Used " + category + " Items For " + fromDatePicker.Value.Date.ToString("yyyy"));
            }
           

        }

        private void saveGraphImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = " Portable Network Graphics (.png) | *.png";
            saveFile.CheckFileExists = false;
            saveFile.CheckPathExists = false;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (Utilities.IsFileInUse(saveFile.FileName))
                {
                    MessageBox.Show("File is being used by another program try closing the file and try again", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                this.reportChart.SaveImage(saveFile.FileName+".png", ChartImageFormat.Png);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.ExportReportToExcel(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
