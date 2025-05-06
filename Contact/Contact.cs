using System;
using System.Linq;
using System.Collections.Generic;
using Contact_list.OnContact;

namespace Contact_list.OnContact;

public class Contact
{
    public Name name { get; private set; }
    public Phone phone { get; private set; }
    public Email email { get; private set; }

    public Contact(Name name, Phone phone, Email email)
    {
        this.name = name;
        this.phone = phone;
        this.email = email;
    }

    public override string ToString() => $"Name: {name.GetName()}\nPhone: {phone.GetPhone()}\nEmail: {email.GetEmail()}";
}
