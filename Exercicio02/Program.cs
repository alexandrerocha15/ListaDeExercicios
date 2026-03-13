// 2. Crie um programa para calcular o volume de um Cilindro
// V = π . r² . h

Console.Write("Digite o raio do cilindro: ");
decimal raio = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a altura do cilindro: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

decimal areaBase = 3.14m * raio * raio;

decimal volume = areaBase * altura;

Console.WriteLine($"O volume do cilindro é: {volume.ToString("F2")} cm³");
