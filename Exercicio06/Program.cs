// 6. Crie um programa para calcular a média harmônica das notas de um Aluno

using System.Diagnostics.Contracts;

Console.WriteLine("-------------------------");
Console.WriteLine("Calcular nota Harmônica");
Console.WriteLine("-------------------------");
Console.WriteLine();

Console.WriteLine(" - = - - = - - = - - = - - = - ");
Console.Write("Informe a quantidade de notas: ");
int qtdNotas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


decimal[] notas = new decimal[qtdNotas];
int notasInseridas = 0;

Console.WriteLine("Digite as notas do Aluno(a) ou 'sair' para encerrar");
for(int contador = 0; contador < qtdNotas; contador++)
{
    Console.WriteLine("Digite o valor da nota ou 'sair' para encerrar: ");
    Console.Write($"Nota '{contador + 1}': ");
    string? notaParcial = Console.ReadLine();
    Console.WriteLine();
    if (notaParcial?.ToUpper() == "SAIR")
        break;
    decimal nota = Convert.ToDecimal(notaParcial);
    notas[contador] = nota;
    notasInseridas++;
}

decimal soma = 0;

for (int i = 0; i < notasInseridas; i++)
{
    soma += 1 / notas[i];
}

decimal mediaHarmonica = notasInseridas / soma;

Console.WriteLine($"A média harmônica: {mediaHarmonica:F2}");