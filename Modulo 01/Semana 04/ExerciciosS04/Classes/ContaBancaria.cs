﻿using System;
namespace ExerciciosS04
{
    public class ContaBancaria
    {
        public int Numero { get; protected set; }

        public int Agencia { get; protected set; }

        public Cliente Cliente { get; protected set; }

        public decimal Saldo { get; protected set; } = 0;


        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            Saldo = 0;
            Cliente = cliente;
        }

        public virtual void Transferir(ContaBancaria conta, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser superior a 0");
                return;
            }

            if (valor > Saldo)
            {
                Console.WriteLine("Saldo não suficiente");
                return;
            }

            Saldo = Saldo - valor;

            conta.Depositar(valor);

            Console.WriteLine($"Valor de R$ {valor} transferido com sucesso!");

        }

        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;
            }
            else
            {
                Saldo = Saldo + valor;
            }
        }


        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;

            }
            else if (valor > Saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");
                return;
            }
            else
            {
                Saldo = Saldo - valor;
            }
        }


        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {Saldo}");
        }
    }
}

