using System;

class Program
{
    static void Main()
    {
        //ENTRADA DE DADOS
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        //SAÍDA DE DADOS
        Console.WriteLine("\nNÚMERO DE CARACTERES DA FRASE: " + frase.Length);  //RETORNA O TAMANHO DA STRING
        Console.WriteLine("FRASE EM LETRAS MAIÚSCULAS: "+frase.ToUpper());      //CONVERTE TODOS OS CARACTERES PARA MAIÚSCULOS
        Console.WriteLine("FRASE INVERTIDA: " + reverse(frase));                //CHAMA A FUNÇÃO REVERSE, QUE INVERTE A ORDEM DA FRASE
        //ENCERRAMENTO DO PROGRAMA
        Console.Write("\n\nPressione qualquer tecla para continuar. . .");
        Console.ReadKey();
    }

    //FUNCAO QUE INVERTE A FRASE
    static string reverse(string frase)
    {
        char[] stringArray = frase.ToCharArray();       //TRANSFORMA A STRING EM UM ARRAY DE CARACTERES, EM QUE CADA LETRA POSSUI UMA POSIÇÃO
        Array.Reverse(stringArray);                     //INVERTE AS POSIÇÕES DE CADA CARACTERE, O PRIMEIRO VIRA O ÚLTIMO E ETC...
        string reversedStr = new string(stringArray);   //ATRIBUI O ARRAY DE CARACTERES INVERTIDO À UMA NOVA VARIÁVEL DO TIPO STRING
        return reversedStr;                             //RETORNA A VARIÁVEL STRING COM O TEXTO INVERTIDO
    }
}
