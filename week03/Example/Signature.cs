using System;

public class Signature
{
    private string _sign;
    private string _name;

    public Signature(string name)
    {
        _name = name;
        _sign = "Sincerely";
    }

    public string GetSignature()
    {
        return $"{_sign}, {_name}";
    }
}