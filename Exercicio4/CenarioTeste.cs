using System;
using System.Collections.Generic;
using Exercicio4;


public class Program
{
    public static void Main(string[] args)
    {
        var pagamentos = new List<Pagamento>
        {
            new PagamentoCartao { Valor = 1000, Data = DateTime.Now, Bandeira = "Mastercard", Numero = "1234 5678 9012 3456", Parcelas = 3 },
            new PagamentoBoleto { Valor = 500, Data = DateTime.Now, CodigoBarras = "12345678901234567890", DataVencimento = DateTime.Now.AddDays(5) },
            new PagamentoPix { Valor = 200, Data = DateTime.Now, Chave = "email@dominio.com", QRCode = "QRCodeData" }
        };

        var processador = new ProcessadorPagamento();
        processador.ProcessarPagamentos(pagamentos);
    }
}