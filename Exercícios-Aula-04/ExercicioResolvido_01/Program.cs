using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("\n[1]SOMA           [2]SUBTRAÇÃO");
        Console.WriteLine("[3]MULTIPLICAÇÃO  [4]DIVISÃO");
        Console.Write("OPÇÃO ESCOLHIDA: ");
        int opcao = int.Parse(Console.ReadLine());

        Operacoes resultado = new Operacoes();// SEGUNDA VERSÃO UTILIZANDO CLASSES EM ARQUIVO SEPARADO
        resultado.getNum(num1, num2);//PASSA OS DOIS VALORES PARA A OUTRA CLASSE

        switch (opcao)
        {
            case 1:
                Console.WriteLine("\nO RESULTADO DA SOMA É: " + resultado.getSoma());//RETORNA SOMA
                break;
            case 2:
                Console.WriteLine("\nO RESULTADO DA SUBTRAÇÃO É: " + resultado.getSubtracao());//MÉTODO QUE RETORNA SUBTRAÇÃO
                break;
            case 3:
                Console.WriteLine("\nO RESULTADO DA MULTIPLICACAO É: " + resultado.getMultiplicacao());//MÉTODO QUE RETORNA MULTIPLICAÇÃO
                break;
            case 4:
                Console.WriteLine("\nO RESULTADO DA DIVISÃO É: " + resultado.getDivisao());//MÉTODO QUE RETORNA DIVISÃO
                break;
            default:
                Console.WriteLine("\nESCOLHA UMA OPÇÃO VÁLIDA!");
                break;
        }
        Console.Write("Pressione qualquer tecla para continuar. . .");
        Console.ReadKey();
    }

    //PRIMEIRA VERSÃO UTILIZANDO FUNÇÕES

    /*
    static double soma(double num1, double num2)
    {
        return num1 + num2;
    }
    static double subtracao(double num1, double num2)
    {
        return num1 - num2;
    }
    static double multiplicacao(double num1, double num2)
    {
        return num1 * num2;
    }
    static double divisao(double num1, double num2)
    {
        return num1 / num2;
    }*/
}
