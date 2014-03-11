using System;

namespace TransEncripHash
{
	/// <summary>
	/// Summary description for Transformacion.
	/// </summary>
	public class TransformacionXOR
	{
		private static int _XOR = 87;

		public static byte[] Codificar(byte[] bytACodificar)
		{
			for (int _intPos = 34; _intPos < bytACodificar.Length; _intPos++)
				bytACodificar[_intPos] = (byte) (_XOR ^ bytACodificar[_intPos]);
			return bytACodificar;
		}

		public static byte[] DeCodificar(byte[] bytADecodificar)
		{
			for (int _intPos = 34; _intPos < bytADecodificar.Length; _intPos++)
				bytADecodificar[_intPos] = (byte) (_XOR ^ bytADecodificar[_intPos]);
			return bytADecodificar;
		}

	}

	public class TransformacionDesp
	{
		private static int _CONSTANTE = 210;

		public static byte[] Codificar(byte[] bytACodificar)
		{
			for (int _intPos = 34; _intPos < bytACodificar.Length; _intPos++)
				bytACodificar[_intPos] = (byte) ((_CONSTANTE +bytACodificar[_intPos]) % 255);
			return bytACodificar;
		}

		public static byte[] DeCodificar(byte[] bytADecodificar)
		{
			for (int _intPos = 34; _intPos < bytADecodificar.Length; _intPos++)
				bytADecodificar[_intPos] = (byte) ((_CONSTANTE - bytADecodificar[_intPos]) % 255);
			return bytADecodificar;
		}


	}

}