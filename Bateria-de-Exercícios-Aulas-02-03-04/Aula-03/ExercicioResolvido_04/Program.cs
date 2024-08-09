using System;

class Program{
    static void Main()
    {
        Console.Write("Informe um valor de temperatura em Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fah = (celsius * 1.8) + 32;
        Console.WriteLine($"{celsius:F1}°C = {fah:F1} F");
    }
}
