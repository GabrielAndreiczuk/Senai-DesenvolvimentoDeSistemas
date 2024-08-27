using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int num = (int) double.Parse(Console.ReadLine());
        
        if(num % 2  == 0)
        {
            Console.WriteLine($"{num} é par!");
        }
        else
        {
            Console.WriteLine($"{num} é impar!");
        }
        Console.Write("\n\nPressione qualquer tecla para continuar. . .");
        Console.ReadKey();
    }
}