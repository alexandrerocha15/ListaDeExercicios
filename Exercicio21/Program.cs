// 21. Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
// resultado.
// a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
// b. Pesquise sobre “fatorial”


Console.Clear();
Console.WriteLine("- = - = - = - = -");
Console.WriteLine("Exercicio 21 ");
Console.WriteLine("- = - = - = - = -");
Console.WriteLine();
int numero, fatorial = 1;
Console.WriteLine("Calculando Fatorial");
Console.Write("Digite um valor: ");
numero = Convert.ToInt32(Console.ReadLine());

Console.Write(numero + "! = ");

for (int i = numero; i >= 1; i--)
{
    Console.Write(i + " ");
    fatorial *= i;

    if (i > 1)
    {
        Console.Write("X ");
    }
}
Console.Write("= " + fatorial);