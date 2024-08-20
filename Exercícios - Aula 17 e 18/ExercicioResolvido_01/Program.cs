using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //MEU CÓDIGO SEGUINDO OS SLIDES
        int[] numeros = { 5, 2, 6 , 1, 3 , 4 };
        var pares = from numero in numeros 
                    where numero % 2 == 0 
                    orderby numero
                    select numero ;
        Console.WriteLine("Números pares em ordem crescente:");
        foreach (int numero in pares)
        {
            Console.WriteLine(numero);
        }
        
        //CÓDIGO QUE O CHAT GPT SUGERIU
        var numerosParesOrdenados = numeros
                                    .Where(n => n % 2 == 0)   // Filtra os números pares
                                    .OrderBy(n => n);         // Ordena os números pares em ordem crescente

        // Imprimindo os números pares ordenados
        Console.WriteLine("\nNúmeros pares em ordem crescente:");
        foreach (var numero in numerosParesOrdenados)
        {
            Console.WriteLine(numero);
        }

    }
    

}