// 8. Crie um programa para verificar se um número é primo.

Console.Write("Insira um número para verificar se é primo: ");
int numero = Convert.ToInt32(Console.ReadLine());
bool primo = true;

for (int i = 2; i < numero; i++)
{
    if (numero % i == 0)
    {
        primo = false;
        break;
    }
}

if (primo)
{
    Console.WriteLine($"O número {numero} é primo");
}
else
{
    Console.WriteLine($"O número {numero} não é primo");
}