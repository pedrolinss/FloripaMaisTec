using System;
namespace ExercicioDaSemana
{
    public class ContaBancaria
    {
        public int numero;
        public string agencia;
        public string nomeDoTitular;
        public int saldo = 0;
        public enum TipoDeConta
        {
            Corrente,
            Poupança
        };


        public void Saldo(int deposito, int saque)
        {
            Console.WriteLine($"Seu saldo atual é : {deposito - saque}");
        }
    }
};

