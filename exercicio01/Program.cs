// 1. Crie um programa para calcular o volume de uma caixa retangular
// multiplique o comprimento x largura x altura (ou profundidade)

Console.Write("Digite o comprimento da caixa: ");
decimal comprimento = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o largura da caixa: ");
decimal largura = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o altura da caixa: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

decimal volume = comprimento * largura * altura;

Console.WriteLine($"O volume da caixa é de: {volume} cm³");
