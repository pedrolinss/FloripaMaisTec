﻿List<string> frutas = new List<string>();
bool continuar = true;

while(continuar)
{
    if (frutas.Count() == 15)
    {
        continuar = false;
        break;
    }

    Console.WriteLine("Digite uma fruta: ");
    frutas.Add(Console.ReadLine());
    Console.Write("Você deseja continuar: ");
    string resposta = Console.ReadLine();

    if(resposta == "nao" || resposta == "n")
    {
        continuar = false;
    }
}

frutas.Sort();
foreach (string fruta in frutas) 
{
    Console.WriteLine(fruta);
}





