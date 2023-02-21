using System;
namespace Conta
{
	public class ContaBancaria
	{
		public int saque;
		public int deposito;

		public void Saldo()
		{
			Console.WriteLine($"Seu saldo atual é : {deposito - saque}");
		}
	}
};

