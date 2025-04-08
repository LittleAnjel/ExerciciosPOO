using System;
using System.Collections.Generic;

namespace Notificacao
{
    public interface INotificador
    {
        
            void EnviarNotificacao(string mensagem, string destinatario);
            bool ValidarDestinatario(string destinatario);
            String FormatoSuportado { get; }

    }

    
    
}