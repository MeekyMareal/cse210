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
        List<string> _prompts = new List<string>();
        _prompts.Add(_prompt1);
        _prompts.Add(_prompt2);
        _prompts.Add(_prompt3);
        _prompts.Add(_prompt4);
        _prompts.Add(_prompt5);

        string generatedPrompt = _prompts[random.Next(_prompts.Count)];
        Console.Write($"{generatedPrompt}");
        return generatedPrompt;
    }
}