
Console.WriteLine($"Digite o ano de seu nascimento: ");
int ano = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o ano atual: ");
int anoAtual = int.Parse(Console.ReadLine());



int resultado = anoAtual - ano;

if (resultado < 16)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"você não tem a idade mínima para votar!");
    Console.ResetColor();
}
else if (resultado >= 16 && resultado < 18)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Seu voto é opcional!");
    Console.ResetColor();
}

else if (resultado >= 18 && resultado < 70)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"você deve votar!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Seu voto é opcional!");
    Console.ResetColor();
}







