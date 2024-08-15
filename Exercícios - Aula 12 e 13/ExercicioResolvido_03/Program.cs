using System;

public interface IPessoa
{
    void Falar();
}
public class Professor : IPessoa
{
    public void Falar()
    {
        Console.WriteLine("Boa noite, Turma!");
    }
}
public class Aluno : IPessoa 
{ 
    public void Falar()
    {
        Console.WriteLine("Boa noite, Professor!");
    }
}

public class Program
{
    public static void Main()
    {
        IPessoa professor = new Professor();
        IPessoa aluno = new Aluno();

        professor.Falar();
        Console.WriteLine();
        aluno.Falar();
    }
}