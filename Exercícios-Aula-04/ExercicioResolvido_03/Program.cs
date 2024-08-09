using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um valor de temperatura: ");
        double temperatura = double.Parse(Console.ReadLine());
        Celsius(temperatura);
        Fah(temperatura);

        Console.Write("\n\nPressione qualquer tecla para continuar. . .");
        Console.ReadKey();
    }
    static void Celsius(double temperatura)
    {
        double conversao = (temperatura * 1.8) + 32;
        Console.WriteLine($"\n{temperatura}° Celsius é igual à {conversao:F1} Fahrenheit");
    }
    static void Fah(double temperatura)
    {
        double conversao = (temperatura - 32) / 1.8;
        Console.WriteLine($"{temperatura} Fahrenheit é igual à {conversao:F1}° Celsius ");
    }
 
}