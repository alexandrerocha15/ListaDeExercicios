// 22. Escreva um programa que leia um número e imprima a sequência de Fibonacci até
// esse número.

Console.Clear();
Console.WriteLine("- = - = - = - = -");
Console.WriteLine("Exercicio 22 ");
Console.WriteLine("- = - = - = - = -");
Console.WriteLine();
Console.WriteLine("Sequencia de Fibonacci");

Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());
int valor1 = 0, valor2 = 1;

Console.Write(valor1 + " " + valor2 + " ");

while (valor2 < numero)
{
    int valor3 = valor1 + valor2;

    Console.Write(valor3 + " ");
    valor1 = valor2;
    valor2 = valor3;
}
Console.WriteLine();