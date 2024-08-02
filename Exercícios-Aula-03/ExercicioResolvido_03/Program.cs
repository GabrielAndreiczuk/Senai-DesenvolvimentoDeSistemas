using System;

class Program
{
    static void Main()
    {
        Console.Write(("INFORME O VALOR DA TEMPERATURA EM CELCIUS: "));
        double temperatura = double.Parse(Console.ReadLine());
        double f = (temperatura * 1.8) + 32;
        Console.WriteLine($"\n{temperatura}° Celcius é igual à {f} Fahrenheit");
        Console.Write("\n\nPressione qualquer tecla para continuar. . .");
        Console.ReadKey();
    }
}