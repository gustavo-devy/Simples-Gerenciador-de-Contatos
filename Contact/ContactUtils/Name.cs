using System;
using System.Linq;
using System.Collections.Generic;

namespace Contact_list.OnContact;

public record Name
{
    private string _name;

    public Name(string name)
    {
        if (String.IsNullOrWhiteSpace(name)) throw new Exception("Nome inválido!");
        _name = name;
    }

    public string GetName() => _name;
    public void SetName(string name) => _name = name;
}
