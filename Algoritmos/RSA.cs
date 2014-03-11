using System;
using System.Security.Cryptography;

namespace TransEncripHash
{
	/// <summary>
	/// Summary description for RSA.
	/// </summary>
	public class miRSA
	{
		private RSACryptoServiceProvider _objRSA = null;

		public miRSA()
		{
			this._objRSA = new RSACryptoServiceProvider(1024);
		}

		public string ObtenerLlavePublica()
		{
			return this._objRSA.ToXmlString(false);
		}

		public string DesEncriptar(byte[] bytEncriptado, bool blnConSimetrico)
		{
			if (blnConSimetrico)
			{
				byte[] keyArray = new byte[_objRSA.KeySize/8];
				byte[] encrypted = new byte[bytEncriptado.Length - keyArray.Length];
				Array.Copy(bytEncriptado, 0, keyArray, 0, keyArray.Length);
				Array.Copy(bytEncriptado, keyArray.Length, encrypted, 0, encrypted.Length);

				byte[] simKey = this._objRSA.Decrypt(keyArray, false);

				return MiRijndael.Desencriptar(encrypted, simKey);
			}
			else
			{
				return System.Text.Encoding.UTF8.GetString(this._objRSA.Decrypt(bytEncriptado, false));
			}
		}

	}
}