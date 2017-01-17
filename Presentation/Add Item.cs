/*
 * Created by SharpDevelop.
 * User: VStudent
 * Date: 16/07/2015
 * Time: 04:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Data.OleDb;
using Inventory_System.Classes;
using Inventory_System.Data_Access;

namespace Inventory_System
{
	/// <summary>
	/// Description of Add_Item.
	/// </summary>
	public partial class Add_Item : Form
	{
		MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
		  private OleDbConnection accessConnection = new OleDbConnection();
		  OleDbDataAdapter adapter = new OleDbDataAdapter();
		  OleDbDataReader accessReader;
		  OleDbCommand cmd = new OleDbCommand();
		  Item newItem = new Item();
        int userId;

		public Add_Item()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
		       accessConnection.ConnectionString = Connection.getConnectionString();
		      
			InitializeComponent();
			getUnits();//Load units into combobox
			LoadSupplier();
            supplierCmBox.SelectedIndex = 0;
            getCateory();
            categoryCmbox.SelectedIndex = 0;

            //
            // 
            //
        }

        public Add_Item(int id)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            accessConnection.ConnectionString = Connection.getConnectionString();

            InitializeComponent();
            getUnits();//Load units into combobox
            LoadSupplier();
            supplierCmBox.SelectedIndex = 0;
            getCateory();
            categoryCmbox.SelectedIndex = 0;
            this.userId = id;
            //
            // 
            //
        }
        void getCateory()
        {
            categoryCmbox.DataSource = null;
            categoryCmbox.Items.Clear();
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
        public void LoadSupplier()
		{
            supplierCmBox.DataSource = null;
            supplierCmBox.Items.Clear();

            try
            {
                accessConnection.Open();
                //Populate item combo box
                cmd.CommandText = @"SELECT * FROM SupplierTbl";
                cmd.Connection = accessConnection;

                accessReader = cmd.ExecuteReader();

                var items = new System.Collections.Generic.List<object>();
                supplierCmBox.DisplayMember = "Text";
                supplierCmBox.ValueMember = "Value";
                while (accessReader.Read())
                {

                    items.Add(new { Text = accessReader.GetString(1), Value = accessReader.GetInt32(0) });
                }
                supplierCmBox.DataSource = items;

            }
            catch (Exception )
            {
            }
            finally
            {
                //Close Reader and Connection to access
                accessReader.Close();
                accessConnection.Close();
            }
		}
		
		
		void InsertBtnClick(object sender, EventArgs e)
		{
					double value2;
					newItem.ItemCode = itemCodeTxtbox.Text;
					newItem.ItemName = itemNameTxtbox.Text;
					newItem.ItemDescription = itemDescriptionTxtBox.Text;
					
					if(!double.TryParse(ReorderTxtBx.Text, out value2))
					{
						MessageBox.Show("Please enter a valid number", "Invalid Reorder Level", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					} 
					newItem.InitialQuantity = 0;
					newItem.ItemUsed = 0;
					newItem.ReorderLevel = value2;
					newItem.Balance = 0;
					if(IsEmpty())
						{
							MessageBox.Show("Fields Cannot be Empty", "Error: Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						  return;
						}
					if(unitCmbBox.Items.Count != 0 && unitCmbBox.SelectedIndex >= 0 && unitCmbBox.Text != " ")
					{
					  newItem.Unit = unitCmbBox.SelectedItem.ToString(); 
					}
					else
					{
					  MessageBox.Show("Please select valid unit", "Invalid");
					  return;
					}
					if(CheckIfItemExist(newItem.ItemName, newItem.ItemCode))
					{
						MessageBox.Show("Item already Exist");
						return;
					}
				 try
				 {
				 	
					accessConnection.Open();
					OleDbCommand cmd = new OleDbCommand();
					cmd.Connection = accessConnection;
					cmd.CommandText =  @"INSERT INTO ItemTbl(ItemCode, ItemName, ItemDescription, ItemQuantity, Unit, ItemUsed, ItemBalance, ReorderLevel, SupplierId, CategoryId, Cost)" +
			            "VALUES     ([0], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10])";
					cmd.Parameters.AddWithValue("0", newItem.ItemCode);
					cmd.Parameters.AddWithValue("1", newItem.ItemName);
					cmd.Parameters.AddWithValue("2", newItem.ItemDescription);
					cmd.Parameters.AddWithValue("3", newItem.InitialQuantity);
					cmd.Parameters.AddWithValue("4", newItem.Unit);
					cmd.Parameters.AddWithValue("5", newItem.ItemUsed);
					cmd.Parameters.AddWithValue("6", newItem.Balance);
					cmd.Parameters.AddWithValue("7", newItem.ReorderLevel);
					cmd.Parameters.AddWithValue("8", supplierCmBox.SelectedValue);
					cmd.Parameters.AddWithValue("9", categoryCmbox.SelectedValue);
					cmd.Parameters.AddWithValue("10", costNumeric.Value);
                    cmd.ExecuteNonQuery();
				    MessageBox.Show("Record Inserted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);  //inform the user
                    DataAccess.LogAction(this.userId, "Added New Item: " + newItem.ItemName);
                    Utilities.GetOpenFormInstance().loadActivity();

                    accessConnection.Close();
                    ReceivableForm newForm = new ReceivableForm(true, this.userId);
                   // MessageBox.Show(newForm.GetItemCodeListIndex(DataAccess.FindItemIndex(itemCodeTxtbox.Text)).ToString());
                   // MessageBox.Show(DataAccess.FindItemIndex(itemCodeTxtbox.Text));
                    //newForm.itemNameCmb.SelectedIndex = newForm.GetItemCodeListIndex(DataAccess.FindItemIndex(itemCodeTxtbox.Text));
                    newForm.itemNameCmb.SelectedItem = itemNameTxtbox.Text;
				    newForm.supplierCmbox.SelectedIndex = supplierCmBox.SelectedIndex;
				    newForm.Show();
                    mainForm.RefreshItemStatus();
				    mainForm.getNotifications();
				 }
				 catch(Exception)
		    	 {
                    accessConnection.Close();
                    MessageBox.Show("Try again later or contact Administrator....", "Connection Issue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 }
                 finally
				 {
				 	//close the connection
		           
		           Clear();
				 }
		}
       

        public bool IsEmpty()
		{
			foreach(Control c in groupBox1.Controls)
			{
				if(c.GetType() .Name.ToString()== "TextBox")
				{
					if(String.IsNullOrEmpty(c.Text))
					return true;
				}
			}
			return false;
		}
		
		
		
		//Clear form fields
		public void Clear()
		{
			foreach(Control c in groupBox1.Controls)
			{
				if(c.GetType() .Name.ToString()== "TextBox")
				{
					c.Text = "";
				}
			}
		}
		public bool CheckIfItemExist(string name, string code)
		{
		   bool isTrue = false;
		   try
		   {
		   	 accessConnection.Open();
		   	 cmd = new OleDbCommand();
			 cmd.Connection = accessConnection;
		     cmd.CommandText = "SELECT * From ItemTbl where ItemName = [0] Or ItemCode = [1]";
		     cmd.Parameters.AddWithValue("0", name);
		      cmd.Parameters.AddWithValue("1", code);
			 accessReader = cmd.ExecuteReader();
				 if(accessReader.HasRows)
				 {
			  	    accessReader.Close();
					isTrue =  true ;
				 } 
		   }
		   catch(Exception )
		   {

            }
		   finally
		   {
			   accessReader.Close(); 
			   accessConnection.Close();
		   }
		     return isTrue;	  
		}
		//Enable parent form when this forms closes
		void Add_ItemFormClosed(object sender, FormClosedEventArgs e)
		{
			MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
			mainForm.Enabled = true;
		}
		public void getUnits()
		{
            unitCmbBox.Items.Clear();

            try
			{
				accessConnection.Open();
				
				cmd = new OleDbCommand();
				cmd.Connection =  accessConnection;
				cmd.CommandText = @"SELECT Units From UnitTbl";
				cmd.Parameters.AddWithValue("0",unitCmbBox.SelectedItem);
				accessReader = cmd.ExecuteReader();
		    		  
	    		  while(accessReader.Read())
				  {
	    		  	unitCmbBox.Items.Add(accessReader.GetString(0));
				  } 
			}
			catch(Exception)
			{
				
			}
			finally
			{
				accessReader.Close();
				accessConnection.Close();
			}
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Units unitForm = new Units();
			unitForm.Show();
			this.Enabled = false;
		}
		
		void AddNewSupplierLinkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SupplierForm newForm = new SupplierForm();
			newForm.ShowDialog();
			
		}
		
		void SupplierCmBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

        private void Add_Item_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_Category catFrm = new Add_Category();
            catFrm.ShowDialog();
            getCateory();
        }
    }
}
