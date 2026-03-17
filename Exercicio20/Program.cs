// 20. Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule 
// a tabuada de N. Mostre a
// tabuada na forma:
// ● 0 x N = 0,
// ● 1 x N = 1N,
// ● 2 x N = 2N,
// .
// .
// .
// ● 10 x N = 10N.

Console.Clear();
Console.WriteLine("- = - = - = - = -");
Console.WriteLine("Exercicio 20 ");
Console.WriteLine("- = - = - = - = -");
Console.WriteLine();
Console.Write("Informe um número para ver a tabuada: ");
int nInformado = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i < 2; i++)
{
    int e = 1;
    for(int numeroADividir = 1; e <= 10; e++)
    {
        int multiplicacao = nInformado * numeroADividir;
        Console.WriteLine($"{nInformado} x {numeroADividir} = {multiplicacao}");
        numeroADividir++;
    }
}














