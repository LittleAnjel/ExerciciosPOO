using System;
using Exercicio4;

//Classe de Pagamento no Pix
public class PagamentoPix : Pagamento
{   
    //Atributos da classe
    public string? Chave { get; set; }
    public string? QRCode { get; set; }

    //Metodo (sem retorno) com o polimorfismo
    public override void Processar()
    {
        // Implementação específica para processar pagamento com Pix
        Status = "Processado com Pix\n------------------------------------------------------------------------------------------------------";
        Console.WriteLine("------------------------------------------------------------------------------------------------------\nProcessando pagamento com Pix...");
    }

    //Metodo (sem retorno) com o polimorfismo
    public override void GerarRecibo()
    {
        // Implementação específica para gerar recibo de pagamento com Pix
        Console.WriteLine($"Recibo: Pagamento com Pix. Chave: {Chave}. Valor: {Valor:C}");
    }
}