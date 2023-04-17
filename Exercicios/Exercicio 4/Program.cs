float[] numeros = new float[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite um número: ");
    numeros[i] = float.Parse(Console.ReadLine());
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@$"
O maior numero digitado foi o:
{numeros.Max()}");
Console.ResetColor();


















