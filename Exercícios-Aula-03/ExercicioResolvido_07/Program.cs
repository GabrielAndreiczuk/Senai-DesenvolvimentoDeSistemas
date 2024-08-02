using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("CADASTRO DE PRODUTO");
        Console.Write("Informe o nome do produto: ");
        string nome = Console.ReadLine();
        Console.Write($"Informe o preço de {nome}: R$");
        double preco = double .Parse(Console.ReadLine());
        Console.Write($"Informe a quantidade de {nome}: ");
        int quantidade = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("PRODUTO CADASTRADO COM SUCESSO!");
        Console.WriteLine($"Produto: {nome}");
        Console.WriteLine($"Preço: {preco:C}");
        Console.WriteLine($"Quantidade: {quantidade}");

        Console.Write("\nPressione qualquer tecla para continuar. . .");
        Console.ReadKey();
    }
}