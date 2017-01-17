/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 16/07/2015
 * Time: 09:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Inventory_System.Classes
{
	/// <summary>
	/// Description of Request.
	/// </summary>
	public class Request
	{
		private string itemCode;
		private string dateRequested;
		private double amountRequested;
		private string issuedby;
		private double amountIssued;
		private string dateIssued;
		private string receivedBy;
		private string dateReceived;
		public Request()
		{
		}
		
		public string ItemCode
		{
			get{ return itemCode;}
			set
			{
				itemCode = value;
			}
		}
		public string DateRequested
	    {
			get{ return dateRequested;}
			set
			{
				dateRequested = value;
			}
		}
		public double AmountRequested
	     {
			get{ return amountRequested;}
			set
			{
				amountRequested = value;
			}
		}
		public string Issuedby
		{ 
			get{ return issuedby;}
			set
			{
				issuedby = value;
			}
		}
		
		public double AmountIssued
	    { 
			get{ return amountIssued;}
			set
			{
				amountIssued = value;
			}
		}
		public string DateIssued
		 { 
			get{ return dateIssued;}
			set
			{
				dateIssued = value;
			}
		}
		public string ReceivedBy
		{ 
			get{ return receivedBy;}
			set
			{
				receivedBy = value;
			}
		}
		public string DateReceived
		{ 
			get{ return dateReceived;}
			set
			{
				dateReceived = value;
			}
		}
	}
}
