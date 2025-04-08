using System;

// Definindo duas interfaces com o mesmo método
public class ClasseDupla : IPrimeiraInterface, ISegundaInterface
{
    // Implementação explícita do método da interface IPrimeiraInterface
    void IPrimeiraInterface.MetodoComum()
    {
        Console.WriteLine("Implementação do Método Comum da Primeira Interface\n------------------------------------------------------------------");
    }

    // Implementação explícita do método da interface ISegundaInterface
    void ISegundaInterface.MetodoComum()
    {
        Console.WriteLine("Implementação do Método Comum da Segunda Interface");
    }
}