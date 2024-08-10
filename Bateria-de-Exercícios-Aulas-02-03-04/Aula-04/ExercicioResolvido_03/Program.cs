using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número inteiro positivo: ");
        int num = (int) double.Parse(Console.ReadLine());
        if (num < 0)
        {
            Console.WriteLine("Insira um número positivo!");
        }
        else
        {
            Program p = new Program();
            p.fatorial(num);
        }
    }
    public void fatorial(int num)
    { 
        int resultado = 1;
        for (int i = num; i > 1; i--)
        {
            Console.Write(i + " x ");
            resultado *= i;
        }
        Console.WriteLine("1 = "+ resultado);
    }
}
