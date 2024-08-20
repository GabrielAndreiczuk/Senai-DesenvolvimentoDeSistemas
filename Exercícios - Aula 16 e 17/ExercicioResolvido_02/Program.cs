using System;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();
        for(int i = 0; i < 5; i++) 
        {
            Console.Write("Insira um nome: ");
            nomes.Add(Console.ReadLine());
        }
        Console.WriteLine("\nNomes na lista: ");
        
        foreach(string nome in nomes)
        {
            Console.WriteLine(nome);
        }
        
        /*
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(nomes[i]);
        }
        */
    }
}