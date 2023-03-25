try
{
    Console.WriteLine("Digite o primeiro número: ");
    decimal a = Decimal.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    decimal b = Decimal.Parse(Console.ReadLine());

    decimal resultado = a / b;

    Console.WriteLine(resultado);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Não é possível dividir por 0. Erro: {ex}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Erro detectado, digite somente números por gentileza. {ex}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro detectado. {ex}");
}
finally
{
    decimal a = 0;
    decimal b = 0;
}
