// 12. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
// impostos. Imprima o salário inicial, o salário com o aumento e o salário final.

Console.Clear();
Console.WriteLine("- = - = - = - = - = - = - = - = - = -");
Console.WriteLine(" Salário Cotação");
Console.WriteLine("- = - = - = - = - = - = - = - = - = -");
Console.WriteLine();

Console.Write("Informe o salário: ");
decimal salarioInicial = Convert.ToDecimal(Console.ReadLine());

decimal salarioAumento = salarioInicial + salarioInicial * 15 / 100;
decimal salarioFinal = salarioAumento - salarioAumento * 8 / 100;

Console.WriteLine();
Console.WriteLine($"Salário inicial: {salarioInicial:F2}");
Console.WriteLine($"Salário com aumento: {salarioAumento:F2}");
Console.WriteLine($"Salário final: {salarioFinal:F2}");