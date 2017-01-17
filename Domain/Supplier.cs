/*
 * Created by SharpDevelop.
 * User: vstudent
 * Date: 9/9/2015
 * Time: 11:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Inventory_System.Classes
{
	/// <summary>
	/// Description of Supplier.
	/// </summary>
	public class Supplier
	{
		private int supplierId;
		private string supplierName;
		private string location;
		private int parishId;
		private string email;
		private string phoneNumber1;
		private string phoneNumber2;
		private string faxNumber;
		
		public Supplier()
		{
		}
		
		public int SupplierId
		{
			get{ return supplierId;}
			set{ supplierId = value;}
		}
		public string SupplierName
		{
			get {return supplierName;}
			set { supplierName = value;}
		}
		public string Location
		{
			get { return location;}
			set { location = value;}
		}
	
		public string Email
		{
			get { return email;}
			set { email = value;}
		}
		public int ParishId
		{
			get { return parishId;}
			set { parishId = value;}
		}
		public string PhoneNumber1
		{
			get { return phoneNumber1;}
			set { phoneNumber1 = value;}
		}
		public string PhoneNumber2
		{
			get { return phoneNumber2;}
			set { phoneNumber2 = value;}
		}
		public string FaxNumber
		{
			get {return faxNumber;}
			set {faxNumber = value;}
		}
	}
}
