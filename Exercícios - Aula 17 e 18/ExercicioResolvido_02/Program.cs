using System;

class Program
{
    static void Main()
    {
        List<string> lista = new List<string>()
        {
            "Aurora",
            "Maria",
            "João",
            "Pedro",
            "Amanda",
            "Ana"
        };
        var nomes = from nome in lista
                    where nome.StartsWith('A')
                    orderby nome
                    select nome;
        Console.WriteLine("Nomes que iniciam com a letra A");
        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }

    }
}