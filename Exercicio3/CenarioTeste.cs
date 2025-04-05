using System;
using Exercicio3;
using System.Collections.Generic;

//Classe CenarioTeste   
public class CenarioTeste
{
    // Método (sem retorno) Main para executar o teste
    public static void Main(string[] args)
    {
        // Criação de uma lista de funcionários com diferentes tipos
        List<Funcionario> funcionarios = new List<Funcionario>
        {
            new Desenvolvedor
            {
                Nome = "João",
                CPF = "000.000.000-00",
                DataAdmissao = DateTime.Now.AddYears(-3),
                SalarioBase = 5000,
                Especialidade = "C#",
                Nivel = "Senior"
            },
            new Gerente
            {
                Nome = "Maria",
                CPF = "000.000.000-00",
                DataAdmissao = DateTime.Now.AddYears(-5),
                SalarioBase = 8000,
                Equipe = "Desenvolvimento",
                BonusPorResultados = 3000
            },
            new Atendente
            {
                Nome = "Carlos",
                CPF = "000.000.000-00",
                DataAdmissao = DateTime.Now.AddYears(-2),
                SalarioBase = 3000,
                MetaAtendimentos = 100,
                Comissao = 500
            }
        };

        Console.WriteLine("Processando a folha de pagamento:\n");

        foreach (var funcionario in funcionarios)
        {
            funcionario.ExibirDados();
            Console.WriteLine($"Salário Calculado: {funcionario.CalcularSalario():C}\n");
        }
    }
}