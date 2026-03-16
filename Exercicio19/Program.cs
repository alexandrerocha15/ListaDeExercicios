// 19. Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são 
// múltiplos de três e que se encontram no conjunto dos números de 1 até 500.

Console.Clear();
Console.WriteLine("- = - = - = - = -");
Console.WriteLine("Exercicio 19 ");
Console.WriteLine("- = - = - = - = -");
Console.WriteLine("Multiplos de 3 ímapres");
Console.WriteLine();
int somaMultiplos = 0; 
for (int i = 1; i < 500; i++)
{
    if (i % 3 == 0)
    {
        if (i % 2 != 0)
        {
            Console.Write($" {i} /");
            somaMultiplos += i;
        }
    }
}
Console.WriteLine();
Console.WriteLine($"A soma dos multiplos de 3 é: {somaMultiplos}");