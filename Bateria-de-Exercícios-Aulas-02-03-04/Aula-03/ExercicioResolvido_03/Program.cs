using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o seu ano de nascimento: ");
        int anoNasc = int.Parse(Console.ReadLine());
        int anoAtual = DateTime.Now.Year;

        Console.WriteLine($"Você nasceu em {anoNasc} e tem {anoAtual - anoNasc} anos");
    }
}
