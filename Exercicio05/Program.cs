// 5. Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
//    vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.

using System.Diagnostics.Contracts;

Console.Write("Informe o salário base: ");
decimal salario = Convert.ToDecimal(Console.ReadLine());

Console.Write("Informe o total de vendas: ");
decimal vendas = Convert.ToDecimal(Console.ReadLine());

Console.Write("Informe o percentual da comissão: ");
decimal porcentagem = Convert.ToDecimal(Console.ReadLine());

decimal comissao = vendas * porcentagem / 100;

decimal salarioTotal = salario + comissao;

Console.WriteLine();
Console.WriteLine($"O salário total é de: {salarioTotal}");