using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4 };
        double media = calcularMedia(numeros);
        string nums = string.Join(", ", numeros);
        Console.WriteLine($"A média de [{nums}] é igual a: " + media);
    }
    static double calcularMedia(int[] numeros)
    {
        int soma = 0;
        foreach (int i in numeros)
        {
            soma += i;
        }

        double media = (double) soma / numeros.Length;
        return media;
    }
}