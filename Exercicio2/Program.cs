using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Produto produto1 = new Produto("Produto X", "001", 10.0, 5);

                Console.WriteLine($"Nome: {produto1.Nome}\n------------------------------------------------------------------");
                Console.WriteLine($"Código: {produto1.Codigo}\n------------------------------------------------------------------" );
                Console.WriteLine($"Preço: {produto1.Preco}\n------------------------------------------------------------------" );
                Console.WriteLine($"Estoque:{produto1.Estoque}\n------------------------------------------------------------------" );
                Console.WriteLine($"Valor em Estoque: {produto1.ValorEmEstoque}\n------------------------------------------------------------------");
                Console.WriteLine($"Status: {produto1.Status}\n------------------------------------------------------------------");
                Console.WriteLine($" Data de Cadastro: {produto1.DataCadastro}\n------------------------------------------------------------------");
            }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
        }
    }
}

