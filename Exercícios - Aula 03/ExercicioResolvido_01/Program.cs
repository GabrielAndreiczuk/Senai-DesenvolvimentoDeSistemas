using System;

 class Program()
{
    static void Main()
    {
        Console.Write("Prezado usuário(a), digite seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Informe sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nObrigado {nome}, você tem {idade} anos!\n");

        Console.Write("Pressione qualquer tecla para continuar. . .");
        Console.ReadKey();
    }
}