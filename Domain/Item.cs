/*
 * Created by SharpDevelop.
 * User: VStudent
 * Date: 16/07/2015
 * Time: 10:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.OleDb;

namespace Inventory_System.Classes
{
	/// <summary>
	/// Description of Item.
	/// </summary>
	public class Item
	{
		private string itemCode;
		private string itemName;
		private string itemDescription;
		private double initialQuantity;
		private double balance;
		private double itemUsed;
		private string unit;
		private double reorderLevel;
        private int categoryId;
		public Item()
		{
			itemCode = null;
			itemName = null;
			itemDescription = null;
			initialQuantity = 0;
		}
		public string ItemCode
		{
			get{ return itemCode;}
			set{ itemCode = value;}
		}
		public double ReorderLevel
		{
			get{ return reorderLevel;}
			set{ reorderLevel = value;}
		}
		public string Unit
		{
			get{ return unit;}
			set{ unit = value;}
		}
		public string ItemName
		{
			get{return itemName;}
			set{itemName = value;}
		}
		public string ItemDescription
		{
			get{ return itemDescription;}
			set{itemDescription = value;}
		}
		public double InitialQuantity
		{
			get {return initialQuantity;}
			set {initialQuantity = value;}
		}
		public double Balance
		{
			get {return balance;}
			set {balance = value;}
		}
		public double ItemUsed
		{
			get {return itemUsed;}
			set {itemUsed = value;}
		}

        public int CategoryId
        {
            get
            {
                return categoryId;
            }

            set
            {
                categoryId = value;
            }
        }
    }
}
