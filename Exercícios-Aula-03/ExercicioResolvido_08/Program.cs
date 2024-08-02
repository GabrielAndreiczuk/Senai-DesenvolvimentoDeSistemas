using System;

class Program
{
    static void Main()
    {
        //DEFINIÇÃO DE CONSTANTE PARA CÂMBIO
        const double taxaCambio = 5.62;
        //ENTRADA DE DADOS
        Console.WriteLine("CONVERSÃO DE MOEDA");
        Console.Write("\nDigite um valor em reais: R$");
        double reais = double.Parse(Console.ReadLine());
        //CONVERSÃO DE VALORES
        double dolar = reais / taxaCambio;
        //SAÍDA DE DADOS
        Console.WriteLine($"{reais:C} equivalem à US$ {dolar:F2}");
        //FINALIZAÇÃO DO PROGRAMA
        Console.Write("\nPressione qualquer tecla para continuar. . .");
        Console.ReadKey();
    }
}