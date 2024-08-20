using System;

class Program
{
    static void Main()
    {
        Stack<int> pilha = new Stack<int>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Informe um número: ");
            pilha.Push(int.Parse(Console.ReadLine()));  //ADICIONA O NÚMERO LIDO NA PILHA
        }
        Console.WriteLine("\nNÚMEROS DESEMPILHADOS:");

        while (pilha.Count > 0)         //EXECUTA ENQUANTO A PILHA NAO ESTIVER VAZIA (CONTAGEM NÃO É ZERO)
        {
            int numero = pilha.Pop();   //RETIRA O ELEMENTO DO TOPO DA PILHA E GRAVA NA VARIÁVEL NUMERO
            Console.WriteLine(numero);  //IMPRIME O NUMERO NA TELA
        }
    }
}