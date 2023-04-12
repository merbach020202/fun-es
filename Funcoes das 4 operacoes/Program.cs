//funções(Defina um codigo uma vez e use-o varias vezes)
// VOID = Nao possui valor de retorno
// MyMethod() = é o nome do método (Usar PascalCase)

// static void MyMethod()
// {
//bloco de codigo
// }



//criar um metodo para exibir o nome de uma pessoa, sobrenome e exibir "Bom dia Fulano de tal"

// static void Saudacao()
// {
//     Console.WriteLine($"Informe o nome da pessoa: ");
//     string nome = Console.ReadLine();

//     Console.WriteLine($"Informe o sobrenome da pessoa: ");
//     string sobrenome = Console.ReadLine();

//     Console.WriteLine($"Bom dia {nome} {sobrenome}!");
// }


// Saudacao();



//criar um metodo para somar 2 numeros
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Operação a ser efetuada: SOMA");
Console.ResetColor();

static float Somar(float n1, float n2)
{
    return (n1 + n2);
}

Console.WriteLine($"Informe o 1º numero: ");
float primeiroNumero = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o 2º numero: ");
float segundoNumero = float.Parse(Console.ReadLine());

Console.WriteLine($"A soma de {primeiroNumero} + {segundoNumero} é {Somar(primeiroNumero, segundoNumero)}");

//Somar(primeiroNumero, segudoNumero)



//Criar os metodos para as demais operacoes matematicas (subtracao, multiplicacao e divisao)
//Receber os numeros e exibir os resultados


//DIVISAO
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Operação a ser efetuada: Divisao");
Console.ResetColor();

static float Divisao(float n1, float n2)
{
    return (n1 / n2);
}

Console.WriteLine($"Informe o 1º numero:");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o 2º numero:");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"A divisao do {n1} e do {n2} = {Divisao(n1, n2)}");



//MULTIPLICACAO
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Operação a ser efetuada: MULTIPLICAÇÃO");
Console.ResetColor();

static float Multiplicacao(float n1, float n2)
{
    return (n1 * n2);
}

Console.WriteLine($"Informe o 1º numero:");
float numero1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o 2º numero:");
float numero2 = float.Parse(Console.ReadLine());

Console.WriteLine($"A multiplicacao do {numero1} e do {numero2} = {Multiplicacao(numero1, numero2)}");



//SUBTRACAO

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Operação a ser efetuada: SUBTRAÇÃO");
Console.ResetColor();

static float Subtracao(float n1, float n2)
{
    return (n1 - n2);
}

Console.WriteLine($"Informe o 1º numero:");
float Numero = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o 2º numero:");
float Numero2 = float.Parse(Console.ReadLine());

Console.WriteLine($"A subtração do {Numero} e do {Numero2} = {Subtracao(Numero, Numero2)}");



