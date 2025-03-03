using System;


	public static class IntExtensions
	{
		public static bool EhPar(this int numero)	// this extende o int ao número, sem precisar passar parâmetro quando chamado
		{
			return numero % 2 == 0;
		}
	}

