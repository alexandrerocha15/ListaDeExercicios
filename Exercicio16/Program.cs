// 16. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.


Console.Clear();
Console.WriteLine("- = - = - = - = - = - = - = -");
Console.WriteLine("Informar se é par ou impar");
Console.WriteLine();

Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
if (numero % 2 == 0)
{
    Console.WriteLine($"Número '{numero}' é par");
}
else
{
    Console.WriteLine($"Número '{numero}' é impar");
}