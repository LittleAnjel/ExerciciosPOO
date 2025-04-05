using System;
using Exercicio3;

public class Atendente : Funcionario 
{
    public int MetaAtendimentos {get; set;}
    public decimal Comissao {get; set;}

    public override decimal CalcularSalario()
    {
        return SalarioBase + Comissao;
    }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Meta de Atendimentos: {MetaAtendimentos}");
        Console.WriteLine($"Comissão: {Comissao}");

    }
}