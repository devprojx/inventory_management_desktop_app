/*
 * Created by SharpDevelop.
 * User: Vstudent
 * Date: 7/23/2015
 * Time: 4:23 PM
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
	/// Description of Units.
	/// </summary>
	public partial class Units : Form
	{
		Add_Item addItemForm = Application.OpenForms["Add_Item"] as Add_Item;
		private OleDbConnection accessConnection = new OleDbConnection();
		Item newItem = new Item();
		OleDbCommand cmd = new OleDbCommand();
		OleDbDataReader accessReader;
        int userId;
		public Units()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			accessConnection.ConnectionString = Connection.getConnectionString();
			InitializeComponent();
			getUnits();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
        public Units(int id)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            accessConnection.ConnectionString = Connection.getConnectionString();
            InitializeComponent();
            getUnits();
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            this.userId = id;
        }
        void getUnits()
		{
			
			unitListBox.Items.Clear();
			try
			{
				accessConnection.Open();
				
				cmd = new OleDbCommand();
				cmd.Connection =  accessConnection;
				cmd.CommandText = @"SELECT Units From UnitTbl";
				accessReader = cmd.ExecuteReader();
		    		  
	    		  while(accessReader.Read())
				  {
	    		  	unitListBox.Items.Add(accessReader.GetString(0));
				  } 
			}
			catch(Exception ed)
			{
				MessageBox.Show("" +ed);
			}
			finally
			{
				accessReader.Close();
				accessConnection.Close();
			}
		}
		
		void DeleteBtnClick(object sender, EventArgs e)
		{
			if(unitListBox.SelectedIndex < 0)
			{
				return;
			}
			
			DialogResult dialog = MessageBox.Show("Do you really want to delete item? ", "", MessageBoxButtons.YesNo);
			if (dialog == DialogResult.Yes)
			{
				try
				{
					accessConnection.Open();
					cmd = new OleDbCommand();
					cmd.Connection =  accessConnection;
					cmd.CommandText = @"Delete * From UnitTbl where Units = [0]";
					cmd.Parameters.AddWithValue("0", unitListBox.SelectedItem.ToString());
					cmd.ExecuteNonQuery();
		    		  MessageBox.Show("Record deleted Successfully");
		    		  unitListBox.Items.Clear();
                    Data_Access.DataAccess.LogAction(userId, "Deleted Unit: " + unitListBox.SelectedItem.ToString());
                    Utilities.GetOpenFormInstance().loadActivity();

                }
				catch(Exception ed)
				{
					MessageBox.Show(""+ ed);
				}
				finally
				{
					accessReader.Close();
					accessConnection.Close();
					getUnits();
				}
			}
		}
		public bool CheckIfItemExist(string name)
		{
		   bool isTrue = false;
		   try
		   {
		   	 accessConnection.Open();
			 cmd.Connection = accessConnection;
		     cmd.CommandText = @"SELECT * From UnitTbl where Units = [0]";
		     cmd.Parameters.AddWithValue("0", name);
			 accessReader = cmd.ExecuteReader();
				 if(accessReader.HasRows)
				 {
			  	    accessReader.Close();
					isTrue =  true;
				 } 
		   }
		   catch(Exception e)
		   {
		   	 MessageBox.Show("Unexpected error as occured" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
		   }
		   finally
		   {
			   accessReader.Close(); 
			   accessConnection.Close();
		   }
		    
		     return isTrue;	  
		}
		
		void SaveBtnClick(object sender, EventArgs e)
		{
			
			OleDbCommand cmd = new OleDbCommand();
			newItem.Unit = newUnitTxtBox.Text;
			if(newItem.Unit == "")
			{
				MessageBox.Show("Item unit cannot be empty", "Empty Unit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			
			try
			{
				cmd.Connection = accessConnection;
				if(CheckIfItemExist(newItem.Unit))
						{
							MessageBox.Show("Item already Exist");
							unitListBox.Items.Clear();
							return;
						}
				accessConnection.Open();
				 cmd = new OleDbCommand();
				cmd.Connection =  accessConnection;
				cmd.CommandText =  @"INSERT INTO UnitTbl(Units)" +
		            				"VALUES     ([0])";
				cmd.Parameters.AddWithValue("0", newItem.Unit);
	    		cmd.ExecuteNonQuery();
                Data_Access.DataAccess.LogAction(userId, "Added Unit: " + newUnitTxtBox.Text);
                Utilities.GetOpenFormInstance().loadActivity();
                MessageBox.Show("Record inserted Successfully");  //inform the user
	    		unitListBox.Items.Clear();
    		
			}
			catch(Exception ex)
			{
				 MessageBox.Show("Unexpected error as occured" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			finally
			{
				accessReader.Close();
				accessConnection.Close();
				newUnitTxtBox.Text = "";
				 getUnits();
			}
		}
		
		void UnitsFormClosed(object sender, FormClosedEventArgs e)
		{
			addItemForm.Enabled = true;
			addItemForm.getUnits();
		}

        private void Units_Load(object sender, EventArgs e)
        {

        }
    }
}
