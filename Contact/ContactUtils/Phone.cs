using System;
using System.Linq;
using System.Collections.Generic;

namespace Contact_list.OnContact;

public record Phone
{
    private readonly Standards _standards = new Standards();
    private string _phone;

    public Phone(string phone)
    {
        bool isPhone;
        string isPhoneSucess = _standards.IsPhoneNumber(phone, out isPhone);

        if (!isPhone) throw new Exception("Número de telefone inválido!");
        _phone = phone;
    }

    public string GetPhone() => _phone;
    public void SetPhone(string phone) => _phone = phone;
}
