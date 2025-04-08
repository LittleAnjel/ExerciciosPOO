using System;
using Notificacao;

// Classe que implementa a interface INotificador para envio de notificações por Push
public class NotificadorPush : INotificador
{
    // Propriedade somente leitura que retorna o formato suportado pelo notificador
    public string FormatoSuportado => "Push";

    // Método para enviar uma notificação por Push
    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        // Verifica se o destinatário é válido antes de enviar a notificação
        if (ValidarDestinatario(destinatario))
        {
            // Exibe uma mensagem simulando o envio da notificação push
            Console.WriteLine($"Enviando notificação de push para {destinatario}: {mensagem}");
        }
        else
        {
            // Exibe uma mensagem de erro caso o destinatário seja inválido
            Console.WriteLine("Destinatário da notificação do Push inválido.");
        }
    }

    // Método para validar se o destinatário da notificação Push é válido
    public bool ValidarDestinatario(string destinatario)
    {
        // Verifica se o destinatário não é nulo, vazio e tem um comprimento adequado
        return !string.IsNullOrEmpty(destinatario) && destinatario.Length >= 5 && destinatario.Length <= 50 && !destinatario.Contains("@"); // Rejeita strings que contenham "@" para nao validar o email
    }
}