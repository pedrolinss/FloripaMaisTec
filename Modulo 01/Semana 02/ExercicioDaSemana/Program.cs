using ExercicioDaSemana;

ContaBancaria contaBancaria = new ContaBancaria();

Console.WriteLine("Digite o valor do deposito :");
int deposito = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do saque :");
int saque = int.Parse(Console.ReadLine());


contaBancaria.Saldo(deposito, saque);