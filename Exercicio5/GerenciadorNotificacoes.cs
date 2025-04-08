using System;
using Notificacao;

public class GerenciadorNotificacoes
{
    //Lista para armazenar os objetos que implementam a interface INotificador
    private List<INotificador> notificadores = new List<INotificador>();

    // Método para registrar um novo notificador na lista
    public void RegistrarNotificador(INotificador notificador)
    {
        notificadores.Add(notificador); // Adiciona o notificador à lista
    }

    // Método para enviar mensagens usando todos os notificadores registrados
    public void EnviarMensagens(string destinatario, string mensagem)
    {
        foreach (var notificador in notificadores)
        {
            if (notificador.ValidarDestinatario(destinatario))
            {
                notificador.EnviarNotificacao(destinatario, mensagem);
            }
            else
            {
                Console.WriteLine($"Destinatário inválido para o formato {notificador.FormatoSuportado}.");
            }
        }
    }
}