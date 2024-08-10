using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(verificarPrimo(num) ? $"{num} é primo!": $"{num} não é primo");
    }
    static bool verificarPrimo(int num)
    {
        int divisores = 0;
        for (int i = num; i > 0; i--)
        {
            if (num % i == 0)
            {
                divisores++;
            }
        }
        if (divisores <= 2)
        {
            return true;
        } 
        else
        {
            return false;
        }
    }
}