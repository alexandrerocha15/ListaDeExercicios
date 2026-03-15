// 11. Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
// Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias
// de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.

Console.Clear();
Console.WriteLine("Descubra quantos dias de vida você tem");
Console.WriteLine();

Console.Write("Informe um nome: ");
string? nome = Console.ReadLine();

Console.WriteLine($"Olá {nome}!");
Console.Write("Informe sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

int anos = 365;
int diasVida = anos * idade;

Console.WriteLine($"{nome}, você possue {diasVida} dias de vida !!");