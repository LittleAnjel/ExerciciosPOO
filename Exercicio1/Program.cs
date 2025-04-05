using System;
using Exercicio1;

class Program
{
    static void Main()
    {
        // Criação de uma conta bancária
        ContaBancaria conta = new ContaBancaria("123456", "Kelve Alves");

        // Realização de operações
        conta.Depositar(1000);
        conta.Sacar(200);
        conta.Depositar(500);
        
        // Exibição do extrato
        conta.VerExtrato();
    }
}
