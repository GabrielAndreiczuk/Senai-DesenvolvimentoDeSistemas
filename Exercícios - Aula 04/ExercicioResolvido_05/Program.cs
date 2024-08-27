using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {   
        Console.Write("VERIFICAÇÃO DE PALÍNDROMOS\n\n");
        Console.Write("Digite uma frase ou palavra: ");
        string frase = Console.ReadLine();

        if(reverse(frase))
        {
            Console.WriteLine($"{frase} é um palíndromo!");
        }
        else
        {
            Console.WriteLine($"{frase} não é um palíndromo!");
        }
    }

    static bool reverse(string frase)
    {
        string fraseCopia = "";
        frase = RemoveAcentos(frase);
        //LAÇO QUE VERIFICA SE O CARACTER É UMA LETRA E GRAVA NA VARIÁVEL FRASE CÓPIA
        for(int i = 0; i < frase.Length; i++)
        {
            if (char.IsLetter(frase[i]))
            {
                fraseCopia += frase[i];
            }
        }

        //FAZ A INVERSÃO DOS CARACTERES DA STRING
        char[] charFrase = fraseCopia.ToCharArray();
        Array.Reverse( charFrase );
        string fraseInvertida = new string(charFrase);
        Console.WriteLine("Frase Invertida: " +  fraseInvertida);

        //VERIFICA SE A STRING É IGUAL A STRING INVERTIDA
        if(fraseCopia == fraseInvertida)
        {
            return true;
        }
        else
        {
            return false;
        }       
    }

    static string RemoveAcentos(string frase)
    {
        if (frase == null)
            return null;

        // Normaliza a string para decompor caracteres acentuados
        string fraseNormalizada = frase.Normalize(NormalizationForm.FormD); //DIVIDE EM DOIS, CARACTERE BASE E ACENTO

        //STRING BUILDER PERMITE REALIZAR MODIFICAÇÕES NA STRING AO INVÉS DE CRIAR OU CONCATENAR UMA NOVA A CADA ALTERAÇÃO
        StringBuilder sb = new StringBuilder();

        // Adiciona apenas caracteres que não são marcas de acentuação
        foreach (char c in fraseNormalizada)
        {
            UnicodeCategory categoria = CharUnicodeInfo.GetUnicodeCategory(c);
            if (categoria != UnicodeCategory.NonSpacingMark)                 //ADICIONA NA STRING APENAS OS CARACTERES BASE
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}