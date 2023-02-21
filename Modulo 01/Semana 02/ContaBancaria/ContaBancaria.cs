using System;
namespace ContaBancaria
{
	public class Conta
	{
		public int saque;
		public int deposito;

		public void Saldo()
		{
			Console.WriteLine($"Seu saldo atual é : {deposito - saque}");
		}
	}
};

