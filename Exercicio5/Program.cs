using System;


public class Program 
{
    public static void Main(string[] args)
    {
        // Cria uma instância do GerenciadorNotificacoes, que gerencia os notificadores
        var gerenciador = new GerenciadorNotificacoes();

        // Cria instâncias dos diferentes tipos de notificadores
        var emailNotificador = new NotificadorEmail();
        var smsNotificador = new NotificadorSMS();
        var pushNotificador = new NotificadorPush();

        // Registra os notificadores no gerenciador
        gerenciador.RegistrarNotificador(emailNotificador);
        gerenciador.RegistrarNotificador(smsNotificador);
        gerenciador.RegistrarNotificador(pushNotificador);

        // Envia mensagens de teste para cada tipo de notificador
        gerenciador.EnviarMensagens("kelveag2017@gmail.com", "Olá, esta é uma mensagem de teste!\n------------------------------------------------------------------");
        gerenciador.EnviarMensagens("1234567890", "Mensagem de Teste via SMS\n------------------------------------------------------------------");
        gerenciador.EnviarMensagens("Kelve123", "Mensagem de Teste via Push\n------------------------------------------------------------------");

        // Testando a implementação de interfaces duplas
        ClasseDupla obj = new ClasseDupla();
        ((IPrimeiraInterface)obj).MetodoComum();// Chama a implementação de IPrimeiraInterface
        ((ISegundaInterface)obj).MetodoComum();// Chama a implementação de ISegundaInterface
    }
}