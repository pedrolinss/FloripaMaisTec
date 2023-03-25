using System;
namespace ExerciciosS04
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (Cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }


        public override void Sacar(decimal valor)
        {
            valor += 1.10M;
            base.Sacar(valor);
        }


        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor += 0.05M;
            base.Transferir(conta, valor);
        }
    }
}

