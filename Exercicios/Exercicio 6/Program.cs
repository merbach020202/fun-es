string[] nomes = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite um nome: ");
    nomes[i] = Console.ReadLine();
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@$"
Digite o nome da pessoa que voçê quer achar!
");
Console.ResetColor();

Console.WriteLine($"Digite um nome: ");
string digitado = Console.ReadLine();

foreach (var nomeDigitado in nomes)
{
    if (nomeDigitado == digitado)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@$"
        Achei {nomeDigitado}
        ");
        Console.ResetColor();
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@$"
        Não achei
        ");
        Console.ResetColor();
        break;
    }
}

// CODIGO DO PROFESSOR

// string[] nomes = new string[3];

// bool encontrado = false;

// for (var i = 0; i < nomes.Length; i++)
// {
//     Console.WriteLine($"Informe o {i + 1}º nome: ");
//     nomes[i] = Console.ReadLine();    
// }

// Console.WriteLine($"Informe um nome a ser buscado: ");
// string nomeBuscado = Console.ReadLine();

// //processamento
// foreach (string nome in nomes)
// {
//    if (nome == nomeBuscado)
//    {
//         encontrado = true;
//         break;
//    } 
// }

// //saída
// if (encontrado == true)
// {
//     Console.WriteLine($"ACHEIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII!!!!!!!!!!!!!");    
// }
// else
// {
//     Console.WriteLine($"NÃO  ACHEIIIIIIIIIIIIIIIIIIIIIIIII!");    
// }

// string resultadoPesquisa = encontrado == true ? "ACHEI" : "NÃO ACHEI";
// Console.WriteLine(resultadoPesquisa);

// Console.WriteLine(encontrado == true ? "ACHEI" : "NÃO ACHEI");
