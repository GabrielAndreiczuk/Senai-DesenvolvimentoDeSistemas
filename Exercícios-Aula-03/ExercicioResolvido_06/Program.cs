using System;

class Program
{
    static void Main()
    {
        Console.Write("Entre com a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.Write("Entre com a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());
        Console.Write("Entre com a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"\nSua média final é de: {media:F1}");

        Console.Write("\nPressione qualquer tecla para continuar. . .");
        Console.ReadKey();
    }
}