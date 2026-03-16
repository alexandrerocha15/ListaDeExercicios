// 13. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.


Console.Clear();
Console.WriteLine("- = - = - = - = - = -");
Console.WriteLine(" Exercicio 11 ");
Console.WriteLine("- = - = - = - = - = -");
Console.WriteLine();

Console.WriteLine("Informe os valores A, B, C ");
Console.Write("Valor de A: ");
int valorA = Convert.ToInt32(Console.ReadLine());

Console.Write("Valor de B: ");
int valorB = Convert.ToInt32(Console.ReadLine());

Console.Write("Valor de C: ");
int valorC = Convert.ToInt32(Console.ReadLine());

int somaAB = valorA + valorB;

Console.WriteLine();
if (somaAB > valorC)
{
    Console.WriteLine($"A soma de A e B '{somaAB}' é maior que C '{valorC}'");
}
else
{
    Console.WriteLine($"A soma de A e B '{somaAB}' não é maior que C '{valorC}'");
}