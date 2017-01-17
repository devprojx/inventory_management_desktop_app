/*
 * Created by SharpDevelop.
 * User: VStudent
 * Date: 16/07/2015
 * Time: 04:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using Inventory_System.Classes;

namespace Inventory_System
{
	/// <summary>
	/// Description of Add_Item.
	/// </summary>
	public partial class Add_Category : Form
	{
		MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
		  private OleDbConnection accessConnection = new OleDbConnection();
		  OleDbDataAdapter adapter = new OleDbDataAdapter();
		  OleDbDataReader accessReader;
		  OleDbCommand cmd = new OleDbCommand();
		  Item newItem = new Item();
        int userId;
		public Add_Category()
		{
		
		   accessConnection.ConnectionString = Connection.getConnectionString();
			InitializeComponent();

        }

        public Add_Category(int id)
        {

            accessConnection.ConnectionString = Connection.getConnectionString();
            InitializeComponent();
            this.userId = id;

        }


        void InsertBtnClick(object sender, EventArgs e)
		{
					
					
					if(IsEmpty())
						{
							MessageBox.Show("Fields Cannot be Empty", "Error: Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						  return;
						}
					
					if(CheckIfItemExist(categoryNameTxtbx.Text.Trim()))
					{
						MessageBox.Show("Item already Exist");
						return;
					}
				 try
				 {

                    using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                    {
                    accessConnection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = accessConnection;
                        cmd.CommandText = @"INSERT INTO CategoryTbl(Category)" +
                            "VALUES     ([0])";
                        cmd.Parameters.AddWithValue("0", categoryNameTxtbx.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Inserted Successfully");  //inform the user
                    Data_Access.DataAccess.LogAction(userId, "Added New Category: " + categoryNameTxtbx.Text.Trim());
                        LoadCategory();
                    Utilities.GetOpenFormInstance().loadActivity();
                }
				  
				 }
				 catch(Exception et)
		    	 {
				 	 MessageBox.Show("Database cannot be found\n"+et, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
				
				 }
				 finally
				 {
				 	
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
		public bool CheckIfItemExist(string name)
		{
		   bool isTrue = false;
		   try
		   {
                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {
                    accessConnection.Open();
                    cmd = new OleDbCommand();
                    cmd.Connection = accessConnection;
                    cmd.CommandText = "SELECT * From CategoryTbl where Category = [0]";
                    cmd.Parameters.AddWithValue("0", name);

                    using (OleDbDataReader accessReader = cmd.ExecuteReader())
                    {
                        if (accessReader.HasRows)
                        {
                            accessReader.Close();
                            isTrue = true;
                        }
                    }
                } 
		   }
		   catch(Exception )
		   {
		   	
		   }
		  
		     return isTrue;	  
		}
		//Enable parent form when this forms closes
		void Add_ItemFormClosed(object sender, FormClosedEventArgs e)
		{
			
		}

        private void Add_Category_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        public void LoadCategory()
        {
            try
            {
                ItemlistBox.Items.Clear();

                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {
                    accessConnection.Open();
                    cmd.CommandText = @"SELECT Category FROM CategoryTbl where category <> 'Misc'";
                    cmd.Connection = accessConnection;

                    using (OleDbDataReader accessReader = cmd.ExecuteReader()) {

                        while (accessReader.Read())
                        {
                            ItemlistBox.Items.Add(accessReader.GetString(0));
                        }
                         
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
            }       

        public void DeleteCategory(string category)
        {
            try
            {

                using (OleDbConnection accessConnection = new OleDbConnection(Connection.getConnectionString()))
                {
                    OleDbTransaction transaction = null;

                    try
                    {
                        accessConnection.Open();
                        transaction = accessConnection.BeginTransaction(IsolationLevel.ReadCommitted);
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = @"UPDATE ItemTbl Set CategoryId = 1 WHERE CategoryId = (Select 
                                        CategoryId from CategoryTbl where Category = [0])";
                        cmd.Connection = accessConnection;
                        cmd.Parameters.AddWithValue("0", category);
                        cmd.Transaction = transaction;
                        cmd.ExecuteNonQuery();

                        OleDbCommand cmd2 = new OleDbCommand();
                        cmd2.CommandText = @"DELETE FROM CategoryTbl WHERE Category = [0]";
                        cmd2.Connection = accessConnection;
                        cmd2.Parameters.AddWithValue("0", category);
                        cmd2.Transaction = transaction;
                        cmd2.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Record Deleted Successfully","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);  //inform the user
                        Data_Access.DataAccess.LogAction(userId, "Deleted Category: " + category);
                        Utilities.GetOpenFormInstance().loadActivity();
                        LoadCategory();
                    }catch(Exception e)
                    {
                        
                        MessageBox.Show("Category was not deleted... Contact Administrator\n", "Connection Issue", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);  //inform the user
                        transaction.Rollback();
                    }

                }

            }
            catch (Exception)
            {

            }
           
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ItemlistBox.SelectedIndex < 0)
                return;
            DialogResult dialog = MessageBox.Show("Are you sure you want to Delete Category? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                DeleteCategory(ItemlistBox.SelectedItem.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
