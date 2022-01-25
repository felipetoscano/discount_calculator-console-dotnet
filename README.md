# discount-calculator
Projeto em C# que realiza descontos, utilizando o Design Pattern State

Neste exemplo, precisamos calcular o desconto de um orçamento de acordo com seu estado. Por exemplo, caso o orçamento esteja no estado "InApprovation", ele recebe 5% de desconto. Ao mudar para o estado "Approved", recebe mais 2%. Além disso, precisamos também controlar a mudança de estado do orçamento. Um orçamento finalizado jamais poderá ser aprovado novamente.

Implementar essa regra de cada um dos estados dentro do orçamento acarretaria um grande número de "ifs" e alto grau de complexidade para controlar cada um dos estados.

Utilizando o padrão State, podemos passar essa responsabilidade para cada um destes estados, criando uma classe para cada um deles, onde concentrará a sua respectiva regra. Isso contribui para a resolução do problema acima.
