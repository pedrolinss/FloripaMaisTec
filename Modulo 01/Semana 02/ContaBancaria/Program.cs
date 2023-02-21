using Conta;

ContaBancaria contaBancaria = new ContaBancaria();

Console.WriteLine("Depositar :");
contaBancaria.deposito = int.Parse(Console.ReadLine());

Console.WriteLine("Sacar :");
contaBancaria.saque = int.Parse(Console.ReadLine());

contaBancaria.Saldo();





