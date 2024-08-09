using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.Write(numero + " é par!");
        }
        else
        {
            Console.Write(numero + " é ímpar!");
        }
    }
}
