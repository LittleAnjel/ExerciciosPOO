using System;
using Notificacao;

// Definindo duas interfaces com o mesmo método
public class ClasseDupla : IPrimeiraInterface, ISegundaInterface
{
    void IPrimeiraInterface.MetodoComum()
    {
        Console.WriteLine("Implementação do Método Comum da Primeira Interface");
    }

    void ISegundaInterface.MetodoComum()
    {
        Console.WriteLine("Implementação do Método Comum da Segunda Interface");
    }
}