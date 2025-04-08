using System;
using System.Collections.Generic;
using Notificacao;

// Implementação da interface INotificador para envio de notificações por Email
public class NotificadorEmail : INotificador
{
    // Propriedade somente leitura que retorna o formato suportado pelo notificador
    public string FormatoSuportado => "Email";

    // Método para enviar uma notificação por Email
    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        // Verifica se o destinatário é válido antes de enviar a notificação
        if (ValidarDestinatario(destinatario))
        {
            Console.WriteLine($"Enviando Email para {destinatario}: {mensagem}");
        }
        else
        {
            Console.WriteLine("Destinatário de Email inválido.");
        }
    }
    // Retorna true se o destinatário contém o caractere "@", caso contrário, false
    public bool ValidarDestinatario(string destinatario)
    {
        return destinatario.Contains("@");
    }
}