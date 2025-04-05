using System;
using Exercicio3;

public class Desenvolvedor : Funcionario
{
    public string? Especialidade{get; set;}
    public string? Nivel {get; set;}

    public override decimal CalcularSalario()
    {
        // Exemplo de cálculo de salário para Desenvolvedor
        decimal bonus = Nivel == "Senior" ? 2000 : 1000;
        return SalarioBase + bonus;
    }
    
    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Especialidade: {Especialidade}");
        Console.WriteLine($"Nível: {Nivel}");
    }
 
}