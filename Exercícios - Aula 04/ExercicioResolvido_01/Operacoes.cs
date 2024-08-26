using System;

public class Operacoes
{
    private double valor1, valor2;
    public void getNum(double num1, double num2)
    {
        valor1 = num1;
        valor2 = num2;
    }
    public double getSoma()
    {
        return valor1 + valor2;
    }
    public double getSubtracao()
    {
        return valor1 - valor2;
    }
    public double getMultiplicacao()
    {
        return valor1 * valor2;
    }
    public double getDivisao()
    {
        return valor1 / valor2;
    }
}
