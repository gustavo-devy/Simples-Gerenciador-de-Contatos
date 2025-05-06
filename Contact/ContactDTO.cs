using System;
using System.Linq;
using System.Collections.Generic;

namespace Contact_list.OnContact;

public class ContactDTO
{
    public string name { get; set; }
    public string phone { get; set; }
    public string email { get; set; }

    public ContactDTO(Contact contact)
    {
        name = contact.name.GetName();
        phone = contact.phone.GetPhone();
        email = contact.email.GetEmail();
    }
}
