using System;

// DEFINE A INTERFACE. A INTERFACE DEFINE OS MÉTODOS QUE UMA CLASSE DEVE IMPLEMENTAR
public interface IVeiculo
{
    void Ligar();
    void Desligar();
}

// CRIAÇÃO DA CLASSE CARRO, COM METODOS DEFINIDOS PELA INTERFACE VEÍCULO
public class Carro : IVeiculo
{
    public void Ligar()
    {
        Console.WriteLine("O carro foi ligado.");
    }

    public void Desligar()
    {
        Console.WriteLine("O carro foi desligado.");
    }
}

// CRIAÇÃO DA CLASSE MOTO, COM METODOS DEFINIDOS PELA INTERFACE VEÍCULO
public class Moto : IVeiculo
{
    public void Ligar()
    {
        Console.WriteLine("A moto foi ligada.");
    }

    public void Desligar()
    {
        Console.WriteLine("A moto foi desligada.");
    }
}

public class Program
{
    public static void Main()
    {
        IVeiculo meuCarro = new Carro();
        IVeiculo minhaMoto = new Moto();

        meuCarro.Ligar();
        meuCarro.Desligar();
        Console.WriteLine();

        minhaMoto.Ligar();
        minhaMoto.Desligar();
    }
}