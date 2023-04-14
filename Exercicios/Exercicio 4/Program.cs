float[] numeros = new float[10];

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"Digite um número: ");
    numeros[i] = float.Parse(Console.ReadLine());
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@$"
O maior numero digitado foi o:
{numeros.Max()}");
Console.ResetColor();


















