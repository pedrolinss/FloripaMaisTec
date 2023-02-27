//  [M01S03] - Cópia do exercício da semana passada

using ExercicioDaSemana;

ContaBancaria conta1 = new ContaBancaria(3222, 5026, "Marcos", TipoContaEnum.POUPANCA);
ContaBancaria conta2 = new ContaBancaria("João", TipoContaEnum.POUPANCA);


conta1.Transferir(conta2, 333);

conta1.ExibirSaldo();

conta2.ExibirSaldo();