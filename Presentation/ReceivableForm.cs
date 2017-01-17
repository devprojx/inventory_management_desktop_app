/*
 * Created by SharpDevelop.
 * User: Olewis
 * Date: 9/7/2015
 * Time: 6:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Data.OleDb;
using Inventory_System.Classes;
using System.Collections.Generic;

namespace Inventory_System
{
	/// <summary>
	/// Description of ReceivableForm.
	/// </summary>
	public partial class ReceivableForm : Form
	{
        
		private OleDbConnection accessConnection = new OleDbConnection();
		OleDbDataAdapter adapter = new OleDbDataAdapter();
		OleDbCommand cmd = new OleDbCommand();
		OleDbDataReader accessReader ;
		List<string> itemCodeList = new List<string>();
		List<int> supplierIdList = new List<int>();
		List<double> costList = new List<double>();
        Receivable newReceivable = new Receivable();
		Item newItem = new Item();
        int userId;

        public int GetItemCodeListIndex(string value)
        {
            return this.itemCodeList.IndexOf(value);
        }
        public ReceivableForm(int id)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            accessConnection.ConnectionString = Connection.getConnectionString();
            this.LoadItemName();
            this.LoadSupplier();
            userId = id;
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        public ReceivableForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			accessConnection.ConnectionString = Connection.getConnectionString();
			this.LoadItemName();
			this.LoadSupplier();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        public ReceivableForm(bool disable, int id)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            accessConnection.ConnectionString = Connection.getConnectionString();
            this.LoadItemName();
            this.LoadSupplier();
            if (disable)
            {
                itemNameCmb.Enabled = true;
                datepicker.Enabled = false;
                supplierCmbox.Enabled = false;

            }
            userId = id;
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        public void findSuplier(string ItemCode )
        {
            supplierCmbox.Items.Clear();
            supplierIdList.Clear();
            try
            {
                accessConnection.Open();
                //Populate item combo box
                cmd.CommandText = @"SELECT * FROM SupplierTbl where supplierId = (Select supplierId
                                     FROM ItemTbl where ItemCode = '"+ ItemCode +"')";
                cmd.Connection = accessConnection;

                accessReader = cmd.ExecuteReader();

                while (accessReader.Read())
                {
                    supplierCmbox.Items.Add(accessReader.GetString(1));
                    supplierIdList.Add(accessReader.GetInt32(0));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                //Close Reader and Connection to access
                accessReader.Close();
                accessConnection.Close();
            }
        }
        public void LoadItemName()
		{
			
			try
			{
				accessConnection.Open();
		        //Populate item combo box
				cmd.CommandText =  @"SELECT ItemCode, ItemName, cost FROM ItemTbl where statusId = 1";
	            cmd.Connection = accessConnection;
			 
				 accessReader =  cmd.ExecuteReader();
			
				while(accessReader.Read())
				{
					itemNameCmb.Items.Add(accessReader.GetString(1) );
					itemCodeList.Add(accessReader.GetString(0));
                    costList.Add(accessReader.GetDouble(2));

                }
			}
			catch(Exception)
			{
				
			}
			finally
			{
				//Close Reader and Connection to access
				accessReader.Close();
				accessConnection.Close();
			}
	     }
		
		public void LoadSupplier()
		{
			supplierCmbox.Items.Clear();
			supplierIdList.Clear();
			try
			{
				accessConnection.Open();
		        //Populate item combo box
				cmd.CommandText =  @"SELECT * FROM SupplierTbl";
	           cmd.Connection = accessConnection;
			 
				 accessReader =  cmd.ExecuteReader();
			  
				while(accessReader.Read())
				{
					supplierCmbox.Items.Add(accessReader.GetString(1) );
					supplierIdList.Add(accessReader.GetInt32(0));
				}
			}
			catch(Exception )
			{	
			}
			finally
			{
				//Close Reader and Connection to access
				accessReader.Close();
				accessConnection.Close();
			}
		}
		
		
		void SaveReceivables()
		{
			string query = @"INSERT INTO ReceivedLogTbl(ItemCode, DateReceived, QuantityReceived, SupplierId, PerCost) 
                              VALUES ([0],[1],[2],[3], [4] )";
            OleDbTransaction transaction = null;
                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {

                    accessConnection.Open();

                    MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
                    double temp = 0;
                    newItem.Balance = newReceivable.QuantityReceived;
                    newItem.ItemName = itemNameCmb.SelectedItem.ToString();
                    try
                    {
                           OleDbCommand cmd = new OleDbCommand();
                           transaction = accessConnection.BeginTransaction();
                            cmd.Connection = accessConnection;
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("0", newReceivable.ItemCode);
                            cmd.Parameters.AddWithValue("1", newReceivable.DateReceived);
                            cmd.Parameters.AddWithValue("2", newReceivable.QuantityReceived);
                            cmd.Parameters.AddWithValue("3", newReceivable.SupplierId);
                            cmd.Parameters.AddWithValue("4", costList[itemCodeList.IndexOf(newReceivable.ItemCode)]);
        
                            MessageBox.Show(cmd.CommandText);
                    cmd.Transaction = transaction;
                            cmd.ExecuteNonQuery();
                           
                    if (itemNameCmb.Enabled == false)
                            {
                                this.Close();
                            }
                            
                            OleDbCommand cmd2 = new OleDbCommand();
                            cmd2.Connection = accessConnection;
                            cmd2.CommandText = @"SELECT ItemQuantity, ItemBalance FROM ItemTbl where ItemName = [0]";
                            cmd2.Parameters.AddWithValue("0", newItem.ItemName);
                            cmd2.Transaction = transaction;
                            using (OleDbDataReader accessReader = cmd2.ExecuteReader())
                            {

                                while (accessReader.Read())
                                {
                                    newItem.InitialQuantity = accessReader.GetDouble(0);
                                    temp = accessReader.GetDouble(1);
                                }
                            }
                        
                            OleDbCommand cmd3 = new OleDbCommand();
                            cmd3.Connection = accessConnection;
                            newItem.InitialQuantity += temp;
                            newItem.Balance += temp;
                            cmd3.CommandText = "UPDATE ItemTbl SET ItemBalance = [0], ItemQuantity = [2], LastUpdated = Date() WHERE ItemName = [3]";
                            cmd3.Parameters.AddWithValue("0", newItem.Balance);
                            cmd3.Parameters.AddWithValue("2", newItem.InitialQuantity);
                            cmd3.Parameters.AddWithValue("3", newItem.ItemName);
                            cmd3.Transaction = transaction;
                            cmd3.ExecuteNonQuery();
                            Data_Access.DataAccess.LogAction(userId, "Received " + quantityTxtbox.Text + " " + newItem.ItemName);
                            Utilities.GetOpenFormInstance().loadActivity();
                            mainForm.RefreshItemStatus();
                            mainForm.getNotifications();

                            transaction.Commit();
                    MessageBox.Show("Item updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);  //inform the user


                }
                catch (Exception e)
                    {
                    MessageBox.Show("Contact Administrator....." + e.Message +""+e.InnerException+""+e.StackTrace, "Connection Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (transaction != null)
                            transaction.Rollback();
                    }

                }
            
			
          
			
		}
		

		void SaveBtnClick(object sender, EventArgs e)
		{
			bool errCheck = false;
            double result = 0;
           
           
            if (!double.TryParse(quantityTxtbox.Text.Trim(), out result))
            {
                err2.Visible = true;
                MessageBox.Show("Invalid Number. Please enter only numbers. A peroid is also allowed", "Invalid Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                err2.Visible = false;

            }
            if (itemNameCmb.SelectedIndex > -1 && itemNameCmb.SelectedIndex < itemNameCmb.Items.Count)
			{
			   newReceivable.ItemCode = itemCodeList[itemNameCmb.SelectedIndex].ToString();
			   err4.Visible = false;
			}
			else
			{
				 errCheck = true;
				 err4.Visible = true;
			}
		
			
			if(double.TryParse(quantityTxtbox.Text, out result))
			{
				err2.Visible = false;
				newReceivable.QuantityReceived = result;
			}
			else
			{
				err2.Visible = true;
				errCheck = true;
			}
			newReceivable.DateReceived = datepicker.Value.ToString("dd/MM/yyyy");
			
			if(supplierCmbox.SelectedIndex > -1 && itemNameCmb.SelectedIndex < itemNameCmb.Items.Count)
			{
			  newReceivable.SupplierId = supplierIdList[supplierCmbox.SelectedIndex];
			  err3.Visible = false;
			}
			else
			{
				errCheck = true;
				err3.Visible = true;
			}
			if(Utilities.getInstance().IsEmpty(panel1))
			{
				errCheck = true;
				errorLb1.Visible = true;
			}
			errorLb1.Visible = false;
			if(errCheck)
			{
				return;
			}
			this.SaveReceivables();
			
			Utilities.getInstance().Clear(panel1);
		}
		
		void AddNewSupplierLinkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SupplierForm newForm = new SupplierForm();
			this.Enabled = false;
			newForm.Show();
		}
	
		
		void ItemNameCmbSelectedIndexChanged(object sender, EventArgs e)
		{
            if (itemNameCmb.SelectedIndex < 0 || itemNameCmb.SelectedIndex > itemNameCmb.Items.Count)
                return;
                findSuplier(itemCodeList[itemNameCmb.SelectedIndex]);
            
        }
		
		void ReceivableFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Add_Item newForm = Application.OpenForms["Add_Item"] as Add_Item;
			if(newForm == null)
			{
				MainForm newForm2 =  Application.OpenForms["MainForm"] as MainForm;
				newForm2.Enabled = true;

			}
			else
			{

                newForm.Clear();
			}
		}

        private void ReceivableForm_Load(object sender, EventArgs e)
        {

        }

        private void costTxtbox_MouseLeave(object sender, EventArgs e)
        {

        }

        private void costTxtbox_Leave(object sender, EventArgs e)
        {
         
        }

        private void quantityTxtbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void quantityTxtbox_Leave(object sender, EventArgs e)
        {
           
        }

        private void addNewSupplierLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplierForm newForm = new SupplierForm();
            newForm.ShowDialog();
            LoadSupplier();
        }

        private void err1_Click(object sender, EventArgs e)
        {

        }
    }
}
