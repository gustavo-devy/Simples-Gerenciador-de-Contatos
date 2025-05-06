using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;

namespace Contact_list.OnContact;

public class ControllerContact : DataBase
{
    //Adicionar contatos
    public bool AddContact(Contact contact)
    {
        contacts.Add(contact);

        if (!contacts.Contains(contact)) return false;
        return true;
    }

    //Editar contatdo
    public void EditContact(string key, string name, string phone, string email)
    {
        foreach (var item in contacts)
        {
            if (item.name.GetName() == key)
            {
                item.name.SetName(name);
                item.phone.SetPhone(phone);
                item.email.SetEmail(email);
                break;
            }
        }
    }

    //Obter um contato
    public Contact GetContact(string name)
    {
        foreach (var item in contacts)
        {
            if (item.name.GetName() == name)
            {
                return item;
                break;
            }

        }

        throw new Exception($"Erro: contato {name} não foi encontrado!");
        return null;
    }

    //Remover contato
    public bool RemoveContact(string name)
    {
        foreach (var item in contacts)
        {
            if (item.name.GetName() == name)
            {
                contacts.Remove(item);
                return true;
            }
        }

        return false;
    }

    //Listar contatos
    public List<Contact> ListContact() => contacts;

    //Salvar contatos
    public bool SaveContacts(string nameTable)
    {
        if (!File.Exists(nameTable + ".json"))
        {
            var dto = ConvertContact();
            File.Create($"Data/{nameTable}.json").Dispose();

            var json = JsonSerializer.Serialize<List<ContactDTO>>(dto);
            File.WriteAllText($"Data/{nameTable}.json", json.ToString());

            return true;
        }
        else
        {
            var dto = ConvertContact();

            var json = JsonSerializer.Serialize<List<ContactDTO>>(dto);
            File.WriteAllText($"Data/{nameTable}.json", json.ToString());

            return true;
        }

        return false;
    }

    public List<ContactDTO> ConvertContact()
    {
        var contactDTO = new List<ContactDTO>();
        foreach (var item in contacts)
        {
            contactDTO.Add(new ContactDTO(item));
        }

        return contactDTO;
    }
}
