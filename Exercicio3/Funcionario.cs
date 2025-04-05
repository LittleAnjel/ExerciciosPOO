using System;

namespace Exercicio3
{
    public class Funcionario
    {
        public string? Nome {get; set;}
        public string? CPF {get; set;}
        public DateTime DataAdmissao {get; set;}
        public decimal SalarioBase {get; set;}

        public virtual decimal CalcularSalario()
        {
            return SalarioBase;
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Salário Base: {SalarioBase:C}");
        }

    }

}
