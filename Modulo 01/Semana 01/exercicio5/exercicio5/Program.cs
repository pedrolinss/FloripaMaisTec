// Fibonacci

List<int> fibo = new List<int>();

int x = 1, y = 0, z = 0;

Console.Write("Quantos números você quer?: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    z = x + y;
    Console.WriteLine(z);
    y = x;
    x = z;
}



