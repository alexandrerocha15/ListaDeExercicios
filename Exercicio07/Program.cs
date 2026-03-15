// 7. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
//  multiplique a nota de cada prova pelo seu respectivo peso, some os resultados e divida pela soma dos pesos (Nota1 × Peso1 + Nota2 × Peso2) / (Peso1 + Peso2)


Console.WriteLine(" - = - = - = - = - = - = - = - = - ");
Console.WriteLine("Calcular a Média Ponderada");
Console.WriteLine(" - = - = - = - = - = - = - = - = - ");
Console.WriteLine();
decimal notaConvertida;
decimal pesoConvertido;
decimal[] notas = new decimal[2];
decimal[] pesos = new decimal[2];   


for(int i = 0; i < 2; i++)
{
    bool checarNota = false;
    bool checarPeso = false;
    

    while (!checarNota)
    {
        Console.WriteLine($"Informe a nota e o peso da prova '{i + 1}'");
        Console.Write($"Nota: ");
        string? nota = Console.ReadLine();
        checarNota = decimal.TryParse(nota, out notaConvertida);

        if (checarNota)
        {
            notas[i] = notaConvertida;
        }

        else
        {
            Console.WriteLine("Digite um número válido.");
            Console.WriteLine();
        }
    }
    
    while (!checarPeso)
    {
        Console.Write("Peso: ");
        string? peso = Console.ReadLine();
        checarPeso = decimal.TryParse(peso, out pesoConvertido);

        if (checarPeso)
        {
            pesos[i] = pesoConvertido;
        }
        
        else
        {
            Console.WriteLine("Digite um número válido.");
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

// (Nota1 × Peso1 + Nota2 × Peso2) / (Peso1 + Peso2)

decimal somaNotas = 0;
somaNotas = (notas[0] * pesos[0] + notas[1] * pesos[1]) / (pesos[0] + pesos[1]);
Console.WriteLine();
Console.WriteLine(somaNotas);