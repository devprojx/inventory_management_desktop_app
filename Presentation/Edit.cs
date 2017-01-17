/*
 * Created by SharpDevelop.
 * User: Vstudent
 * Date: 7/22/2015
 * Time: 4:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using Inventory_System.Classes;
using System.Collections.Generic;

namespace Inventory_System
{
	/// <summary>
	/// Description of Edit.
	/// </summary>
	/// 

	public partial class Edit : Form
	{
	    MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
		private OleDbConnection accessConnection = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader accessReader;
        Item newItem = new Item();

		string itemCode;
		double temporaryQuantity ; // use to check if quantiy has been changed
        int userId;

		public Edit()
		{
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //

            InitializeComponent();
			accessConnection.ConnectionString = Connection.getConnectionString();
			LoadItemCode();
			getUnits();
            getCateory();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        public Edit(int id)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            accessConnection.ConnectionString = Connection.getConnectionString();
            LoadItemCode();
            getUnits();
            getCateory();
            userId = id;


            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        void ItemlistBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			if(ItemlistBox.SelectedIndex< 0)
			{
				return;
			}
			
			errorlb.Visible = false;
			errorlb1.Visible = false;
			refreshList();
		}
		
		public void LoadItemCode()
		{
			try
			{

                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {
                    accessConnection.Open();
                    cmd.CommandText = @"SELECT  ItemName FROM ItemTbl";
                    cmd.Connection = accessConnection;

                    using (OleDbDataReader accessReader = cmd.ExecuteReader())
                    {

                        while (accessReader.Read())
                        {
                            ItemlistBox.Items.Add(accessReader.GetString(0));
                        }
                    }
                }
			}
			catch(Exception)	
			{
				
			}
			
		}
		
		void EditFormClosed(object sender, FormClosedEventArgs e)
		{
			Form form = Application.OpenForms["MainForm"] as Form;
				
				form.Enabled = true;
		}
		
		void SaveBasicInfo()
		{
			int status = 0;
			if(IsInfoEmpty())
			{
				errLb2.Visible = true;
				return;
			}
			 errLb2.Visible = false;
	    	   newItem.ItemName =	itemNameTxtbox.Text;
	    	   newItem.ItemDescription = itemDescriptionTxtBox.Text;

	    	   DialogResult dialog =  MessageBox.Show("Are you sure you want to save changes? ", "", MessageBoxButtons.YesNo);
				  if(dialog != DialogResult.Yes)
				  {
				  	return;
				  }
				  if(radioButton1.Checked)
				  {
				  	status = 1;
				  }
				  else if(radioButton2.Checked)
				  {
				  	status = 2;
				  }
				 
	    	   try
	    	   {
                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {
                    accessConnection.Open();
                    cmd = new OleDbCommand();
                    cmd.Connection = accessConnection;
                    cmd.CommandText = "UPDATE ItemTbl SET  ItemName = [1], ItemDescription = [2], StatusId = [3] , CategoryId =  [4], Cost = [5]  WHERE ItemCode = [6]";
                    cmd.Parameters.AddWithValue("1", newItem.ItemName);
                    cmd.Parameters.AddWithValue("2", newItem.ItemDescription);
                    cmd.Parameters.AddWithValue("3", status);
                    cmd.Parameters.AddWithValue("4", categoryCmbox.SelectedValue);
                    cmd.Parameters.AddWithValue("5", costNumeric.Value);
                    cmd.Parameters.AddWithValue("6", itemCode);


                    cmd.ExecuteNonQuery();
                    Data_Access.DataAccess.LogAction(userId, "Updated Basic Information for item: " + ItemlistBox.SelectedItem);
                    Utilities.GetOpenFormInstance().loadActivity();
                    MessageBox.Show("Record updated Successfully");  //inform the user
                    Clear();
                }
                    mainForm.RefreshItemStatus();
                    mainForm.getNotifications();
                
				 }
				 catch(Exception ex)
				 {
				 	 MessageBox.Show("Unexpected Error: Data could not be saved\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );	
				 }
				 finally
				 {
				 	if(!(ItemlistBox.Items.Count <= 0))
						{
							ItemlistBox.Items.Clear();
							unitCmbBox.Text = "";
							
                        }
				 	LoadItemCode();
				 	refreshList();
                   
				 }  
  	
		}	
		
		void SaveQuantityInfo()
		{
			double temp1, temp2;
			if(IsQuantiyEmpty())
			{
				errlbl1.Visible = true;
				return;
			}
			errlbl1.Visible = false;
				if(double.TryParse(initialQuantityTxtBox.Text, out temp1))
				{
					newItem.InitialQuantity = temp1;
				}
				else
				{
					initialQuantityTxtBox.Text = "";
					return;
				}
				newItem.Balance = temp1;
				if(double.TryParse(ReorderTxtBx.Text, out temp2))
				{
					newItem.ReorderLevel = temp2;
				}
				else
				{
					ReorderTxtBx.Text = "";
					return;
				}
				if(unitCmbBox.SelectedIndex >= 0)
				{
					newItem.Unit = unitCmbBox.SelectedItem.ToString();
				}
				else
				{
					MessageBox.Show("Please select valid unit", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
	    	    newItem.ItemDescription = itemDescriptionTxtBox.Text;
			    DialogResult dialog =  MessageBox.Show("Are you sure you want to save changes? ", "", MessageBoxButtons.YesNo);
				  if(dialog == DialogResult.Yes)
				  {
						  if(temporaryQuantity != newItem.InitialQuantity)
						   {
					    	   try
					    	   {
                                    using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                                    {
                                        accessConnection.Open();
                                        cmd = new OleDbCommand();
                                        cmd.Connection = accessConnection;
                                        cmd.CommandText = "UPDATE ItemTbl SET ItemQuantity = [0], ItemBalance = [1], Unit = [2], ReorderLevel = [3] WHERE ItemName = [4]";
                                        cmd.Parameters.AddWithValue("0", newItem.InitialQuantity);
                                        cmd.Parameters.AddWithValue("1", newItem.Balance);
                                        cmd.Parameters.AddWithValue("2", newItem.Unit);
                                        cmd.Parameters.AddWithValue("3", newItem.ReorderLevel);
                                        cmd.Parameters.AddWithValue("4", ItemlistBox.SelectedItem.ToString());
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Record updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);  //inform the user
                                        Data_Access.DataAccess.LogAction(userId, "Updated Quantity for item: " + ItemlistBox.SelectedItem);
                                        Utilities.GetOpenFormInstance().loadActivity();
                                        Clear();
                                        if (!(ItemlistBox.Items.Count <= 0))
                                        {
                                            ItemlistBox.Items.Clear();
                                            unitCmbBox.Text = "";
                                        }
                                        mainForm.RefreshItemStatus();
                                        mainForm.getNotifications();
                            
                                    }
								 }
								 catch(Exception)
								 {
                                   MessageBox.Show("Try again later or contact Administrator....", "Connection Issue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                 }
                                 finally
								 {
								 	
								 	LoadItemCode();
								 	refreshList();
								 }  
						   }
						   else
						   {
						   	   try
					    	   {
                                    using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                                    {
                                        accessConnection.Open();
                                        cmd = new OleDbCommand();
                                        cmd.Connection = accessConnection;
                                        cmd.CommandText = "UPDATE ItemTbl SET  Unit = [0], ReorderLevel = [1] WHERE ItemName = [2]";
                                        cmd.Parameters.AddWithValue("0", newItem.Unit);
                                        cmd.Parameters.AddWithValue("1", newItem.ReorderLevel);
                                        cmd.Parameters.AddWithValue("2", ItemlistBox.SelectedItem);
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Record updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);  //inform the user
                                        Data_Access.DataAccess.LogAction(userId, "Updated Quantity for item: " + ItemlistBox.SelectedItem);
                                        Clear();
                                        if (!(ItemlistBox.Items.Count <= 0))
                                        {
                                            ItemlistBox.Items.Clear();
                                            unitCmbBox.Text = "";
                                        }
                                        mainForm.RefreshItemStatus();
                                        mainForm.getNotifications();
                                      Utilities.GetOpenFormInstance().loadActivity();
                                }
								}
								 catch(Exception ex)
								 {
                                    MessageBox.Show("Try again later or contact Administrator....", "Connection Issue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                 }
                                 finally
								 {
								 	refreshList();
								 	LoadItemCode();
								 }  
						   }
				 }	
		}	
		
		void refreshList()
		{
			int status;
			if(ItemlistBox.SelectedIndex < 0)
			{
				return;
			}
			try
			{
                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {
                    accessConnection.Open();
                    cmd = new OleDbCommand();
                    cmd.Connection = accessConnection;
                    cmd.CommandText = @"SELECT ItemCode, ItemName,  ItemDescription, ItemQuantity,ReorderLevel,Unit, StatusTbl.StatusId, Category, Cost From (ItemTbl 
                                     INNER JOIN StatusTbl ON ItemTbl.StatusId = StatusTbl.StatusId ) 
                                     INNER JOIN CategoryTbl ON CategoryTbl.CategoryId = ItemTbl.CategoryId where itemName = [0]";
                    cmd.Parameters.AddWithValue("0", ItemlistBox.SelectedItem);
                    using (OleDbDataReader accessReader = cmd.ExecuteReader())
                    {

                        while (accessReader.Read())
                        {
                            itemCode = accessReader.GetString(0);
                            unitCmbBox.Text = accessReader.GetString(5);
                            temporaryQuantity = accessReader.GetDouble(3);
                            itemNameTxtbox.Text = accessReader.GetString(1);
                            itemDescriptionTxtBox.Text = accessReader.GetString(2);
                            initialQuantityTxtBox.Text = accessReader.GetDouble(3).ToString();
                            ReorderTxtBx.Text = accessReader.GetDouble(4).ToString();
                            costNumeric.Value = Decimal.Parse(accessReader.GetDouble(8).ToString());
                            status = accessReader.GetInt32(6);
                            categoryCmbox.Text = accessReader.GetString(7);
                            if (status == 1)
                            {
                                radioButton1.Checked = true;
                            }
                            else
                            {
                                radioButton2.Checked = true;
                            }
                        }
                    }
                }
			}
			catch(Exception e)
			{
                MessageBox.Show("Unable to load Items... Contact Administrator."+e.Message + e.StackTrace, "Connection Issue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
			{
			}
		}
		
		void SaveBasicBtnClick(object sender, EventArgs e)
		{
			if(ItemlistBox.SelectedIndex < 0)
			{
				MessageBox.Show("No item selected: Select item from listbox");
				return;
			}
			SaveBasicInfo();
			
		}

		void Clear()
		{
			foreach(Control controls in groupBox1.Controls)
			{
				if(controls.GetType() == typeof(TextBox))
				{
					controls.Text = "";
				}
			}
			foreach(Control controls in groupBox2.Controls)
			{
				if(controls.GetType() == typeof(TextBox))
				{
					controls.Text = "";
				}
			}
		}
		
		void SaveQuantityBtnClick(object sender, EventArgs e)
		{
			if(ItemlistBox.SelectedIndex < 0)
			{
				MessageBox.Show("No item selected: Select item from listbox", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			SaveQuantityInfo();
		}

		bool IsQuantiyEmpty()
		{
			foreach(Control controls in groupBox2.Controls)
			{
				if(controls.GetType() == typeof(TextBox))
				{
					if(controls.Text == "")
					{
						return true;
					}
				}
			}
			return false;
			
		}

		//Check if cpntrols are empty
		bool IsInfoEmpty()
		{
			foreach(Control controls in groupBox1.Controls)
			{
				if(controls.Text == "")
					{
						return true;
					}
			}
			return false;
		}
		
        //get the unit from the database
	    void getUnits()
		{
			try
			{
                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {
                    accessConnection.Open();
                    cmd = new OleDbCommand();
                    cmd.Connection = accessConnection;
                    cmd.CommandText = @"SELECT Units From UnitTbl";
                    cmd.Parameters.AddWithValue("0", ItemlistBox.SelectedItem);
                    using (OleDbDataReader accessReader = cmd.ExecuteReader())
                    {

                        while (accessReader.Read())
                        {
                            unitCmbBox.Items.Add(accessReader.GetString(0));
                        }
                    }
                }
			}
			catch(Exception)
			{
				
			}
			
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
                        var items = new List<object>();
                        categoryCmbox.DisplayMember = "Text";
                            categoryCmbox.ValueMember = "Value";
                        while (accessReader.Read())
                        {
                           items.Add( new { Text = accessReader.GetString(1), Value = accessReader.GetInt32(0)  });
                        }
                        categoryCmbox.DataSource = items;
                    }
                }
            }
            catch (Exception)
            {

            }
            
        }
	
		void ReorderTxtBxLeave(object sender, EventArgs e)
		{
			double value;
			if(double.TryParse(ReorderTxtBx.Text, out value))
			{
				newItem.ReorderLevel = value;
				errorlb1.Visible = false;
			}
			else
			{
				errorlb1.Visible = true;
				ReorderTxtBx.Text = "";
				return;
			}
			   
		}
		
		void InitialQuantityTxtBoxLeave(object sender, EventArgs e)
		{
			double value;
			if(double.TryParse(initialQuantityTxtBox.Text, out value))
			{
				newItem.InitialQuantity = value;
				errorlb.Visible = false;
			}
			else
			{
				errorlb.Visible = true;
				initialQuantityTxtBox.Text = "";
				return;
			}
		}

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
