/*
 * Created by SharpDevelop.
 * User: VStudent
 * Date: 16/07/2015
 * Time: 10:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Inventory_System.Classes;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using System.ComponentModel;
using System.Threading;
using System.Linq.Expressions;
using System.Reflection;

namespace Inventory_System
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{

        Thread requestThread = null;
        bool isTaskRunning = false;
		Item newItem = new Item();
        int userId;
	   	private OleDbConnection connect = new OleDbConnection();
	   	OleDbCommand cmd = new OleDbCommand();
		OleDbDataAdapter adapter = new OleDbDataAdapter();
		  
		public MainForm()
		{
			//
			connect.ConnectionString = Connection.getConnectionString();
                          
			InitializeComponent();
			
		}

        public MainForm(int userType, int userId)
        {
            //
            connect.ConnectionString = Connection.getConnectionString();
            //MessageBox.Show(userId.ToString());
            InitializeComponent();
            this.userId = userId;
            if(userType == 2)
            {
                createOrEditExistingUserToolStripMenuItem.Visible = false;
                optionsToolStripMenuItem.Visible = false;
                editItem.Enabled = false;
                CreateUserPic.Enabled = false;
                addPicbx.Enabled = false;
                DeletePic.Enabled = false;
                updatePic.Enabled = false;
                tabControl1.TabPages.RemoveAt(1);
                tabControl1.TabPages.RemoveAt(4);
            }

        }

        void AddNewItemToolStripMenuItemClick(object sender, EventArgs e)
		{
		   Add_Item newAddItemForm = new Add_Item(this.userId);
			newAddItemForm.Show();
			this.Enabled = false;
		}

        void MainFormLoad(object sender, EventArgs e)
        {
            uptodatePic.Visible = true;
            uptodatePic2.Visible = true;
            RefreshItemStatus();
            GenerateGraph(GetInfo());
            getNotifications();
            RequestedItems();
            getSupplier();
            loadActivity();
            requestThread = new Thread(new ThreadStart(AsyncCheckRequest));
            requestThread.IsBackground = true;
            requestThread.Start();

		}

        public void loadActivity()
        {
            activityDatagrid.DataSource = null;
            activityDatagrid.Rows.Clear();
            System.Data.DataTable table = new System.Data.DataTable();
            try
            {
                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {

                    accessConnection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = accessConnection;

                    cmd.CommandText = @"Select LoginTbl.Username, Actions, [TimeStamp] FROM LoginTbl INNER JOIN 
                                        UserActions ON (LoginTbl.passwordId = UserActions.passwordId) Group by LoginTbl.Username, Actions, [TimeStamp]
                                        order by [TimeStamp] DESC
                                       ";
 
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);

                    dataAdapter.Fill(table);
                    activityDatagrid.DataSource = table; 
                    
                }
            }
            catch (Exception et)
            {

            }
        }

    
        public bool RequestedItems()
        {
            
            isTaskRunning = true;
            requestGridView.DataSource = null;
            requestGridView.Columns.Clear();
            try
            {
                string sql = @"SELECT id as `Request Id`, ItemCode as `Item Code`, ItemName as`Item`, DateRequested as `Date Requested`, AmountRequested as `Amount Requested`
                              , `ReceivedBy` as `Requester` FROM RequestTbl where status = 'R'";
                DataTable datatable = new DataTable();
                DataColumn buttonColumn = new DataColumn();

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connect))
                {
                    adapter.Fill(datatable);
                    if (datatable.Rows.Count != 0)
                    {
                        
                        tabControl1.TabPages[1].Text = "Requests (" + datatable.Rows.Count + ")";
                    }
                    else
                    {
                        tabControl1.TabPages[1].Text = "Requests (" + datatable.Rows.Count + ")";
                    }
                }

               
                requestGridView.DataSource = datatable;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                requestGridView.Columns.Insert(0,btn);
                btn.HeaderText = "Approvals";
                btn.Text = "Approve";
                btn.Name = "approveBtn";
                btn.UseColumnTextForButtonValue = true;

                btn = new DataGridViewButtonColumn();
                requestGridView.Columns.Insert(1,btn);
                btn.HeaderText = "Disapprovals";
                btn.Text = "Disaprove";
                btn.Name = "disapproveBtn";
                btn.UseColumnTextForButtonValue = true;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                isTaskRunning = false;
                connect.Close();
            }

            return true;
        }

        public void AsyncRequestedItems()
        {

            isTaskRunning = true;
                        requestGridView.Invoke((MethodInvoker)(() => requestGridView.DataSource = null));
            requestGridView.Invoke((MethodInvoker)(() => requestGridView.Columns.Clear()));
            try
            {
                string sql = @"SELECT id as `Request Id`, ItemCode as `Item Code`, ItemName as`Item`, DateRequested as `Date Requested`, AmountRequested as `Amount Requested`
                              , `ReceivedBy` as `Requester` FROM RequestTbl where status = 'R'";
                DataTable datatable = new DataTable();
                DataColumn buttonColumn = new DataColumn();

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connect))
                {
                    adapter.Fill(datatable);
                    
                }

                requestGridView.Invoke((MethodInvoker)(() => requestGridView.DataSource = datatable));

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Approvals";
                btn.Text = "Approve";
                btn.Name = "approveBtn";
                btn.UseColumnTextForButtonValue = true;
                requestGridView.Invoke((MethodInvoker)(() => requestGridView.Columns.Insert(0, btn)));

                btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Disapprovals";
                btn.Text = "Disaprove";
                btn.Name = "disapproveBtn";
                btn.UseColumnTextForButtonValue = true;
                requestGridView.Invoke((MethodInvoker)(() => requestGridView.Columns.Insert(1, btn)));

                if (datatable.Rows.Count != 0)
                {
                    tabControl1.TabPages[1].Invoke((MethodInvoker)(() =>
                     tabControl1.TabPages[1].Text = "Requests (" + datatable.Rows.Count + ")"
                    ));

                    var notification = new System.Windows.Forms.NotifyIcon()
                    {
                        Visible = true,
                        Icon = System.Drawing.SystemIcons.Information,
                        BalloonTipTitle = "Requests",
                        BalloonTipText = "You have " + datatable.Rows.Count,
                    };

                    notification.ShowBalloonTip(5);


                    Thread.Sleep(10000);

                    notification.Dispose();
                }
                else
                {
                    tabControl1.TabPages[1].Invoke((MethodInvoker)(() =>
                    tabControl1.TabPages[1].Text = "Requests (" + datatable.Rows.Count + ")"
                    ));

                }
            }
            catch (Exception)
            {

            }
            finally
            {
                isTaskRunning = false;
                connect.Close();
            }
            
        }

        public void  AsyncCheckRequest()
        {
            while (true)
            {
                Thread.Sleep(60000);
                if (!isTaskRunning)
                {
                    AsyncRequestedItems();
                }
            }
        }
        private void requestTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = requestGridView.CurrentCell.RowIndex;
            int columnindex = requestGridView.CurrentCell.ColumnIndex;


            if (e.ColumnIndex == 0)
            {

                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {

                    OleDbTransaction transaction = null;
                    try
                    {
                        Request newRequest = new Request();
                        OleDbCommand cmd = new OleDbCommand();
                        accessConnection.Open();
                        cmd.Connection = accessConnection;
                        //Populate Object
                        newRequest.ItemCode = requestGridView.Rows[rowindex].Cells[3].Value.ToString();
                        newRequest.DateRequested = requestGridView.Rows[rowindex].Cells[5].Value.ToString();
                        cmd.CommandText = @"SELECT ItemBalance,ItemUsed ,ItemName  From ItemTbl where itemCode = [0] and statusId = 1";
                        cmd.Parameters.AddWithValue("0", newRequest.ItemCode);

                        OleDbDataReader accessReader = cmd.ExecuteReader();

                        newRequest.AmountIssued = double.Parse(requestGridView.Rows[rowindex].Cells[6].Value.ToString());
                        while (accessReader.Read())
                        {
                            newItem.Balance = accessReader.GetDouble(0);
                            newItem.ItemUsed = accessReader.GetDouble(1);
                            newItem.ItemName = accessReader.GetString(2);
                        }
                        if (newItem.Balance < newRequest.AmountIssued)
                        {
                            accessConnection.Close();
                            MessageBox.Show("\n" +
                                        newItem.Balance + " " + newItem.ItemName + " Remaining", "Item quantity is low", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        accessReader.Close();

                        //Calculates Item remaining after request
                        newItem.Balance -= newRequest.AmountIssued;
                        newItem.ItemUsed += newRequest.AmountIssued;


                        OleDbCommand cm = new OleDbCommand();
                        cm.Connection = accessConnection;
                        cm.CommandText = @"select username from logintbl where passwordId = " + this.userId + @"";

                        OleDbDataReader reader = cm.ExecuteReader();
                        string username = " ";
                        while (reader.Read())
                        {
                            username = reader.GetString(0);
                        }

                        reader.Close();


                        transaction = accessConnection.BeginTransaction(IsolationLevel.ReadCommitted);
                        //Update approval status
                        OleDbCommand cmd2 = new OleDbCommand();
                        cmd2.Connection = accessConnection;
                        cmd2.CommandText = @"Update RequestTbl SET status = 'A',
                                               IssuedBy = '" + username + "', DateIssued = Date() where ID = [0]";
                        
                        cmd2.Parameters.AddWithValue("0", requestGridView.Rows[rowindex].Cells[2].Value.ToString());
                        cmd2.Transaction = transaction;
                        cmd2.ExecuteNonQuery();

                        //Update Item table
                        OleDbCommand cmd3 = new OleDbCommand();
                        cmd3.Connection = accessConnection;
                        cmd3.CommandText = @"UPDATE ItemTbl SET ItemBalance = [0], ItemUsed = [1] WHERE ItemCode = [2]";
                        cmd3.Parameters.AddWithValue("0", newItem.Balance);
                        cmd3.Parameters.AddWithValue("1", newItem.ItemUsed);
                        cmd3.Parameters.AddWithValue("2", newRequest.ItemCode);

                        cmd3.Transaction = transaction;
                        cmd3.ExecuteNonQuery();

                        
                        Utilities.GetOpenFormInstance().loadActivity();
                        Data_Access.DataAccess.LogAction(userId, "Approved" + newRequest.AmountIssued + " " + newItem.ItemName);

                        transaction.Commit();
                        MessageBox.Show("Approved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);  //inform the user
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Try again later or contact Administrator....", "Connection Issue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if(transaction != null)
                           transaction.Rollback();
                    }
                    finally
                    {
                        accessConnection.Close();
                    }
                }

            }
            else if (e.ColumnIndex == 1)
            {
                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {
                    cmd = new OleDbCommand();
                    accessConnection.Open();
                    cmd.Connection = accessConnection;
                    cmd.CommandText = @"Delete from RequestTbl WHERE ItemCode = [2]";
                    cmd.Parameters.AddWithValue("0", requestGridView.Rows[rowindex].Cells[3].Value.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Disapproved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);  //inform the user
                    accessConnection.Close();
                }

            }
            else
            {
                return;
            }
            RefreshItemStatus();
            getNotifications();
            RequestedItems();
        }
     
        //Get all the updated item information from the database
        public bool RefreshItemStatus()
		{

            try
            {
                string sql = "SELECT ItemName as `Item`, LastUpdated as `Last Updated`, ItemBalance as `Balance`, Unit,ReorderLevel  FROM ItemTbl  where StatusId = 1";
                DataTable datatable = new DataTable();
                dataGridView2.DataSource = datatable;
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connect))
                {
                    adapter.Fill(datatable);
                    if (datatable.Rows.Count == 0)
                    {
                        tabControl1.TabPages[3].Text = "Items (0)";
                     
                    }
                    else
                    {
                        tabControl1.TabPages[3].Text = "Items ("+ datatable.Rows.Count + ")";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Contact Administrator....", "Connection Issue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return true;
		}
		//Get all the item status from the database
		bool CheckItemStatus()
		{
			try
			{
			 string sql  = "SELECT ItemName as `Item`, LastUpdated as `Last Updated`, ItemBalance as `Balance` FROM ItemTbl  where StatusId = 1";
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
    		string sql  = @"SELECT ItemCode as `Item Code`, ItemName as `Item Name`, ItemBalance as `Balance`, Unit, LastUpdated as `Last Updated`
                           FROM ItemTbl where ItemBalance <= ReorderLevel  and StatusId = 1";
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
                        tabControl1.TabPages[0].Text = "Notifications (0)";
		    		}
		    		if(datatable.Rows.Count == 1)
		    		{
		    			statusLbl.Text = "There is an Item that needs updating";
		    			uptodatePic2.Image = Resource1._1438227993_face_sad;
		    			statusLbl.ForeColor = Color.Red;
		    			uptodatePic.Visible = false;
		    			uptodatePic2.Visible = true;
                        tabControl1.TabPages[0].Text = "Notification ("+ datatable.Rows.Count + ")";
                    }
		    		if(datatable.Rows.Count > 1)
		    		{
		    			statusLbl.Text = "There are Items that need updating";
		    			uptodatePic2.Image = Resource1._1438227993_face_sad;
		    			statusLbl.ForeColor = Color.Red;
		    			uptodatePic.Visible = false;
		    			uptodatePic2.Visible = true;

                        tabControl1.TabPages[0].Text = "Notifications (" + datatable.Rows.Count + ")";
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
    		 string sql  = @"SELECT SupplierTbl.SupplierName as `Supplier Name`, SupplierTbl.Location, ParishTbl.ParishName as `Parish`, 
            SupplierTbl.PhoneNumber1 as `Telephone 1`, SupplierTbl.PhoneNumber2  as `Telephone 2`, SupplierTbl.Email, SupplierTbl.FaxNumber  as `Fax` 
            FROM SupplierTbl INNER JOIN  ParishTbl ON SupplierTbl.ParishId = ParishTbl.ParishId
            Where SupplierTbl.SupplierName <> 'none' ORDER BY SupplierTbl.SupplierName DESC";
             DataTable datatable = new DataTable();
  			 dataGridView3.DataSource = datatable;
             OleDbDataAdapter adapter = new OleDbDataAdapter(sql,connect);
    		  adapter.Fill(datatable);
			}
			catch(Exception)
			{

			}
			finally
			{
				
			}
		}
		
		void TransactionLogsToolStripMenuItemClick(object sender, EventArgs e)
		{
			InventoryTransaction newTransLog = new InventoryTransaction();
			newTransLog.ShowDialog();
		}
		
		//Open Request form
		void AddItemRequestToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(RefreshItemStatus())
			{
				NewRequest newRequest = new NewRequest(userId);
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
				Update_Quantity newUpdateForm = new Update_Quantity(userId);
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
            requestThread.Abort();
            LoginForm splash = Application.OpenForms["LoginForm"] as LoginForm;
			splash.Close();
		}
		
		//Open delete form
		void DeleteItemToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(RefreshItemStatus())
			{
				Delete deleteForm = new Delete(userId);
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
			
				Edit editForm = new Edit(userId);
				editForm.Show();
				this.Enabled = false;	
		
		}
		
		void EditUnitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Units unitForm = new Units(userId);
			unitForm.Show();
			this.Enabled = false;
		}
		
		void CreateOrEditExistingUserToolStripMenuItemClick(object sender, EventArgs e)
		{
			CreateUser newUserForm = new CreateUser(userId);
			this.Enabled = false;
			newUserForm.Show();
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

            requestThread.Abort();
            LoginForm newForm = Application.OpenForms["LoginForm"] as LoginForm;
			newForm.Show();
			this.Dispose();
		}
		
		
/*-------------------------------------Icon tool bar------------------------------------------*/
		
		void PictureBox1MouseEnter(object sender, EventArgs e)
		{
			addPicbx.BackColor = Color.Transparent;
			addPicbx.Width = 35;
			addPicbx.Height = 31;
		}
		
		void PictureBox1MouseLeave(object sender, EventArgs e)
		{
			addPicbx.BackColor = Color.Transparent;
			addPicbx.Width = 33;
			addPicbx.Height = 28;
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
			 Add_Item newAddItemForm = new Add_Item(userId);
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
				Update_Quantity newUpdateForm = new Update_Quantity(userId);
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
			Units unitForm = new Units(userId);
			unitForm.Show();
			this.Enabled = false;
		}
		void LogRequestPicClick(object sender, EventArgs e)
		{
			if(RefreshItemStatus())
			{
				NewRequest newRequest = new NewRequest(userId);
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
				Delete deleteForm = new Delete(userId);
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
			CreateUser newUserForm = new CreateUser(userId);
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
				Edit editForm = new Edit(userId);
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
            reportForm.ShowDialog();
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
			ReceivableForm newRForm = new ReceivableForm(userId);
			this.Enabled = false;
			newRForm.Show();
		}
		
		void ReceivableLogsToolStripMenuItemClick(object sender, EventArgs e)
		{
			ReceivedLog newForm = new ReceivedLog();
            newForm.ShowDialog();
			
		}
		
		void ReceivablePicMouseEnter(object sender, EventArgs e)
		{
			receivablePic.Width = 35;
			receivablePic.Height =31;
            
        }
		
		void ReceivablePicMouseLeave(object sender, EventArgs e)
		{
			receivablePic.Width = 33;
			receivablePic.Height =28;
		}

        private void addReceivablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceivableForm newRForm = new ReceivableForm(userId);
            this.Enabled = false;
            newRForm.Show();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Category catForm = new Add_Category(userId);
            catForm.ShowDialog();
        }

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm sForm = new SupplierForm(userId);
            sForm.ShowDialog();
        }

         DataGridView GetInfo()
        {
            DataTable table = new DataTable();
            DataGridView grid = new DataGridView();
            this.Controls.Add(grid);
            DateTime fromDate = DateTime.ParseExact(Utilities.getDate(3), "dd/MM/yyyy", CultureInfo.InvariantCulture);

          
            DateTime toDate = DateTime.ParseExact(Utilities.getTodayDate(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            try
            {
                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {

                    accessConnection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = accessConnection;
                   
                    cmd.CommandText = @"Select RequestTbl.ItemName as `Item`,  SUM(RequestTbl.AmountRequested) AS `Total`, ItemTbl.Unit FROM RequestTbl INNER JOIN ItemTbl ON RequestTbl.ItemCode = ItemTbl.ItemCode Where RequestTbl.DateReceived >= [1] AND RequestTbl.DateReceived <= [2] GROUP by RequestTbl.ItemName, ItemTbl.Unit ";

                    cmd.Parameters.Add(new OleDbParameter("1", fromDate));  
                    cmd.Parameters.Add(new OleDbParameter("2", toDate));

                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                    
                    dataAdapter.Fill(table);
                    grid.Name = "graphGrid";
                    grid.AutoGenerateColumns = true;
                    grid.DataSource = table;
                    grid.Sort(grid.Columns[1], ListSortDirection.Descending);
                }
            }
            catch (Exception)
            {
               
            }
            finally
            {

            }
            return grid;
        }
        void GenerateGraph(DataGridView grid)
        {
            int i = 0;
            double startPoint = 0.5;
            double endPoint = 1.5;


            //reportChart.Series.Add(new Series("Items"));
            reportChart.Series.Clear();
            try
            {

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (i == grid.Rows.Count - 1)
                    {
                        break;
                    }
                    //reportChart.ChartAreas[0].AxisX.Title = rows.Field<String>(2);

                    reportChart.Series.Add(row.Cells[0].Value.ToString()).Points.Add(Double.Parse(row.Cells["Total"].Value.ToString()));
                    reportChart.Series[row.Cells[0].Value.ToString()].XValueType = ChartValueType.String;

                    // reportChart.Series["Items"].Points.AddXY(startPoint,  Double.Parse( row.Cells["'Total'"].Value.ToString()));
                    reportChart.Series[row.Cells[0].Value.ToString()].Points[0].Label = row.Cells[1].Value.ToString();

                    //reportChart.ChartAreas[0].AxisX.IsMarginVisible = false;
                    startPoint = startPoint + 1;

                    //endPoint = endPoint + 0.01;
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
            catch (Exception ec)
            {
                MessageBox.Show("Please Contact Administrator....", "Error Generating Graph", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export");
                return;
            }

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add ((Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet));
            Microsoft.Office.Interop.Excel.Range chartRange;
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            excel.Visible = true;
            worksheet.Cells[1, 1] = "Item Code";
            worksheet.Cells[1, 2] = "Item Name";
            worksheet.Cells[1, 3] = "Item Balance";
            worksheet.Cells[1, 4] = "Unit";
            worksheet.Cells[1, 5] = "Last Updated";

            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    worksheet.Cells[(i + 4) - 2, (j + 3) - 2] = cell.Value;
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("No data to export");
                return;
            }

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add((Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet));
            Microsoft.Office.Interop.Excel.Range chartRange;
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            excel.Visible = true;

            worksheet.Cells[1, 1] = "Item Name";
            worksheet.Cells[1, 2] = "Last Updated";
            worksheet.Cells[1, 3] = "Item Balance";
            worksheet.Cells[1, 4] = "Unit";
            worksheet.Cells[1, 5] = "ReorderLevel";



            for (int i = 0; i <= dataGridView2.RowCount - 1; i++)
            {
                for (int j = 0; j <= dataGridView2.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView2[j, i];
                    worksheet.Cells[(i + 4) - 2, (j + 3) - 2] = cell.Value;
                }
            }

        }

        private void activityExportBtn_Click(object sender, EventArgs e)
        {
            if (activityDatagrid.Rows.Count == 0)
            {
                MessageBox.Show("No data to export");
                return;
            }

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add((Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet));
            Microsoft.Office.Interop.Excel.Range chartRange;
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            excel.Visible = true;

            worksheet.Cells[1, 1] = "Username";
            worksheet.Cells[1, 2] = "Actions";
            worksheet.Cells[1, 3] = "TimeStamp";



            for (int i = 0; i <= activityDatagrid.RowCount - 1; i++)
            {
                for (int j = 0; j <= activityDatagrid.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = activityDatagrid[j, i];
                    worksheet.Cells[(i + 4) - 2, (j + 3) - 2] = cell.Value;
                }
            }

        }

        private void requestGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void requestToPdfBtn_Click(object sender, EventArgs e)
        {
            Requests requestDialog = new Requests();
            requestDialog.ShowDialog();
        }
    }
}
