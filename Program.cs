using System;
using System.Collections.Generic;

class Storage
{

    public static List<string> itens = new List<string>();

    public static void Main()
    {
        Storage controle = new Storage();

        bool looping = true;

        while (looping == true)
        {
            try
            {
                Storage.ShowMenu();
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("\nVoce escolheu adicionar um item!");
                    Console.WriteLine("Digite o item que quer adicionar:\n");
                    Storage.AddItem();

                }
                else if (option == 2)
                {
                    Console.WriteLine("\nVoce escolheu remover um item!");
                    Console.WriteLine("Digite o item que quer remover:\n");
                    Storage.RemoveItem();

                }
                else if (option == 3)
                {

                    Console.WriteLine("\nVoce escolheu listar todos os itens atuais!\n");
                    Storage.ShowItens();
                    Console.WriteLine("\nItens Listados \n");

                }
                else if (option == 4)
                {
                    Console.WriteLine("\nSaindo do programa...");
                    looping = false;


                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Você precisa digitar um número válido.");
            }

        }



    }

    public static void ShowMenu()
    {
        Console.WriteLine("1 - Adicionar item");
        Console.WriteLine("2 - Remover item");
        Console.WriteLine("3 - Listar itens");
        Console.WriteLine("4 - Sair");
        Console.WriteLine("Escolha uma opção:");


    }
    public static void AddItem()
    {
        
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
    public static void RemoveItem()
    {
       
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
    public static void ShowItens()
    {
        foreach (var item in itens)
        {
            Console.WriteLine(item);
        }
    }

}




