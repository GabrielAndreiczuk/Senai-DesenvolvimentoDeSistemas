using System;

class Program
{
    static void Main()
    {
        Dictionary<int, string> dicionario = new Dictionary<int, string>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Informe uma palavra: ");
            dicionario.Add(i+1, Console.ReadLine());
        }
        Console.WriteLine("\nPares com chaves e valores: ");
        foreach(KeyValuePair<int, string> par in dicionario)
        {
            Console.WriteLine($"Chave: {par.Key} Valor: {par.Value}");
        }
    }
}