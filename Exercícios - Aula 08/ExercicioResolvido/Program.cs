using System;

class Carro
{
    private string marca;
    private int ano;

    public Carro(string marca, int ano)
    {
        this.marca = marca;
        this.ano = ano;
    }
    public Carro(Carro outroCarrro)
    {
        this.marca = outroCarrro.marca;
        this.ano = outroCarrro.ano;
    }
    public void exibirInformacoes()
    {
        Console.WriteLine($"Marca: {marca} | Ano: {ano}");
    }
    ~Carro()
    {
        Console.WriteLine($"O objeto Carro com marca {marca} e ano {ano} está sendo destruído.");
    }
}

class Program
{
    static void Main()
    {
        Carro carroOriginal = new Carro("Agile", 2011);
        Carro carroCopia = new Carro(carroOriginal);

        Console.WriteLine("Informações carro original");
        carroOriginal.exibirInformacoes();
        Console.WriteLine("\n---------------------------\n\nInformações carro cópia");
        carroCopia.exibirInformacoes();

        // Força a coleta de lixo para demonstrar o destruidor
        carroOriginal = null;
        carroCopia = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}