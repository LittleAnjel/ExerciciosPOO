using System;
using Notificacao;

public class GerenciadorNotificacoes
{
    private List<INotificador> notificadores = new List<INotificador>();

    public void RegistrarNotificador(INotificador notificador)
    {
        notificadores.Add(notificador);
    }

    public void EnviarMensagens(string destinatario, string mensagem)
    {
        foreach (var notificador in notificadores)
        {
            notificador.EnviarNotificacao(destinatario, mensagem);
        }
    }
}