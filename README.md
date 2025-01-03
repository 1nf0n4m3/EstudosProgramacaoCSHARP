# Controle de Estoque

Este projeto é uma aplicação simples de controle de estoque desenvolvida em C#. Ele permite adicionar, remover e listar itens armazenados em um inventário. O objetivo principal é servir como uma introdução prática ao uso de coleções e manipulação de dados em C#.

## Funcionalidades

- **Adicionar itens ao estoque**
- **Remover itens do estoque**
- **Listar todos os itens no estoque**
- **Sair do programa**

## Como utilizar

1. Compile e execute o programa no Visual Studio ou em outro ambiente compatível com C#.
2. O menu principal será exibido com as seguintes opções:
   - `1` - Adicionar item
   - `2` - Remover item
   - `3` - Listar itens
   - `4` - Sair
3. Escolha uma das opções digitando o número correspondente e pressione Enter.
4. Siga as instruções exibidas para cada funcionalidade.

## Estrutura do Código

### Classes

- **`ControlEstoque`**: Classe principal que contém a lógica do programa.

### Métodos

- **`ExibirMenu`**: Exibe o menu principal com as opções disponíveis.
- **`AdicionarItem`**: Permite adicionar um novo item ao estoque. Verifica se a entrada não está vazia.
- **`RemoverItem`**: Remove um item do estoque com base no nome. Exibe uma mensagem caso o item não exista.
- **`MostrarItens`**: Lista todos os itens atualmente armazenados no estoque.

## Observações

- O programa utiliza uma lista genérica (`List<string>`) para armazenar os itens do estoque.
- O tratamento de erros simples é implementado para lidar com entradas inválidas no menu.
- O método `Remove` verifica a existência do item antes de tentar removê-lo.

## Requisitos

- **.NET Framework** ou **.NET Core**
- Ambiente de desenvolvimento compatível com C#, como Visual Studio ou Visual Studio Code.

## Melhorias Futuras

- Implementar persistência de dados usando um arquivo ou banco de dados.
- Adicionar validações mais robustas para entradas do usuário.
- Implementar uma interface gráfica para melhorar a usabilidade.
- Permitir busca de itens específicos no estoque.

---

**Autor:** [Cassio Marques Reigotto]  
**Data:** Janeiro de 2025  
