﻿using Exercicio1;

Produto produto1 = new Produto("Calculadora", 5.75, 199);

Produto produto2 = new Produto();

Console.WriteLine($"O produto 1 tem nome : {produto1.nome},valor :{produto1.preco},quantidade :{produto1.quantidade}");

Console.WriteLine($"O produto 2 tem nome : {produto2.nome},valor :{produto2.preco},quantidade :{produto2.quantidade}");