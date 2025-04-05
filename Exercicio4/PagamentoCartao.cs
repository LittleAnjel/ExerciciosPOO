using System;
using System.Collections.Generic;
using Exercicio4;

//Classe de pagamento pelo cartão
public class PagamentoCartao : Pagamento
{
    //Atributos da classe
    public string? Bandeira {get; set;}
    public string? Numero {get; set;}
    public int Parcelas {get; set;}

    //Metodo (sem retorno) com o polimorfismo
    public override void Processar()
    {
        //Implementação específica para processar pagamento com cartão
        Status = "Processado Com Cartão";
        Console.WriteLine("------------------------------------------------------------------------------------------------------\nProcessando pagamento com cartão...");

    }

    //Metodo (sem retorno) com o polimorfismo
    public override void GerarRecibo()
    {
        //Implementação especifica para gerar recibo de pagamento com cartão
        System.Console.WriteLine($"Recibo: Pagamento com cartão {Bandeira} em {Parcelas} parcelas. Valor: {Valor:C}");
    }
}