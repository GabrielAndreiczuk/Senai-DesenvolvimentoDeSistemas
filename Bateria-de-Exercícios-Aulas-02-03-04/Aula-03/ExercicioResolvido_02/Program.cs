using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o primeiro número: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"A soma de {num} + {num2} é igual a {num + num2}");
    }
}