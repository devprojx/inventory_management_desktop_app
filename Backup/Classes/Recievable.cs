/*
 * Created by SharpDevelop.
 * User: 
 * Date: 9/7/2015
 * Time: 6:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Inventory_System.Classes
{
	/// <summary>
	/// Description of Recievable.
	/// </summary>
	public class Receivable
	{
		private string dateRecorded;
		private double quantityRecorded;
		private double cost;
		private string itemCode;
		private int supplierId;
		
		public Receivable()
		{
			quantityRecorded = 0.0;
			cost = 0.0;
		}
		
		public string DateReceived
		{
			get{return dateRecorded;}
			set{dateRecorded = value;}
		}
		
		public double QuantityReceived
		{
			get{return quantityRecorded;}
			set{quantityRecorded = value;}
		}
		
		public double Cost
		{
			get{return cost;}
			set{cost = value;}
		}
		
		public string ItemCode
		{
			get{return itemCode;}
			set{ itemCode = value;}
		}
		
		public int SupplierId
		{
			get{return supplierId;}
			set{supplierId = value;}
		}
	}
}
