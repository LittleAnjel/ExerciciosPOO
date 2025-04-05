using System;
using Exercicio3;

//classe gerente 
public class Gerente : Funcionario
{
    //atributo da classe gerente 
    public string? Equipe {get; set;}
    public decimal BonusPorResultados {get; set;}

    //método que calcula o salário do gerente
    public override decimal CalcularSalario()
    {
        return SalarioBase + BonusPorResultados;
    }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Equipe: {Equipe}");
        Console.WriteLine($"Bônus por Resultados: {BonusPorResultados}");

    }
}