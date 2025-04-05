Arquitetura da solu��o:

O sistema de pagamentos foi projetado para ser modular e extens�vel, utilizando princ�pios de Programa��o Orientada
a Objetos (POO) para garantir a robustez e a flexibilidade. A arquitetura � composta por v�rias classes que se comunicam
entre si para processar diferentes tipos de pagamentos.

---------------------------------------------------------------------------------------------------------------------------------
Princ�pios de POO aplicados:

Utilizando classes, m�todos e atributos, juntamete com a biblioteca system.colections.generic para criar listas de objetos
para manipular dados de forma mais eficiente

---------------------------------------------------------------------------------------------------------------------------------
Desafios encontrados e como foram resolvidos:

Um dos desafios foi definir uma interface comum para diferentes tipos de pagamento

Solu��o: Foi criada a classe abstrata `Pagamento` com propriedades comuns e m�todos abstratos. Isso garantiu que todas
as classes derivadas implementassem os m�todos necess�rios para processar e gerar recibos de pagamento.

Outro desafio foi processar pagamentos polimorficamente

Solu��o: A classe `ProcessadorPagamento` foi projetada para receber objetos do tipo `Pagamento` e chamar m�todos
abstratos polimorficamente. Isso permitiu que diferentes tipos de pagamento fossem processados atraves da mesma interface.

