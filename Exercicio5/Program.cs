using System;
using Notificacao;


public class Program 
{
    public static void Main(string[] args)
    {
        var gerenciador = new GerenciadorNotificacoes();

        var emailNotificador = new NotificadorEmail();
        var smsNotificador = new NotificadorSMS();
        var pushNotificador = new NotificadorPush();

        gerenciador.RegistrarNotificador(emailNotificador);
        gerenciador.RegistrarNotificador(smsNotificador);
        gerenciador.RegistrarNotificador(pushNotificador);

        gerenciador.EnviarMensagens("kelveag2017@gmail.com", "Olá, esta é uma mensagem de teste!");
        gerenciador.EnviarMensagens("123", "Mensagem de Teste via SMS");
        gerenciador.EnviarMensagens("KelvePush", "Mensagem de Teste via Push");

        // Testando a implementação de interfaces duplas
        ClasseDupla obj = new ClasseDupla();
        ((IPrimeiraInterface)obj).MetodoComum();
        ((ISegundaInterface)obj).MetodoComum();
    }
}