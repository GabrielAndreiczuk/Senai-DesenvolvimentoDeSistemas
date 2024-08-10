using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());
        soma(num1, num2);
    }
    static void soma(int a, int b)
    {
        int resultado = a + b;
        Console.WriteLine($"A soma de {a} e {b} é {resultado}");
    }
}