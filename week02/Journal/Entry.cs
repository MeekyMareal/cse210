using System;
namespace Journal;
public class Entry
{
    public string _date;
    public string _allGeneratedOutputs;
    public string  _allStoredInputs;

        public void Display()
    {
        Console.WriteLine($"{_date} - {_allGeneratedOutputs}");
        Console.WriteLine($"{_allStoredInputs}");
    }
}