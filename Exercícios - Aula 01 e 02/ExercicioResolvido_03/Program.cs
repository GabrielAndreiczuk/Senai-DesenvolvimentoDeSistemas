using System;

class Program
{
    static void Main()
    {
        //DECLARAÇÃO DE VARIÁVEIS
        double raio, altura, volume;
        const double PI = 3.14159;

        //ENTRADA DE DADOS
        Console.Write("DIGITE O RAIO DA LATA DE ÓLEO (EM CM): ");
        raio = int.Parse(Console.ReadLine());
        Console.Write("DIGITE A ALTURA DA LATA DE ÓLEO (EM CM): ");
        altura = double.Parse(Console.ReadLine());

        //CÁLCULO DE VOLUME
        volume = PI * Math.Pow(raio,2) * altura;

        //SAÍDA DE DADOS
        Console.WriteLine($"O VOLUME DA LATA DE ÓLEO É DE {volume:F2} cm³");

        Console.Write("\n\nPressione qualquer tecla para continuar. . .");
        Console.ReadKey();
    }
}