Console.WriteLine($"Digite o número 1 para começar:  ");
int numeroDigitado = int.Parse(Console.ReadLine());

if (numeroDigitado == 1)
{

    for (int i = 1; i <= 10; i++)
    {
        numeroDigitado++;
        Console.WriteLine(@$"
        Tabuada do {i}:
        {i * 1}
        {i * 2}
        {i * 3}
        {i * 4}
        {i * 5}
        {i * 6}
        {i * 7}
        {i * 8}
        {i * 9}
        {i * 10}
        ");
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"O console será resetado, digite o número correto!");
    Console.ResetColor();
}


