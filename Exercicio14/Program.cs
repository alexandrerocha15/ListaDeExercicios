// 14. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em 
// ordem decrescente.

int[] numeros = new int[3];

Console.Clear();
Console.WriteLine("- = - = - = - = - = - = - = -");
Console.WriteLine("Insira 3 valores inteiros");
Console.Write("Valor 1: ");
numeros[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("Valor 2: ");
numeros[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("Valor 3: ");
numeros[2] = Convert.ToInt32(Console.ReadLine());

Array.Sort(numeros);
Array.Reverse(numeros);

Console.WriteLine();
Console.WriteLine("- = - = - = - = - = - = - = -");
Console.WriteLine("Novos Valores");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Valor {i + 1}: {numeros[i]}");
}