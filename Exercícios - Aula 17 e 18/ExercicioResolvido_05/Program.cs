using System;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>() { 5, 12, 7, 21, 9, 15, 4 };

        var resultado = from num in numeros
                        where num > 10
                        select num * 2;
        foreach (int num in resultado)
        {
            Console.WriteLine(num);
        }
    }
}