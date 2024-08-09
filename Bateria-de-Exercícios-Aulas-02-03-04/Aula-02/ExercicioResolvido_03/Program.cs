using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine(num + " é negativo!");
        }
        else if (num == 0)
        {
            Console.WriteLine(num + " é igual a zero!");
        }
        else
        {
            Console.WriteLine(num + " é positivo!");
        }
    }
}
