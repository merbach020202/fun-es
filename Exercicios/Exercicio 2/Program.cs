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

static float CombustivelG(float a)
{
    if (a <= 20)
    {
        return (float)(((5.30 / 100) * 4) * a);
    }
    else
    {
        return (float)(((5.30 / 100) * 6) * a);
    }
}


Console.WriteLine(@$"Digite o tipo de combustivel que você deseja escolher:
g - gasolina
a - alcool
");
char tipoCombustivel = char.Parse(Console.ReadLine().ToLower());


Console.WriteLine($"Digite a quantidade de litros vendidos: ");
int quantidadeLitros = int.Parse(Console.ReadLine());

if (tipoCombustivel == 'g')
{
    float valorFinal = CombustivelG(quantidadeLitros);

    Console.WriteLine($"O valor a ser pago é de: {valorFinal}");

}





else if (tipoCombustivel == 'a')
{
    Console.WriteLine($"Digite a quantidade de litros vendidos: ");
    float precoA = float.Parse(Console.ReadLine());
}





else
{
    Console.WriteLine($"Digite novamemte o tipo de combustivel desejado!");
}





















