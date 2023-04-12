//Console.WriteLine($"Carregando...............");

static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
{
    
    Console.Write(texto);

    for (int i = 0; i < quantidadePontinhos; i++)
    {
        Console.Write($".");
        Thread.Sleep(tempo);
    }
    

}

Console.ForegroundColor = ConsoleColor.Black;
BarraCarregamento("Testando",10,500);

Console.ForegroundColor = ConsoleColor.Blue;
BarraCarregamento("Finalizando",10,400);

Console.ForegroundColor = ConsoleColor.DarkCyan;
BarraCarregamento("Aguarde",15,300);

Console.ForegroundColor = ConsoleColor.DarkYellow;
BarraCarregamento("Cadastrando",15,200);

Console.ForegroundColor = ConsoleColor.Green;
BarraCarregamento("Logando",20,100);
Console.ResetColor();








