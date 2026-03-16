// 18. Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

Console.Clear();
Console.WriteLine();
Console.WriteLine("- = - = - = - = - - = - = - = - = - ");
Console.WriteLine("Números ímpares entre 100 a 200");
Console.WriteLine("- = - = - = - = - - = - = - = - = - ");

for (int i = 100; i < 200; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}