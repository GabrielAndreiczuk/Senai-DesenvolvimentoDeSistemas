using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();
        InverterString inverter = new InverterString();
        Console.WriteLine("\nA frase invertida é: " + inverter.Inverter(frase));
    }
}
class InverterString
{
    public string Inverter(string frase)
    { 
        char[] charFrase = frase.ToCharArray();
        Array.Reverse(charFrase);
        string fraseReversa = new string (charFrase);
        return fraseReversa;
    }
}