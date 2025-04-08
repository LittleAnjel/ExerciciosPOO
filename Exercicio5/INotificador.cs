using System;
using System.Collections.Generic;

namespace Notificacao
{
    // Definição da interface INotificador
    public interface INotificador
    {
            // Método para enviar uma notificação tendo como parametro o destinatário e a mensagem
            void EnviarNotificacao(string mensagem, string destinatario);
            // Método para validar o destinatário da notificação
            bool ValidarDestinatario(string destinatario);
            // Propriedade somente leitura que retorna o formato suportado pelo notificador
            String FormatoSuportado { get; }

    }

    
    
}