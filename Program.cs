using System;
using System.Linq;
using Contact_list.UI;
using System.Diagnostics;
using Contact_list.OnContact;

namespace Contact_list;

public static class Program
{
    public static void Main()
    {
        //Class
        var controller = new ControllerContact();

        ConsoleUI.Menu();
        byte option = 7;

        while (option != 0)
        {
            Console.Clear();
            ConsoleUI.Menu();

            option = byte.Parse(Console.ReadLine());
            switch (option)
            {
                //Adicionar contatos
                case 1:

                    Console.Clear();
                    ConsoleUI.Head();

                    Console.Write("Nome: ");
                    string name = Console.ReadLine();

                    Console.Write("Numero de telefone: ");
                    string phone = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    try
                    {
                        var contact = new Contact(new Name(name), new Phone(phone), new Email(email));
                        controller.AddContact(contact);

                        Console.WriteLine("===================================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(contact);

                        Console.ResetColor();
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro: {e}");
                        Console.ReadLine();
                    }

                    break;

                //Editar contatos
                case 2:
                    Console.Clear();
                    ConsoleUI.Head();

                    Console.Write("Nome: ");
                    string keyName = Console.ReadLine();

                    try
                    {
                        var contact = controller.GetContact(keyName);
                        if (contact == null) throw new Exception($"Cotanto {keyName} não foi encontrado!");

                        Console.Clear();
                        ConsoleUI.Head();

                        Console.WriteLine($"[DADOS ATUAIS]\n");
                        Console.WriteLine(contact);
                        Console.WriteLine("===================================");

                        Console.Write("Novo nome: ");
                        string newName = Console.ReadLine();

                        Console.Write("Novo número: ");
                        string newPhone = Console.ReadLine();

                        Console.Write("Novo email: ");
                        string newEmail = Console.ReadLine();

                        controller.EditContact(keyName, newName, newPhone, newEmail);

                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro: {e}");
                        Console.ReadLine();
                    }

                    break;

                //Remover contatos
                case 3:
                    Console.Clear();
                    ConsoleUI.Head();

                    Console.Write("Nome: ");
                    string keyRemove = Console.ReadLine();

                    try
                    {
                        bool sucess = controller.RemoveContact(keyRemove);

                        if (!sucess) throw new Exception($"Cotanto {keyRemove} não foi encontrado!");
                        Console.WriteLine($"Contato {keyRemove} removido!");

                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro: {e}");
                        Console.ReadLine();
                    }

                    break;

                //Listar todos os contatos
                case 4:

                    Console.Clear();
                    ConsoleUI.Head();

                    foreach (var item in controller.ListContact())
                    {
                        Console.WriteLine(item.ToString());
                        Console.WriteLine("===================================");
                    }

                    Console.ReadLine();

                    break;

                //Buscar contato por nome
                case 5:

                    Console.Clear();
                    ConsoleUI.Head();

                    Console.Write("Nome: ");
                    string key = Console.ReadLine();

                    Console.WriteLine("===================================");

                    try
                    {
                        var contactGet = controller.GetContact(key);
                        Console.WriteLine(contactGet);

                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro: {e}");
                        Console.ReadLine();
                    }

                    break;

                //Salvar contatos
                case 6:

                    Console.Clear();
                    ConsoleUI.Head();

                    Console.Write("Digite um nome para identificar o save: ");
                    string keyTable = Console.ReadLine();

                    try
                    {
                        bool isSaveSucess = controller.SaveContacts(keyTable);

                        if (!isSaveSucess) throw new Exception("Erro ao salvar os dados!");

                        Console.WriteLine("Sucesso!");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro: {e}");
                        Console.ReadLine();
                    }

                    break;

                case 0:
                    break;
                    break;
            }
        }
    }
}
