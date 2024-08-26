using System;

class Program
{
    static void Main()
    {
        //VERSÃO 2
        double num1 = 0 , num2 = 0;
        int loop = 0;
        do
        {
            Console.Clear();
            Console.Write("INFORME O PRIMEIRO NÚMERO: ");
            bool isDigit = double.TryParse(Console.ReadLine(), out num1);           //VERIFICA SE O VALOR DIGITADO É UM NÚMERO
            if (isDigit == false)
            {
                Console.WriteLine("\nINFORME APENAS NÚMEROS!");
                Console.Write("\nPressione qualquer tecla para continuar. . .");
                Console.ReadKey();
                continue;
            }

            Console.Write("INFORME O SEGUNDO NÚMERO: ");
            isDigit = double.TryParse(Console.ReadLine(), out num2);                //VERIFICA SE O VALOR DIGITADO É UM NÚMERO

            if (isDigit == false)
            {
                Console.WriteLine("\nINFORME APENAS NÚMEROS!");
                Console.Write("\nPressione qualquer tecla para continuar. . .");
                Console.ReadKey();
                continue;
            }
            else
            {
                loop = 1;
            }
        }
        while (loop == 0);
        //CÁLCULOS COM AS VARIÁVEIS
        double soma = num1 + num2;
        double subtracao = num1 - num2;
        double multiplicacao = num1 * num2;
        double divisao = (double)num1 / num2;
        //SAÍDA DE DADOS
        Console.Clear();
        Console.WriteLine("NÚMERO 1: " + num1);
        Console.WriteLine("NÚMERO 2: " + num2);
        Console.WriteLine("\nRESULTADO DA SOMA: " + soma);
        Console.WriteLine("RESULTADO DA SUBTRAÇÃO: " + subtracao);
        Console.WriteLine("RESULTADO DA MULTIPLICAÇÃO: " + multiplicacao);
        Console.WriteLine($"RESULTADO DA DIVISÃO: " + divisao);

        Console.Write("\n\nPressione qualquer tecla para continuar. . .");
        Console.ReadKey();


        /*VERSÃO 1
         * 
        //ENTRADA DE DADOS
        Console.WriteLine("------ UTILIZE APENAS NÚMEROS INTEIROS ------\n\n");
        Console.Write("INFORME O PRIMEIRO NÚMERO: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("INFORME O SEGUNDO NÚMERO: ");
        int num2 = int.Parse(Console.ReadLine());
        //CÁLCULOS COM AS VARIÁVEIS
        int soma = num1 + num2;
        int subtracao = num1 - num2;
        int multiplicacao = num1 * num2;
        double divisao = (double) num1 / num2;
        //SAÍDA DE DADOS
        Console.WriteLine("RESULTADO DA SOMA: " + soma);
        Console.WriteLine("RESULTADO DA SUBTRAÇÃO: " + subtracao);
        Console.WriteLine("RESULTADO DA MULTIPLICAÇÃO: " + multiplicacao);
        Console.WriteLine($"RESULTADO DA DIVISÃO: " + divisao);

        Console.Write("\n\nPressione qualquer tecla para continuar. . .");
        Console.ReadKey();*/
    }
}