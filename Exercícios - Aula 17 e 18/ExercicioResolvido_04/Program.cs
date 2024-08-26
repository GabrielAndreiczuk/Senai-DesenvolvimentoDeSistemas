using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var produtos = new List<Produto>
        {
            new Produto{Nome = "Notebook", Categoria = "Eletrônicos"},
            new Produto{Nome = "Televisão", Categoria = "Eletrônicos"},
            new Produto{Nome = "Mesa", Categoria = "Móveis"},
            new Produto{Nome = "Cadeira", Categoria = "Móveis"},
            new Produto{Nome = "Cortina", Categoria = "Decoração"},
            new Produto{Nome = "Abajur", Categoria = "Decoração"},
            new Produto{Nome = "Armário", Categoria = "Móveis"}
        };

        var resultado = from item in produtos 
                        group item by item.Categoria into grupo
                        select new
                        {
                            Categoria = grupo.Key,
                            Quantidade = grupo.Count()
                        };

        foreach (var item in resultado)
        {
            Console.WriteLine($"Categoria: {item.Categoria}, Quantidade: {item.Quantidade}");
        }

    }
}

class Produto
{
    public string Nome { get; set; }
    public string Categoria { get; set; }
}