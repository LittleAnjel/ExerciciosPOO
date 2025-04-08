using System;
using System.Collections.Generic;
using Notificacao;

// Classe que implementa a interface INotificador para envio de notificações por SMS
public class NotificadorSMS : INotificador
{
        // Propriedade somente leitura que retorna o formato suportado pelo notificador
        public string FormatoSuportado => "SMS";

    // Método para enviar uma notificação por SMS
    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        // Verifica se o destinatário é válido antes de enviar a notificação
        if (ValidarDestinatario(destinatario))
        {
            Console.WriteLine($"Enviando SMS para {destinatario}: {mensagem}");
        }
        else
        {
            Console.WriteLine("Destinatário de SMS inválido.");
        }
    }

    // Método para validar se o destinatário do SMS é válido
    public bool ValidarDestinatario(string destinatario)
    {
        return destinatario.Length >= 10 && destinatario.Length <= 11 && destinatario.All(char.IsDigit); // Exemplo simples de validação de número de telefone
    }
}