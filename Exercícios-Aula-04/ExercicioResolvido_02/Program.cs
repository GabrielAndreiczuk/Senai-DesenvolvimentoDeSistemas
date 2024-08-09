using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"O número {num} " + (verificar(num) ? "é primo" : "não é primo"));
    }
    static bool verificar(int num)
    {
        int divisores = 0;

        for(int i = num; i > 0; i--)
        {
            if(num % i  == 0)
            {
                divisores++;
            }
        }
        if(divisores > 2)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}