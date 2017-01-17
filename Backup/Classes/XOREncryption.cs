/*
 * Created by SharpDevelop.
 * User: Teachers
 * Date: 25/07/2015
 * Time: 06:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Inventory_System.Classes
{
	/// <summary>
	/// Description of XOREncryption.
	/// </summary>
	public class XOREncryption
	{
		private static XOREncryption instance = null;
		public string key = @"$#%^&*((*@!_)*(@&&@&*&^#^&@(*@(*!)(@&@*())@*&&#&^*&^*(#)*#&^#&*(#)#(*&";//key for encrypting and decrypting data
		//To prevent the class for being instansiated publicly
		private XOREncryption()
		{
			
		}
		
		/// <summary>
		/// Encrypt a password using a key 
		/// </summary>
		/// <param name="password">Plain text password string</param>
		/// <param name="key">key to encrypt data</param>
		/// <returns>string</returns>
		public string EncryptPassword(string password, string key)
		{
			char[] copyPassword = new char[password.Length];
			string tempPassword = password;
			int i = 0;
			password = "";
			foreach(char letter in tempPassword)
			{
				copyPassword[i] = letter;
				copyPassword[i]^= key[i];
				password += copyPassword[i].ToString();
				i++;
			}
			
			return password;
		}
	
		/// <summary>
		/// Decrypt a password using the same key used to encrytp it
		/// </summary>
		/// <param name="password">Encrypt password string</param>
		/// <param name="key">key used to encrypt data</param>
		/// <returns>string</returns>
		public string DecryptPassword(string password, string key)
		{
			char[] copyPassword = new char[password.Length];
			string tempPassword = password;
			int i = 0;
			password = "";
			foreach(char letter in tempPassword)
			{
				copyPassword[i] = letter;
				copyPassword[i]^= key[i];
				password += copyPassword[i].ToString();
				i++;
			}
			
			return password;
		}
		
		public static XOREncryption getInstance()
		{
			if(instance == null)
			{
				instance = new XOREncryption();
			}
			return instance;
		}
	}
}
