using System;
class Program
{
    static void Main()
    {
        int[] numeros = { 64, 34, 25, 12, 22, 11, 90 };
        BubbleSort(numeros); 
        Console.WriteLine("array de numeros ordenado por bubble sort:"); //Bublle sort faz a ordenação substituindo pares que não estiverem na posição correta
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

        //divide em duas partes, uma ordenada e outra nao, e pega o maior numero da lista nao ordenada e passa para a ordenada
        SelectionSort(numeros);
        Console.WriteLine("array de numeros ordenado por selection sort:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
    }

    static void BubbleSort(int[] numeros)
    {
        int tamanhoArray = numeros.Length;                         //n vale 7
        for (int i = 0; i < tamanhoArray - 1; i++)             //enquanto i < 6
        {
            for (int j = 0; j < tamanhoArray - i - 1; j++)     //enquanto i < 6
            {
                if (numeros[j] > numeros[j + 1])            //se o item da posição 0 for maior que da posição 1
                {
                    // Troca numeros[j] e numeros[j + 1]
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }
    }
    static void SelectionSort(int[] numeros)
    {
        int tamanhoArray = numeros.Length;                         //n vale 7
        for (int i = 0; i < tamanhoArray - 1; i++)             //enquanto i<6
        {
            // Encontrar o menor elemento na parte não ordenada
            int minIndex = i;
            for (int j = i + 1; j < tamanhoArray; j++)
            {
                if (numeros[j] < numeros[minIndex])
                {
                    minIndex = j;
                }
            }
            // Trocar o menor elemento encontrado com o primeiro elemento da parte não ordenada
            int temp = numeros[minIndex];
            numeros[minIndex] = numeros[i];
            numeros[i] = temp;
        }
    }
}