Arquitetura da solução:

O sistema de pagamentos foi projetado para ser modular e extensível, utilizando princípios de Programação Orientada
a Objetos (POO) para garantir a robustez e a flexibilidade. A arquitetura é composta por várias classes que se comunicam
entre si para processar diferentes tipos de pagamentos.

---------------------------------------------------------------------------------------------------------------------------------
Princípios de POO aplicados:

Utilizando classes, métodos e atributos, juntamete com a biblioteca system.colections.generic para criar listas de objetos
para manipular dados de forma mais eficiente

---------------------------------------------------------------------------------------------------------------------------------
Desafios encontrados e como foram resolvidos:

Um dos desafios foi definir uma interface comum para diferentes tipos de pagamento

Solução: Foi criada a classe abstrata `Pagamento` com propriedades comuns e métodos abstratos. Isso garantiu que todas
as classes derivadas implementassem os metodos necessarios para processar e gerar recibos de pagamento.

Outro desafio foi processar pagamentos polimorficamente

Solução: A classe `ProcessadorPagamento` foi projetada para receber objetos do tipo `Pagamento` e chamar métodos
abstratos polimorficamente. Isso permitiu que diferentes tipos de pagamento fossem processados atraves da mesma interface.

