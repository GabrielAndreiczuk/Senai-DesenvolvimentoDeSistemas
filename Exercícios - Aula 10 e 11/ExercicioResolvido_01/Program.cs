using System;

class Program
{
    static void Main()
    {
        //EXERCÍCIO 1
        Pessoa p = new Pessoa("Gabriel",20);
        p.exibirInformacoes();
        Console.WriteLine();

        //EXERCÍCIO 2
        p.aniversario();
        p.exibirInformacoes();
        Console.WriteLine();

        //EXERCÍCIO 3
        Alarme alarme = new Alarme();
        alarme.AlarmeAtivado += Alarme_Ativado;
        alarme.AtivarAlarme();
        Console.WriteLine();

        //EXERCÍCIO 4
        ContaBancaria conta = new ContaBancaria();
        conta.SaldoAlterado += Saldo_Alterado;
        conta.AlterarSaldo(100);      
        conta.exibirSaldo();    //RESOLVI ADICIONAR UM MÉTODO PARA EXIBIR O SALDO ATUAL
        Console.WriteLine();
        conta.AlterarSaldo(-50);
        conta.exibirSaldo();
    }

    //EXERCÍCIO 3 - MANIPULADOR DO EVENTO ALARME ATIVADO
    private static void Alarme_Ativado(object sender, EventArgs e)
    {
        Console.WriteLine("O alarme foi ativado!");
    }

    //EXERCÍCIO 4 - MANIPULADOR DO EVENTO ALTERAR SALDO
    private static void Saldo_Alterado(object sender, EventArgs e)
    {
        Console.WriteLine("O saldo foi alterado!");
    }
}
class Pessoa
{
    private string Nome;
    private int Idade;

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public void exibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome} Idade: {Idade}");
    }
    //EXERCÍCIO 2
    public void aniversario()
    {
        Idade++;
        Console.WriteLine(Nome + " fez aniversário!");
    }
}

//EXERCÍCIO 3
class Alarme
{
    //EVENTO QUE VAI SER DISPARADO QUANDO O ALARME FOR ATIVADO
    public event EventHandler AlarmeAtivado;

    //MÉTODO QUE VAI ATIVAR O ALARME E DISPARAR O EVENTO
    public void AtivarAlarme()
    {
        OnAlarmeAtivado(EventArgs.Empty);
    }
    //MÉTODO PROTEGIDO PARA DISPARAR O EVENTO
    protected virtual void OnAlarmeAtivado(EventArgs e)
    {
        AlarmeAtivado?.Invoke(this, e);
    }
}

//EXERCÍCIO 4
class ContaBancaria
{
    private double Saldo { get; set; }

    /*
    public double Saldo //PROPRIEDADE AUTO-IMPLEMENTADA PARA O SALDO
    {
        get => saldo;
        private set
        {
            if(saldo != value)  //CONDICIONAL PARA DISPARAR O EVENTO SOMENTE SE O VALOR MUDAR
            {
                saldo = value;
                OnSaldoAlterado(EventArgs.Empty);
            }
        }
    }*/

    //CRIANDO O EVENTO QUE VAI SER DISPARADO
    public event EventHandler SaldoAlterado;

    //CRIANDO O MÉTODO PARA ALTERAR O SALDO
    public void AlterarSaldo(double valor)
    {
        Saldo += valor;
        OnSaldoAlterado(EventArgs.Empty);
    }
    protected virtual void OnSaldoAlterado(EventArgs e)
    {
        SaldoAlterado?.Invoke(this, e);
    }

    public void exibirSaldo()
    {
        Console.WriteLine($"Saldo atual: {Saldo:C}");
    }
}
