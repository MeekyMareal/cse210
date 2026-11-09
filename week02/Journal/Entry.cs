using System;
namespace Journal;
public class Entry
{
    public string _date;
    public string _promptText;
    public string  _userResponse;
        public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}");
        Console.WriteLine($"{_userResponse}");
    }
}