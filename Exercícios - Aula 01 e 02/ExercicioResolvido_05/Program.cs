using System;

class Program
{
    static void Main()
    {
        //ENTRADA DE DADOS
        Console.Write("INFORME O PRIMEIRO NÚMERO: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("INFORME O SEGUNDO NÚMERO: ");
        double num2 = double.Parse(Console.ReadLine());
        //OPERAÇÕES
        double soma = num1 + num2;
        double subtracao = num1 - num2;
        double multiplicacao = num1 * num2;
        double divisao = num1 / num2;
        //SAÍDA DE DADOS 
        Console.WriteLine("\n----------------------------------\n");
        Console.WriteLine($"RESULTADO DA SOMA: {soma:F2}");
        Console.WriteLine($"RESULTADO DA SUBTAÇÃO: {subtracao:F2}");
        Console.WriteLine($"RESULTADO DA MULTIPLICAÇÃO: {multiplicacao:F2}");
        Console.WriteLine($"RESULTADO DA DIVISÃO: {divisao:F2}");

        Console.Write("\n\nPressione qualquer tecla para continuar. . .");
        Console.ReadKey();
    }
}