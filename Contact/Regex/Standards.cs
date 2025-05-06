using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Contact_list.OnContact;

public class Standards
{
    private bool isPhone = false;
    private bool isEmail = false;
    private readonly List<Regex> regex = new()
    {
    // Regex para e-mail
    new Regex(@"^[\w\.-]+@[\w\.-]+\.\w{2,}$"),

    // Regex para telefone (formato brasileiro opcional com DDD e hífens)
    new Regex(@"^\x28?\d{2}\x29?\s?\d{4,5}-?\d{4}$")
    };

    //Faz a verificação de número de telefone
    public string IsPhoneNumber(string phone, out bool isPhone)
    {
        var match = regex[1].Match(phone);

        if (match.Success)
        {
            isPhone = true;
            return match.Value;
        }

        isPhone = false;
        return match.Value;
    }

    //Faz a verificação de email
    public string IsEmail(string email, out bool isEmail)
    {
        var match = regex[0].Match(email);

        if (match.Success)
        {
            isEmail = true;
            return match.Value;
        }

        isEmail = false;
        return match.Value;
    }
}
