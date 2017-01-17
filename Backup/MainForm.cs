/*
 * Created by SharpDevelop.
 * User: VStudent
 * Date: 16/07/2015
 * Time: 10:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Inventory_System.Classes;
using System.Data.OleDb;
using System.Data;

namespace Inventory_System
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Item newItem = new Item();

	   	private OleDbConnection connect = new OleDbConnection();
	   	OleDbCommand cmd = new OleDbCommand();
		OleDbDataAdapter adapter = new OleDbDataAdapter();
		  
		public MainForm()
		{
			//
			connect.ConnectionString = Connection.getConnectionString();
                          
    
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

		
		void AddNewItemToolStripMenuItemClick(object sender, EventArgs e)
		{
		   Add_Item newAddItemForm = new Add_Item();
			newAddItemForm.Show();
			this.Enabled = false;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			RefreshItemStatus();
         	getNotifications();
         	getSupplier();
		}
		//Get all the updated item information from the database
		public bool RefreshItemStatus()
		{
		
			try
			{
			string sql  = "SELECT ItemName, LastUpdated, ItemBalance, Unit,ReorderLevel  FROM ItemTbl  where StatusId = 1";
             DataTable datatable = new DataTable();
  			dataGridView2.DataSource = datatable;
             OleDbDataAdapter adapter = new OleDbDataAdapter(sql,connect);
    		adapter.Fill(datatable);
    		if(datatable.Rows.Count == 0)
    		{
    			result.Text = CountItems(dataGridView2).ToString();
    			return false;
    		}
			}
			catch(Exception)
			{
				
			}
			
			result.Text = CountItems(dataGridView2).ToString();
    		return true;
		}
		//Get all the item status from the database
		bool CheckItemStatus()
		{
			try
			{
			 string sql  = "SELECT ItemName, LastUpdated, ItemBalance FROM ItemTbl  where StatusId = 1";
             DataTable datatable = new DataTable();
             OleDbDataAdapter adapter = new OleDbDataAdapter(sql,connect);
    		 adapter.Fill(datatable);
    		if(datatable.Rows.Count == 0)
    		{
    			return false;
    		}
			}
			catch(Exception)
			{
				
			}
    		return true;
		}
		
		//Get all the items that is at or below the reorder level
		public void getNotifications()
		{
			
			try
    		{
    		string sql  = "SELECT ItemCode, ItemName, ItemBalance, Unit, LastUpdated FROM ItemTbl where ItemBalance <= ReorderLevel  and StatusId = 1";
             DataTable datatable = new DataTable();
  			dataGridView1.DataSource = datatable;
             OleDbDataAdapter adapter = new OleDbDataAdapter(sql,connect);
    		adapter.Fill(datatable);
    			if(CheckItemStatus())
    			{
	    			if(datatable.Rows.Count < 1)
		    		{
		    			statusLbl.Text = "Inventory is up to date";
		    			uptodatePic.Image = Resource1._1438228058_face_smile_big;
		    			statusLbl.ForeColor =  Color.LimeGreen;
		    			tabPage1.BackColor = Color.White;
		    			uptodatePic2.Visible = false;
		    			uptodatePic.Visible = true;
		    		}
		    		if(datatable.Rows.Count == 1)
		    		{
		    			statusLbl.Text = "There is an Item that needs updating";
		    			uptodatePic2.Image = Resource1._1438227993_face_sad;
		    			statusLbl.ForeColor = Color.Red;
		    			uptodatePic.Visible = false;
		    			uptodatePic2.Visible = true;
		    			
		    		}
		    		if(datatable.Rows.Count > 1)
		    		{
		    			statusLbl.Text = "There are Items that need updating";
		    			uptodatePic2.Image = Resource1._1438227993_face_sad;
		    			statusLbl.ForeColor = Color.Red;
		    			uptodatePic.Visible = false;
		    			uptodatePic2.Visible = true;
		    		}
    			}
    			else
    			{
    				    statusLbl.Text = "No item in Inventory";
    				    uptodatePic.Image = Resource1.neutral_face;
		    			statusLbl.ForeColor =  Color.LightSeaGreen;
		    			tabPage1.BackColor = Color.White;
		    			uptodatePic.Visible = true;
		    			uptodatePic2.Visible = false;
    			}
    		}
    		catch(Exception)
    		{
    			
    		}
		}
		
		public void getSupplier()
		{
			
			try
    		{
    		 string sql  = "SELECT SupplierTbl.SupplierName, SupplierTbl.Location, ParishTbl.ParishName, SupplierTbl.PhoneNumber1, SupplierTbl.PhoneNumber2, SupplierTbl.Email, SupplierTbl.FaxNumber FROM SupplierTbl INNER JOIN  ParishTbl ON SupplierTbl.ParishId = ParishTbl.ParishId ORDER BY SupplierTbl.SupplierName DESC";
             DataTable datatable = new DataTable();
  			 dataGridView3.DataSource = datatable;
             OleDbDataAdapter adapter = new OleDbDataAdapter(sql,connect);
    		  adapter.Fill(datatable);
			}
			catch(Exception et)
			{
		MessageBox.Show("\nDatabase is down.." + et, "No item in inventory", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

			}
			finally
			{
				
			}
		}
		
		void TransactionLogsToolStripMenuItemClick(object sender, EventArgs e)
		{
			InventoryTransaction newTransLog = new InventoryTransaction();
			newTransLog.Show();
		}
		
		//Open Request form
		void AddItemRequestToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(RefreshItemStatus())
			{
				NewRequest newRequest = new NewRequest();
				newRequest.Show();
				this.Enabled = false;
			}
			else
			{
				MessageBox.Show("\nPlease add an item in the inventory to enable this function", "No item in inventory", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
		
	     //Open Update form
		void UpdateItemQuantityToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(RefreshItemStatus())
    		{
				Update_Quantity newUpdateForm = new Update_Quantity();
				newUpdateForm.Show();	
				this.Enabled = false;
				
			}
			else
			{
				MessageBox.Show("\nPlease add an item in the inventory to enable this function", "No item in inventory", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
		
		//Close Splash screen if form is close
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			SplahScreen splash = Application.OpenForms["SplahScreen"] as SplahScreen;
			splash.Close();
		}
		
		//Open delete form
		void DeleteItemToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(RefreshItemStatus())
			{
				Delete deleteForm = new Delete();
				deleteForm.Show();
				this.Enabled = false;
			}
			else
			{
				MessageBox.Show("\nPlease add an item in the inventory to enable this function", "No item in inventory", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
		
		void TabPage2Enter(object sender, EventArgs e)
		{
			RefreshItemStatus();
		}
		
		void AboutToolStripClick(object sender, EventArgs e)
		{
			About aboutForm  = new About();
			aboutForm.Show();
			this.Enabled = false;
		}
		
		void EditItemToolStripMenuItemClick(object sender, EventArgs e)
		{
			
				Edit editForm = new Edit();
				editForm.Show();
				this.Enabled = false;	
		
		}
		
		void EditUnitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Units unitForm = new Units();
			unitForm.Show();
			this.Enabled = false;
		}
		
		void CreateOrEditExistingUserToolStripMenuItemClick(object sender, EventArgs e)
		{
			CreateUser newUserForm = new CreateUser();
			this.Enabled = false;
			newUserForm.Show();
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SplahScreen newForm = Application.OpenForms["SplahScreen"] as SplahScreen;
			newForm.Show();
			this.Dispose();
		}
		
		
/*-------------------------------------Icon tool bar------------------------------------------*/
		
		void PictureBox1MouseEnter(object sender, EventArgs e)
		{
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Width = 35;
			pictureBox1.Height = 31;
		}
		
		void PictureBox1MouseLeave(object sender, EventArgs e)
		{
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Width = 33;
			pictureBox1.Height = 28;
		}
		
		void UpdatePicMouseEnter(object sender, EventArgs e)
		{
			updatePic.BackColor = Color.Transparent;
			updatePic.Width = 35;
			updatePic.Height = 31;
		}
		
		void UpdatePicMouseLeave(object sender, EventArgs e)
		{
			updatePic.BackColor = Color.Transparent;
			updatePic.Width = 33;
			updatePic.Height = 28;
		}
		
		void LogRequestPicMouseEnter(object sender, EventArgs e)
		{
			LogRequestPic.BackColor = Color.Transparent;
			LogRequestPic.Width = 35;
			LogRequestPic.Height = 31;
		}
		
		void LogRequestPicMouseLeave(object sender, EventArgs e)
		{
			LogRequestPic.BackColor = Color.Transparent;
			LogRequestPic.Width = 33;
			LogRequestPic.Height = 28;
		}
		
		void DeletePicMouseEnter(object sender, EventArgs e)
		{
			DeletePic.BackColor = Color.Transparent;
			DeletePic.Width = 35;
			DeletePic.Height = 31;
		}
		
		void DeletePicMouseLeave(object sender, EventArgs e)
		{
			DeletePic.BackColor = Color.Transparent;
			DeletePic.Width = 33;
			DeletePic.Height = 28;
		}
		
		void CreateUserPicMouseEnter(object sender, EventArgs e)
		{
			CreateUserPic.BackColor = Color.Transparent;
			CreateUserPic.Width = 35;
			CreateUserPic.Height = 31;
		}
		
		void CreateUserPicMouseLeave(object sender, EventArgs e)
		{
			CreateUserPic.BackColor = Color.Transparent;
			CreateUserPic.Width = 33;
			CreateUserPic.Height = 28;
		}
		
		void AboutMouseEnter(object sender, EventArgs e)
		{
			about.BackColor = Color.Transparent;
			about.Width = 35;
			about.Height = 31;
		}
		
		void AboutMouseLeave(object sender, EventArgs e)
		{
			about.BackColor = Color.Transparent;
			about.Width = 33;
			about.Height = 28;
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			 Add_Item newAddItemForm = new Add_Item();
			 newAddItemForm.Show();
			 this.Enabled = false;
		}
		void EditItemMouseEnter(object sender, EventArgs e)
		{
			editItem.BackColor = Color.Transparent;
			editItem.Width = 35;
			editItem.Height = 31;
		}
		
		void EditItemMouseLeave(object sender, EventArgs e)
		{
			editItem.BackColor = Color.Transparent;
			editItem.Width = 33;
			editItem.Height = 28;
		}
		void UpdatePicClick(object sender, EventArgs e)
		{
			if(RefreshItemStatus())
    		{
				Update_Quantity newUpdateForm = new Update_Quantity();
				newUpdateForm.Show();	
				this.Enabled = false;
				
			}
			else
			{
				MessageBox.Show("\nPlease add an item in the inventory to enable this function", "No item in inventory", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
		void EditUnitsClick(object sender, EventArgs e)
		{
			Units unitForm = new Units();
			unitForm.Show();
			this.Enabled = false;
		}
		void LogRequestPicClick(object sender, EventArgs e)
		{
			if(RefreshItemStatus())
			{
				NewRequest newRequest = new NewRequest();
				newRequest.Show();
				this.Enabled = false;
			}
			else
			{
				MessageBox.Show("\nPlease add an item in the inventory to enable this function", "No item in inventory", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			
		}
		//Count the number of items in inventory
		int CountItems(DataGridView dataview)
		{
			if(dataview.Rows.Count == null)
				return 0;
		
			return dataview.Rows.Count;
			
		}
		void DeletePicClick(object sender, EventArgs e)
		{
			if(RefreshItemStatus())
			{
				Delete deleteForm = new Delete();
				deleteForm.Show();
				this.Enabled = false;
			}
			else
			{
				MessageBox.Show("\nPlease add an item in the inventory to enable this function", "No item in inventory", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
	
		void CreateUserPicClick(object sender, EventArgs e)
		{
			CreateUser newUserForm = new CreateUser();
			this.Enabled = false;
			newUserForm.Show();
		}
		
		void AboutClick(object sender, EventArgs e)
		{
			About aboutForm  = new About();
			aboutForm.Show();
			this.Enabled = false;
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			if(RefreshItemStatus())
			{
				Edit editForm = new Edit();
				editForm.Show();
				this.Enabled = false;
		    }
			else
			{
				MessageBox.Show("\nPlease add an item in the inventory to enable this function", "No item in inventory", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
		

		void ReportsToolStripMenuItemClick(object sender, EventArgs e)
		{
			Reports reportForm = new Reports();
			reportForm.Show();
			this.Enabled = false;
		}
		
/*------------------------Create animation effect-----------------------------*/			
	
		void UptodatePicMouseEnter(object sender, EventArgs e)
		{
			uptodatePic.Width = 45;
			uptodatePic.Height =39;
		}
		
		void UptodatePicMouseLeave(object sender, EventArgs e)
		{
			uptodatePic.Width = 42;
			uptodatePic.Height =36;
		}
		
		void UptodatePic2MouseEnter(object sender, EventArgs e)
		{
			uptodatePic2.Width = 43;
			uptodatePic2.Height = 38;
		}
		
		void UptodatePic2MouseLeave(object sender, EventArgs e)
		{
			uptodatePic2.Width = 40;
			uptodatePic2.Height = 35;
		}
/*-------------------------------------------------------------------------*/		
		
		void ExportItemListAsPDFToolStripMenuItemClick(object sender, EventArgs e)
		{
			Report.GetInstance().AmountUsed(dataGridView2,"ALL ITEMS IN THE INVENTORY");
		}
		
		void ReceivablePicClick(object sender, EventArgs e)
		{
			ReceivableForm newRForm = new ReceivableForm();
			this.Enabled = false;
			newRForm.Show();
		}
		
		void ReceivableLogsToolStripMenuItemClick(object sender, EventArgs e)
		{
			ReceivedLog newForm = new ReceivedLog();
			newForm.Show();
			this.Enabled = false;
		}
		
		void ReceivablePicMouseEnter(object sender, EventArgs e)
		{
			receivablePic.Width = 43;
			receivablePic.Height =38;
		}
		
		void ReceivablePicMouseLeave(object sender, EventArgs e)
		{
			receivablePic.Width = 40;
			receivablePic.Height =35;
		}
	}
}
