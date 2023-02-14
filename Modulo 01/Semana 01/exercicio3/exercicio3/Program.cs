List<int> pares = new List<int>();
List<int> impares = new List<int>();

int i;

for (i = 0; i < 10; i++)
{
    Console.Write("Digite o " + (i + 1) + "numero : ");
    int num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        pares.Add(num);
    }
    else
    {
        impares.Add(num);
    }
};

pares.Sort();
impares.Sort();

Console.WriteLine($"A lista de números ímpares possui {impares.Count()} números e a soma deles é igual a {impares.Sum()}");
Console.WriteLine($"A lista de números pares possui {pares.Count()} números e a soma deles é igual a {pares.Sum()}");



