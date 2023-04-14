//Um posto está vendendo combustíveis com a seguinte tabela de descontos:
//Álcool:
//. até 20 litros, desconto de 3% por litro Álcool
//. acima de 20 litros, desconto de 5% por litro
//Gasolina:
//. até 20 litros, desconto de 4% por litro Gasolina
//. acima de 20 litros, desconto de 6% por litro

//Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
//da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
//sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
//Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

static float CombustivelG(float quantidade)
{
    if (quantidade <= 20)
    {
        return (float)((quantidade * 5.30) / 100)*3;
    }
    else
    {
        return (float)((quantidade * 5.30) / 100)*5;
    }
}


static float CombustivelA(float b)
{
    if (b <= 20)
    {
        return (float)((b * 4.90) / 100)*4;
    }
    else
    {
        return (float)((b * 4.90) / 100)*6;
    }
}

Console.WriteLine($"Bem-vindo ao posto de combustível!");


Console.WriteLine(@$"Digite o tipo de combustivel que você deseja escolher:
g - gasolina
a - alcool
");
char tipoCombustivel = char.Parse(Console.ReadLine().ToLower());


Console.WriteLine($"Digite a quantidade de litros vendidos: ");
int quantidade = int.Parse(Console.ReadLine());

if (tipoCombustivel == 'g')
{
    float valorDesconto = CombustivelG(quantidade);
    float valorFinal = (quantidade * 5.30F) - valorDesconto;

    Console.WriteLine($"O valor a ser pago é de: {valorFinal}");
}

else if (tipoCombustivel == 'a')
{
    float valorDesconto = CombustivelA(quantidade);
    float valorFinal = (quantidade * 4.90F) - valorDesconto;

    Console.WriteLine($"O valor a ser pago é de: {valorFinal}");

}

else
{
    Console.WriteLine($"Digite novamemte o tipo de combustivel desejado!");
}





















