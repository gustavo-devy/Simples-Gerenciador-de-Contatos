using System;
using System.Linq;
using System.Collections.Generic;

namespace Contact_list.UI;

public static class ConsoleUI
{
    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("     GERENCIAMENTO DE CONTATOS     ");
        Console.WriteLine("===================================");
        Console.WriteLine(" 1 - Adicionar Contato");
        Console.WriteLine(" 2 - Editar Contatos");
        Console.WriteLine(" 3 - Remover Contato");
        Console.WriteLine(" 4 - Listar Todos os Contatos");
        Console.WriteLine(" 5 - Buscar Contato por Nome");
        Console.WriteLine(" 6 - Salvar Contatos");
        Console.WriteLine(" 0 - Sair");
        Console.WriteLine("===================================");
        Console.Write(" Escolha uma opção: ");
    }

    public static void Head()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("     GERENCIAMENTO DE CONTATOS     ");
        Console.WriteLine("===================================");
    }
}
