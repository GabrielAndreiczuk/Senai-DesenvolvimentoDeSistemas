namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)//PROGRAMA QUE RETORNA O PRODUTO DE DUAS FRAÇÕES
        {
            Console.Write("Informe o numerador da primeira fração: ");
            int numerador1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o denominador da primeira fração: ");
            int denominador1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o numerador da segunda fração: ");
            int numerador2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o denominador da segunda fração: ");
            int denominador2 = int.Parse(Console.ReadLine());

            //CALCULO DO PRODUTO
            int produtoNumerador = numerador1 * numerador2;
            int produtoDenominador = denominador1 * denominador2;

            //CALCULAR A ADIÇÃO DAS FRAÇÕES
            int somaNumerador = numerador1 * denominador2 + numerador2 * denominador1;
            int somaDenominador = denominador1 * denominador2;

            //SIMPLIFICAR FRAÇÕES
            Simplificar(ref somaNumerador, ref somaDenominador);
            Simplificar(ref produtoNumerador, ref produtoDenominador);

            //EXIBIR RESULTADOS
            Console.WriteLine($"Produto: {produtoNumerador} / {produtoDenominador}");
            Console.WriteLine($"Soma: {somaNumerador} / {somaDenominador}");

            Console.Write("\n\nPressione qualquer tecla para continuar. . .");
            Console.ReadKey();
        }

        //FUNÇÃO PARA SIMPLIFICAR A FRAÇÃO
        static void Simplificar(ref int numerador, ref int denominador)
        {
            int gcd = MDC(numerador, denominador);
            numerador /= gcd;
            denominador /= gcd;
        }

        //FUNÇÃO PARA SIMPLIFICAR O MAXIMO DIVISOR COMUM
        static int MDC(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}