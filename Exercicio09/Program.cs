// 9. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
// terreno e depois exibir a área do terreno.
// área = base × altura

Console.WriteLine(" - = - - = - - = - - = - - = - ");
Console.WriteLine(" Imobiliária Imóbilis ");
Console.WriteLine(" - = - - = - - = - - = - - = - ");
Console.WriteLine();


Console.WriteLine(" - - - - - - - - - - - - - - - - - - ");
//Console.WriteLine(" - - - - - - - - - - - - - - - - - - ");
Console.WriteLine("Informe as dimensões do terreno");
Console.Write("Base: ");
decimal baseInformada = Convert.ToDecimal(Console.ReadLine());

Console.Write("Altura: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

decimal area = baseInformada * altura;

Console.WriteLine();
Console.WriteLine($"O terreno informado tem cerca de {area:F2}m²");