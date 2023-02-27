//  [M01S03] - Cópia do exercício da semana passada

using System;
namespace ExercicioDaSemana
{
    public class ContaBancaria
    {
        private int _numero;
        private int _agencia;
        private string _nomeDoTitular;
        private decimal _saldo = 0;
        private TipoContaEnum _tipoConta;


        public ContaBancaria(int numero, int agencia, string nomeDoTitular, TipoContaEnum tipoConta)
        {
            _numero = numero;
            _agencia = agencia;
            _nomeDoTitular = nomeDoTitular;
            _tipoConta = tipoConta;
        }


        //   Resposta do exercício 05         ////
        public ContaBancaria(string _nomeDoTitular, TipoContaEnum tipoConta)
        {
            Random random = new Random();
            _numero = random.Next(0000, 9999);
            _agencia = random.Next(0000, 9999);

            _nomeDoTitular = _nomeDoTitular;
            _tipoConta = tipoConta;
        }


    
        //  Resposta do exercício 06
        public void Transferir(ContaBancaria conta, decimal valor)
        { 
            if(valor <= 0)
            {
                Console.WriteLine("O valor precisa ser superior a 0");
                return;
            }

            if(valor > _saldo)
            {
                Console.WriteLine("Saldo não suficiente");
                return;
            }

            _saldo = _saldo - valor;

            conta.Depositar(valor);

            Console.WriteLine($"Valor de R$ {valor} transferido com sucesso!");

        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;
            }
            else
            {
                _saldo = _saldo + valor;
            }
        }


        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;

            }
            else if (valor > _saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");
                return;
            }
            else
            {
                _saldo = _saldo - valor;
            }
        }


        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {_saldo}");
        }
    }
}
    





