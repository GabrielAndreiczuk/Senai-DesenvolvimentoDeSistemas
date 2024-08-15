using System;

public abstract class Forma
{
    public abstract double CalcularArea();
}

//CLASSE RETÂNGULO QUE HERDA DA CLASSE ABSTRATA FORMA
public class Retangulo : Forma
{
    public double Largura { get; set; } //PRORPIEDADES AUTO-IMPLEMENTADAS, SEM NECESSIDADE DE VALIDAÇÃO
    public double Altura { get; set; }

    public override double CalcularArea()
    {
        return Largura * Altura;
    }
}

//CLASSE CIRCULO QUE HERDA DA CLASSE ABSTRATA FORMA
public class Circulo : Forma
{
    public double Raio { get; set; }//PRORPIEDADE AUTO-IMPLEMENTADA, SEM NECESSIDADE DE VALIDAÇÃO

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Raio, 2);
    }
}

public class Program
{
    public static void Main()
    {
        //INSTÂNCIANDO RETANGULO E PASSANDO VALOR DE PARÂMETROS
        Retangulo retangulo = new Retangulo
        {
            Largura = 5.0,
            Altura = 10.0
        };

        //INSTÂNCIANDO CIRCULO E PASSANDO VALOR DE PARÂMETROS
        Circulo circulo = new Circulo
        {
            Raio = 10.0
        };

        //MOSTRANDO RESULTADOS NA TELA
        Console.WriteLine($"Área do Retângulo: {retangulo.CalcularArea()}");
        Console.WriteLine($"Área do Círculo: {circulo.CalcularArea():F2}");
    }
}