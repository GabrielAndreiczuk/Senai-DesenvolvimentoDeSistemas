using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        
        for(int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Informe um número inteiro: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nArray invertido: ");
        for(int i = numeros.Length -1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}