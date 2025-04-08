using System;
using System.Collections.Generic;
using Notificacao;

public class NotificadorPush : INotificador
{
    public string FormatoSuportado => "Push";

    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        if (ValidarDestinatario(destinatario))
        {
            Console.WriteLine($"Enviando Push Notification para {destinatario}: {mensagem}");
        }
        else
        {
            Console.WriteLine("Destinatário de Push Notification inválido.");
        }
    }

    public bool ValidarDestinatario(string destinatario)
    {
        return !string.IsNullOrEmpty(destinatario); // Exemplo simples de validação
    }
}