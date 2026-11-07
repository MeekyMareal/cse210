using System;
using Journal;

public class PromptGenerator
{


    public string _prompt1 = "";
    public string _prompt2 = "";
    public string _prompt3 = "";
    public string _prompt4 = "";
    public string _prompt5 = "";


    public string GetGeneratedPrompt()
    {
        Random random = new Random();

        Journal.Journal jnl = new Journal.Journal();
        Entry ent = new Entry();


        string generatedPrompt = new[] { _prompt1, _prompt2, _prompt3, _prompt4, _prompt5 }[random.Next(5)];
        Console.Write($"{generatedPrompt}");
        return generatedPrompt;

    }
}