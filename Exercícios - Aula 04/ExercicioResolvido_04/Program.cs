using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int valor = int.Parse(Console.ReadLine());
        Fatorial fatorial = new Fatorial();
        fatorial.getNum(valor);
        Console.WriteLine($"{valor}! É {fatorial.getFatorial()}");
        Console.WriteLine(fatorial.getText());
    }
}
class Fatorial
{
    private int fatorial = 1;
    private string fatorialText;

    public void getNum(int valor)
    {
        for (int i = valor; i > 1; i--)
        {
            fatorial *= i;
            fatorialText += $"{i} x ";
        }
        fatorialText += $"1 = {fatorial}";
    }
    public int getFatorial()
    {
        return fatorial;
    }
    public string getText()
    {
        return fatorialText;
    }
}