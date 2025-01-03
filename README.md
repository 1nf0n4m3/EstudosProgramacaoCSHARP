# Controle de Estoque

Este programa implementa um sistema de controle simples para armazenar, listar, adicionar e remover itens usando listas em C#. O programa apresenta um menu interativo no console que permite ao usuário realizar essas operações de forma eficiente.

## Funcionalidades

1. **Adicionar Item**
   - Permite ao usuário inserir um item na lista.
   - Valida a entrada para garantir que não seja nula ou vazia.

2. **Remover Item**
   - Permite ao usuário remover um item existente na lista.
   - Verifica se o item está presente antes de tentar removê-lo.

3. **Listar Itens**
   - Exibe todos os itens atualmente armazenados na lista.

4. **Sair**
   - Encerra o programa.

## Estrutura do Código

### Classes e Métodos

- **Classe `Storage`**:
  - Contém a lógica principal do programa e a lista de itens.
  
- **Métodos:**
  - `Main`: Ponto de entrada do programa. Gerencia o loop principal e as interações do menu.
  - `ShowMenu`: Exibe as opções do menu ao usuário.
  - `AddItem`: Adiciona um item à lista de itens, verificando se a entrada é válida.
  - `RemoveItem`: Remove um item da lista, garantindo que ele exista antes de removê-lo.
  - `ShowItens`: Lista todos os itens armazenados na lista.

## Requisitos

- .NET Core ou .NET Framework
- Console habilitado para executar programas C#

## Como Usar

1. Compile e execute o programa em um ambiente compatível com C#.
2. Escolha as opções do menu digitando o número correspondente:
   - `1`: Adicionar um item.
   - `2`: Remover um item.
   - `3`: Listar todos os itens.
   - `4`: Sair do programa.
3. Siga as instruções fornecidas no console para interagir com o programa.

## Tratamento de Erros

- O programa lida com entradas inválidas, como caracteres não numéricos ao escolher uma opção do menu.
- Evita a adição de entradas vazias ou nulas na lista.
- Verifica a existência de um item antes de tentar removê-lo.

## Exemplo de Execução

```
1 - Adicionar item
2 - Remover item
3 - Listar itens
4 - Sair
Escolha uma opção:
1
Digite o item que quer adicionar:
Caneta

Item Caneta adicionado com sucesso.

1 - Adicionar item
2 - Remover item
3 - Listar itens
4 - Sair
Escolha uma opção:
3
Caneta

Itens Listados
