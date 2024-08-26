using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        //ENTRADA DE DADOS
        Console.Write("INFORME O SALÁRIO BASE DO VENDEDOR: R$");
        double salarioBase = double.Parse(Console.ReadLine());
        Console.Write("INFORME O TOTAL DE VENDAS DO VENDEDOR: R$");
        int totalVendas = int.Parse(Console.ReadLine());
        Console.Write("INFORME A PORCENTAGEM DE COMISSÃO (EM %): ");
        double percentualComissao = double.Parse(Console.ReadLine());

        //CÁLCULO DA COMISSÃO
        double comissao = (percentualComissao / 100) * totalVendas;
        //CÁLCULO SALÁRIO TOTAL
        double salarioTotal = salarioBase + comissao;

        //SAÍDA DE DADOS
        Console.Clear();
        Console.WriteLine($"SALÁRIO BASE: {salarioBase:C}");
        Console.WriteLine($"COMISSÃO: {comissao:C}");
        Console.WriteLine($"SALÁRIO TOTAL: {salarioTotal}");

        Console.Write("\n\nPressione qualquer tecla para continuar. . .");
        Console.ReadKey();
    }
}