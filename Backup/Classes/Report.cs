/*
 * Created by SharpDevelop.
 * User: Vstudent
 * Date: 7/30/2015
 * Time: 2:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.OleDb;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.IO;


namespace Inventory_System.Classes
{
	/// <summary>
	/// Description of Report.
	/// </summary>
	public class Report
	{
		private static Report instance = null;
		
		//Ensure that the class cannot be instantiated outside of the class itself
		private Report()
		{
		}
		
		//Instantiate the class only once  when ever this function is called 
		public static Report GetInstance()
		{
			if(instance == null)
			{
				instance = new Report();
			}
			return instance;
		}
		//Create a PDF file based on the datagridview generated
		public void ExportTransactionLog( DataGridView dataGridView1, string ReportTitle)
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.Filter = " Pdf Document (.pdf) | *.pdf";
			saveFile.CheckFileExists = false;
			saveFile.CheckPathExists = false;
			if(saveFile.ShowDialog() == DialogResult.OK)
			{
				if(IsFileInUse(saveFile.FileName))
			     	{
			     		MessageBox.Show("File is being used by another program try closing the file and try again", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			     		return;
			     	}
					Document doc = new Document(PageSize.LETTER_LANDSCAPE,10, 10, 42, 30);
					Paragraph para = new Paragraph("VTDI-MAN-TRANSACTION-LOG");
					Paragraph title = new Paragraph(ReportTitle);
					title.Alignment = 1;
					title.SpacingAfter = 50f;
					iTextSharp.text.Image Png =  iTextSharp.text.Image.GetInstance(@"header.png");
				try
				{	
				
					PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFile.FileName, FileMode.Create));
					Png.ScalePercent(40);
					Png.SetAbsolutePosition(40f, 630f);
				    para.SpacingAfter = 140f;
					doc.Open();
					  	if(dataGridView1.Columns.Count == 0)
						{
					  		MessageBox.Show("No data to export");
							return;
						}
		        		 PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
		        	 
		  			 	 table.HorizontalAlignment = 1;
		        	 	table.WidthPercentage = 100;
		  				
		        	 	table.AddCell("ID");
		        	 	table.AddCell("Item Name");
		        	 	table.AddCell("Item Code");
		        	 	table.AddCell("Date Requested");
		        	 	table.AddCell("Amount Requested");
		        	 	table.AddCell("Issued By");
		        	 	table.AddCell("Amount Issued");
		        	 	table.AddCell("Date Issued");
		        	 	table.AddCell("Received By");
		        	 	table.AddCell("Date Received");
		        	
		        	 for(int j = 0; j < dataGridView1.Rows.Count; j++)
		        	 {
		        	 	
		        	 	for(int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
		        	 	{ 
		        	 		if(dataGridView1[i, j].Value == null)
		        	 		{
		        	 			break;
		        	 		}
		        	 		table.AddCell(dataGridView1.Rows[j].Cells[i].Value.ToString());
		        	 	}
		        	 }
		        	 doc.Add(Png);
		        	 doc.Add(para);
		        	 doc.Add(title);	
		        	 doc.Add(table);
		        	 doc.Close();
		        	 writer.Close();
		        	 System.Diagnostics.Process.Start(saveFile.FileName);
				}
				catch(Exception t)
				{
					MessageBox.Show(""+ t);
					
				}
				finally
				{
					
				}
			}
		}
		public void ExportReceivableLog( DataGridView dataGridView1, string ReportTitle)
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.Filter = " Pdf Document (.pdf) | *.pdf";
			saveFile.CheckFileExists = false;
			saveFile.CheckPathExists = false;
			if(saveFile.ShowDialog() == DialogResult.OK)
			{
				if(IsFileInUse(saveFile.FileName))
			     	{
			     		MessageBox.Show("File is being used by another program try closing the file and try again", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			     		return;
			     	}
					Document doc = new Document(PageSize.LETTER_LANDSCAPE,10, 10, 42, 30);
					Paragraph para = new Paragraph("VTDI-MAN-TRANSACTION-LOG");
					Paragraph title = new Paragraph(ReportTitle);
					title.Alignment = 1;
					title.SpacingAfter = 50f;
					iTextSharp.text.Image Png =  iTextSharp.text.Image.GetInstance(@"header.png");
				try
				{	
				
					PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFile.FileName, FileMode.Create));
					Png.ScalePercent(40);
					Png.SetAbsolutePosition(40f, 630f);
				    para.SpacingAfter = 140f;
					doc.Open();
					  	if(dataGridView1.Columns.Count == 0)
						{
					  		MessageBox.Show("No data to export");
							return;
						}
		        		 PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
		        	 
		  			 	 table.HorizontalAlignment = 1;
		        	 	table.WidthPercentage = 100;
		  				
		        	 	table.AddCell("Item Name");
		        	 	table.AddCell("Supplier");
		        	 	table.AddCell("Received Date");
		        	 	table.AddCell("Quantity Received");
		        	 	table.AddCell("Cost ($)");
		        	 	
		        	
		        	 for(int j = 0; j < dataGridView1.Rows.Count; j++)
		        	 {
		        	 	
		        	 	for(int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
		        	 	{ 
		        	 		if(dataGridView1[i, j].Value == null)
		        	 		{
		        	 			break;
		        	 		}
		        	 		table.AddCell(dataGridView1.Rows[j].Cells[i].Value.ToString());
		        	 	}
		        	 }
		        	 doc.Add(Png);
		        	 doc.Add(para);
		        	 doc.Add(title);	
		        	 doc.Add(table);
		        	 doc.Close();
		        	 writer.Close();
		        	 System.Diagnostics.Process.Start(saveFile.FileName);
				}
				catch(Exception t)
				{
					MessageBox.Show(""+ t);
					
				}
				finally
				{
					
				}
			}
		}
		
		//Create a PDF file based on the datagridview generated
		public void AmountUsed( DataGridView dataGridView1, string ReportTitle)
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.Filter = " Pdf Document (.pdf) | *.pdf";
			
			    if(dataGridView1.Columns.Count == 0)
				{
					MessageBox.Show("No data to export");
					return;
				}
			    saveFile.CheckFileExists = false;
			    saveFile.CheckPathExists = false;
			     if(saveFile.ShowDialog() == DialogResult.OK)
					{
			     	if(IsFileInUse(saveFile.FileName))
			     	{
			     		MessageBox.Show("File is being being used by another program try closing the file and try again","", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			     		return;
			     	}
						Document doc = new Document(PageSize.LETTER_LANDSCAPE,40, 40, 42, 30);
						Paragraph para = new Paragraph("VTDI-MAN-REPORT");
						Paragraph title = new Paragraph(ReportTitle);
						title.Alignment = 1;
						title.SpacingAfter = 50f;
						iTextSharp.text.Image Png =  iTextSharp.text.Image.GetInstance(@"header.png");
					try
					{
						
						PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFile.FileName, FileMode.Create));
						Png.ScalePercent(40);
						Png.SetAbsolutePosition(40f, 630f);
					    para.SpacingAfter = 140f;
						doc.Open();
						
						
			        	 PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
			        	 
			  			  table.HorizontalAlignment = 1;
			        	 	table.WidthPercentage = 100;
			  				
			        	 	table.AddCell("Item Name");
			        	 	table.AddCell("Overall Usage");
			        	 	table.AddCell("Unit");
			        
			        	 for(int j = 0; j < dataGridView1.Rows.Count; j++)
			        	 {
			        	 	
			        	 	for(int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
			        	 	{ 
			        	 		if(dataGridView1[i, j].Value == null)
			        	 		{
			        	 			break;
			        	 		}
			        	 		table.AddCell(dataGridView1.Rows[j].Cells[i].Value.ToString());
			        	 	}
			        	 }
			        	 doc.Add(Png);
			        	 doc.Add(para);
			        	 doc.Add(title);	
			        	 doc.Add(table);
			        	 doc.Close(); 
			        	  writer.Close();
			        	 System.Diagnostics.Process.Start(saveFile.FileName);
					}
					catch(Exception e)
					{
						MessageBox.Show(""+ e);
					}
					finally
					{
						
					}
		  }
		}
		//Check if file is being used by another program
		static bool IsFileInUse(string filename)
		{
			if(File.Exists(filename))
			{
				FileStream fileStream = null;
				try
				{
					using(fileStream = File.Open(filename, FileMode.Open, FileAccess.ReadWrite,FileShare.None))
					{
						
					}
					 	return false;
					}
				catch(IOException ex)
				{
					MessageBox.Show(""+ex);
					return true;
				}
			}
			return false;
		}
		
	}
}
