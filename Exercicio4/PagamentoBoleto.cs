using System;
using Exercicio4;

//Classe de pagamento no boleto
public class PagamentoBoleto : Pagamento
{
    //Atributos da classe 
    public string? CodigoBarras { get; set; }
    public DateTime DataVencimento { get; set; }

    //Metodo (sem retorno) com o polimorfismo
    public override void Processar()
    {
        // Implementação específica para processar pagamento com boleto
        Status = "Processado com Boleto";
        Console.WriteLine("------------------------------------------------------------------------------------------------------\nProcessando pagamento com boleto...");
    }

    //Metodo (sem retorno) com o polimorfismo
    public override void GerarRecibo()
    {
        // Implementação específica para gerar recibo de pagamento com boleto
        Console.WriteLine($"Recibo: Pagamento com boleto. Código de Barras: {CodigoBarras}. Valor: {Valor:C}");
    }
}