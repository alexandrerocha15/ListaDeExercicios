// 10. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
// pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda
// dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado). Você foi
// contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as quantidades
// de pães e de broas, e depois calcular os dados solicitados.

Console.Clear();
Console.WriteLine("- = - - = - - = - - = - - = - ");
Console.WriteLine(" Panificadora Hotpão");
Console.WriteLine("- = - - = - - = - - = - - = - ");
Console.WriteLine();

decimal paes = 0.12m;
decimal broa = 1.50m;

Console.Write("Informe a quantidade de pães vendidos: ");
decimal paesVendidos = Convert.ToDecimal(Console.ReadLine());

Console.Write("Informe a quantidade de broas vendidas: ");
decimal broasVendidas = Convert.ToDecimal(Console.ReadLine());

decimal somaVendas = (paesVendidos * paes) + (broasVendidas * broa);
decimal poupanca = somaVendas * 10 / 100;


Console. Clear();
Console.WriteLine("- = - - = - - = - - = - - = - ");
Console.WriteLine(" Panificadora Hotpão");
Console.WriteLine("- = - - = - - = - - = - - = - ");
Console.WriteLine();
Console.WriteLine("Resumo do dia");
Console.WriteLine($"Total de vendas: {paesVendidos} pães e {broasVendidas} broas vendidas");
Console.WriteLine($"Valor bruto arrecadado: R$ {somaVendas}");
Console.WriteLine($"Total a ser investido na poupança (10%): R$ {poupanca:F2}");
Console.WriteLine();