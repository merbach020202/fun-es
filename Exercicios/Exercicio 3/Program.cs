Console.WriteLine($"Digite o nome do produto: ");
string nomeProduto = Console.ReadLine();

Console.WriteLine($"Digite a quantidade a ser adquirida do produto: ");
int quantidadeProduto = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o preco por unidade do produto: ");
float precoProduto = float.Parse(Console.ReadLine());



static float precoFinal(float a, float precoProduto)  //a = quantidade do produto
{
    if (a <= 5)
    {
        return (float)((a * precoProduto) * 0.02);
    }
    else if (a > 5 && a <= 10)
    {
        return (float)((a * precoProduto) * 0.03);
    }
    else
    {
        return (float)((a * precoProduto) * 0.05);
    }
}


float desconto = precoFinal(quantidadeProduto, precoProduto);

float precoSemDesconto = quantidadeProduto * precoProduto;
float precoComDesconto = precoSemDesconto - desconto;






Console.WriteLine(@$"
Nome do produto escolhido: {nomeProduto}
Valor total: {precoSemDesconto} 
Valor do desconto: {desconto}
Valor com o desconto aplicado: {precoComDesconto}
");

// static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
// {
    
//     Console.Write(texto);

//     for (int i = 0; i < quantidadePontinhos; i++)
//     {
//         Console.Write($".");
//         Thread.Sleep(tempo);
//     }
    

// }


// Console.ForegroundColor = ConsoleColor.Black;
// BarraCarregamento("Testando",10,500);













