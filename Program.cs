using System;
using System.Collections.Generic;

class ControlEstoque
{

    public static List<string> itens = new List<string>();

    public static void Main()
    {
        ControlEstoque controle = new ControlEstoque();

        bool continuar = true;

        while (continuar == true)
        {
            try
            {
                ControlEstoque.ExibirMenu();
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    ControlEstoque.AdicionarItem();

                }
                else if (opcao == 2)
                {
                    ControlEstoque.RemoverItem();

                }
                else if (opcao == 3)
                {

                    Console.WriteLine("\nVoce escolheu listar todos os itens atuais!\n");
                    ControlEstoque.MostrarItens();
                    Console.WriteLine("\nItens Listados \n");

                }
                else if (opcao == 4)
                {
                    Console.WriteLine("\nSaindo do programa...");
                    continuar = false;


                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Você precisa digitar um número válido.");
            }

        }



    }

    public static void ExibirMenu()
    {
        Console.WriteLine("1 - Adicionar item");
        Console.WriteLine("2 - Remover item");
        Console.WriteLine("3 - Listar itens");
        Console.WriteLine("4 - Sair");
        Console.WriteLine("Escolha uma opção:");


    }
    public static void AdicionarItem()
    {
        Console.WriteLine("\nVoce escolheu adicionar um item!");
        Console.WriteLine("Digite o item que quer adicionar:\n");
        string itemAdd = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(itemAdd))
        {
            Console.WriteLine("Digite algum tipo de valor...");
        }
        else
        {
            
            itens.Add(itemAdd);
            Console.WriteLine("\nItem {0} adicionado com sucesso.\n", itemAdd);
        }
        


    }
    public static void RemoverItem()
    {
        Console.WriteLine("\nVoce escolheu remover um item!");
        Console.WriteLine("Digite o item que quer remover:\n");
        string itemRemove = Console.ReadLine();
        if (itens.Remove(itemRemove))
        {
            itens.Remove(itemRemove);
            Console.WriteLine("\nItem {0} Removido com sucesso.\n", itemRemove);
        }
        else
        {
            Console.WriteLine("Digite um item existente");
        }

    }
    public static void MostrarItens()
    {
        foreach (var item in itens)
        {
            Console.WriteLine(item);
        }
    }

}




