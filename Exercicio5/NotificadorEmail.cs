using System;
using System.Collections.Generic;
using Notificacao;

public class NotificadorEmail : INotificador
{
    public string FormatoSuportado => "Email";

    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        if (ValidarDestinatario(destinatario))
        {
            Console.WriteLine($"Enviando Email para {destinatario}: {mensagem}");
        }
        else
        {
            Console.WriteLine("Destinatário de Email inválido.");
        }
    }

    public bool ValidarDestinatario(string destinatario)
    {
        return destinatario.Contains("@");
    }
}