# TBL1POO2

1- Definição

Problema: A empresa não possui um método automatizado e rápido para registrar as vendas, precisando de uma ferramenta de linha de comando para agilizar o caixa.

Objetivo do sistema: Desenvolver uma aplicação simples em console que permita ao atendente registrar o nome do cliente, adicionar os produtos desejados, calcular o valor total da compra e registrar a forma de pagamento, gerando um recibo final.

2- Análise
Funcionalidades:

Receber e armazenar o nome do cliente.
Exibir um catálogo básico de produtos.
Permitir a adição de múltiplos produtos ao pedido através de um código (ID).
Calcular automaticamente a soma dos valores dos produtos escolhidos.
Receber a forma de pagamento escolhida pelo cliente.
Exibir um resumo completo do pedido.

Regras de Negócio:

O usuário pode adicionar quantos produtos quiser através de um loop.
O usuário deve poder encerrar a adição de produtos a qualquer momento digitando 0.
Se nenhum produto for comprado, o sistema não deve cobrar ou pedir forma de pagamento (venda cancelada). 

3- Projeto

Organização da Solução: O sistema será construído em C# como uma aplicação de console. O código será estruturado em um único arquivo com a classe principal Program controlando o fluxo do usuário, e uma classe auxiliar Produto para moldar o catálogo.

Operações:
O catálogo será uma List<Produto> pré-definida.
Usaremos um laço while(true) para manter a tela de compra ativa até a condição de parada (id == 0).
Os itens comprados serão guardados em uma List<string> apenas com seus nomes para facilitar a impressão final, e o valor decimal total será incrementado a cada produto encontrado.

5- Testes

Situação de Teste 1: Fluxo de compra normal (Caminho Feliz)

Situação Testada: O usuário informa o nome "João", seleciona o ID 1 (Teclado), depois o ID 2 (Mouse), digita 0 para finalizar e informa "Pix" como pagamento.
Resultado Esperado: O sistema deve calcular o total de R$ 230,00 e imprimir o resumo mostrando "Teclado, Mouse", o valor correto e o pagamento em "Pix".
Resultado Obtido: O sistema imprimiu o resumo exatamente conforme esperado, somando os preços (150 + 80 = 230). Sucesso.

Situação de Teste 2: Desistência de compra (Carrinho Vazio)

Situação Testada: O usuário informa o nome "Maria" e, logo na primeira pergunta de produto, digita 0 para finalizar sem escolher nada.
Resultado Esperado: O sistema deve exibir uma mensagem de cancelamento ("Nenhum produto selecionado. Venda cancelada.") e fechar, sem perguntar a forma de pagamento.
Resultado Obtido: A condição if (itensComprados.Count == 0) foi acionada com sucesso, imprimindo a mensagem e executando o return, encerrando o programa sem erros. Sucesso.
