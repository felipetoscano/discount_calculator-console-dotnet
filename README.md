# discount-calculator
Projeto em C# que realiza descontos, utilizando o Design Pattern Chains of Responsability

Neste exemplo, precisamos calcular um desconto em função do resultado do outro. Por exemplo, primeiro tentamos calcular o desconto na classe FiveItensDiscount. Caso um desconto fosse aplicado, seria retornado o valor final e o resultado apresentado na tela. Mas se o desconto não entrar na condição de ser aplicado, a classe já chama a próxima classe da cadeia. Desta forma, cada classe irá funcionar de forma independente, se preocupando apenas com suas regras de negócio, e se encadeando com a próxima, de acordo com o configurado na classe DiscountProcessor. Tudo isso irá acarretar em um código mais limpo, de mais fácil manutenção e evitando um número enorme de "ifs".
