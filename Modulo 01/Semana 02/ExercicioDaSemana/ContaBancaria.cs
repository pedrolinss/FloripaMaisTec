using System;
namespace ExercicioDaSemana
{
    public class ContaBancaria
    {
        // Resposta exercício 03
        public int numero;
        public int agencia;
        public string nomeDoTitular;
        public decimal saldo = 0;
        public TipoContaEnum TipoConta;

        // resposta exercicio 04
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior que 0");
            } else
            {
                saldo += valor;
            }
        }

        // resposta exercicio 05
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior que 0");

            } else if (valor > saldo)
            {
                Console.WriteLine("O valor é maior que o saldo atual!");

            } else
            {
                saldo -= ßvalor;
            }
        }

        // resposta exercicio 06
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é {saldo}");
        }
    }
}