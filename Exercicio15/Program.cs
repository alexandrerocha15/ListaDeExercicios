// 15. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para 
// dar uma indicação sobre a condição de peso de uma pessoa adulta. 
// A fórmula é IMC = peso / (altura)². Elabore um algoritmo que leia opeso e a altura de um 
// adulto e mostre sua condição de acordo com a listagem abaixo:
// IMC em adultos Condição
// Abaixo de 18,5
// Abaixo do peso
// Entre 18,5 e 25 Peso normal
// Entre 25 e 30
// Acima do peso
// Acima de 30 obeso

Console.Clear();

Console.WriteLine("- = - = - = - = - = - = - = -");
Console.WriteLine("Índice de Massa Corporal");
Console.WriteLine("- = - = - = - = - = - = - = -");
Console.WriteLine();
Console.WriteLine("Informe os dados usando ',' (Ex.: 1,75)");

Console.Write("Peso: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / Math.Pow(altura, 2);

string resultado = "";

if (imc < 18.5)
{
    resultado = "Abaixo do peso";
}
else if (imc < 25)
{
    resultado = "Peso normal";
}
else if (imc < 30)
{
    resultado = "Acima do peso";
}
else
{
    resultado = "Obeso";
}

Console.Clear();
Console.WriteLine("- = - = - = - = - = - = - = -");
Console.WriteLine("Índice de Massa Corporal");
Console.WriteLine("- = - = - = - = - = - = - = -");
Console.WriteLine();
Console.WriteLine("Resultados Finais");
Console.WriteLine();

Console.WriteLine($"Peso.....: {peso}");
Console.WriteLine($"Altura...: {altura}");
Console.WriteLine($"IMC......: {imc:F2}");
Console.WriteLine($"Conclusao: {resultado}");
Console.WriteLine();