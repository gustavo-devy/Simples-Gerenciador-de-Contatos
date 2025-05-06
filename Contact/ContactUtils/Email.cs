using System;
using System.Linq;
using System.Collections.Generic;

namespace Contact_list.OnContact;

public record Email
{
    private readonly Standards _standards = new Standards();
    private string _email;

    public Email(string email)
    {
        bool isEmail;
        string isEmailSucess = _standards.IsEmail(email, out isEmail);

        if (!isEmail) throw new Exception("Email inválido!");
        _email = email;
    }

    public string GetEmail() => _email;
    public void SetEmail(string phone) => _email = _email;
}
