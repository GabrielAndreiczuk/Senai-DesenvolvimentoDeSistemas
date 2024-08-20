using System;

class Program
{
    static void Main()
    {
        Queue<string> fila = new Queue<string>();

        for(int i = 0; i < 3; i++)
        {
            Console.Write("Informe um nome: ");
            fila.Enqueue(Console.ReadLine());
        }
        Console.WriteLine("\nNomes fora da fila: ");
        while (fila.Count > 0)
        {
            string nome = fila.Dequeue();
            Console.WriteLine(nome);
        }
    }
}