using System;

class Program
{
    static void Main()
    {
        //ENTRADA DE DADOS
        Console.Write("INFORME A PRIMEIRA NOTA: ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.Write("INFORME O PESO DA PRIMEIRA NOTA: ");
        double peso1 = double.Parse(Console.ReadLine());
        Console.Write("INFORME A SEGUNDA NOTA: ");
        double nota2 = double.Parse(Console.ReadLine());
        Console.Write("INFORME O PESO DA SEGUNDA NOTA: ");
        double peso2 = double.Parse(Console.ReadLine());

        //CÁLCULO DE MÉDIA
        double mediaPonderada = ((nota1 *  peso1) + (nota2 * peso2)) / (peso1 + peso2);

        //SAÍDA DE DADOS
        Console.WriteLine($"\nA MÉDIA PONDERADA É DE: {mediaPonderada:F2}");

        Console.Write("\n\nPressione qualquer tecla para continuar. . .");
        Console.ReadKey();
    }
}