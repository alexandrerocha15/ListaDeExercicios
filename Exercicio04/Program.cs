// 4. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

Console.Write("Digite a escala Celsius (ºC): ");
decimal celsius = Convert.ToDecimal(Console.ReadLine());

decimal resultado = celsius * 9 / 5 + 32;

Console.Write($"{celsius}°C equivalem a {resultado}°F");