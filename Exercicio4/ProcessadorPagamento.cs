using System;
using System.Collections.Generic;
using Exercicio4;

//Implementando a classe do Processador de pagamentos
public class ProcessadorPagamento
{
    // Método para processar um pagamento individualmente
    public void ProcessarPagamento(Pagamento pagamento)
    {
        //Chama o método Processar do pagamento, que é polimórfico
        pagamento.Processar();
        // Chama o método GerarRecibo do pagamento, que é polimórfico
        pagamento.GerarRecibo();
        // Registra as informações de auditoria do pagamento processado
        RegistrarAuditoria(pagamento);
    }

    // Método para processar uma lista de pagamentos 
    public void ProcessarPagamentos(List<Pagamento> pagamentos)
    {
        foreach (var pagamento in pagamentos)
        {
            ProcessarPagamento(pagamento);
        }
    }

     // Método privado para registrar informações de auditoria
    private void RegistrarAuditoria(Pagamento pagamento)
    {
        // Registro de informações de auditoria
        Console.WriteLine($"Auditoria: Pagamento de {pagamento.Valor:C} processado em {pagamento.Data}. Status: {pagamento.Status}");
    }
}