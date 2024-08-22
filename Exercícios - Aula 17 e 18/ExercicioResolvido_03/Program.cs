using System;

class Program
{
    static void Main()
    {
        Dictionary<int, string> dicionario = new Dictionary<int, string>()
        {
            { 1,"Athletico"},
            { 2, "Coritiba" },
            { 3, "Paraná" },
            { 4, "Operário" },
            { 5, "Londrina" },
            { 6, "Cianorte" }
        };

        var times = from time in dicionario
                    where time.Value.Contains("e")
                    orderby time.Key
                    select time;
        foreach ( var time in times)
        {
            Console.WriteLine($"Chave: {time.Key} Valor: {time.Value}");
        }
    }
}