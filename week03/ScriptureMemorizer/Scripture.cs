using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string w in words)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int Count = 0;

        while (Count < numberToHide && IsCompletelyHidden() == false)
        {
            int i = random.Next(_words.Count);
            if (_words[i].IsHidden() == false)
            {
                _words[i].Hide();
                Count += 1;
            }
        }
    }

public string GetDisplayText()
    {
        string scriptures = "";
        for (int i = 0; i < _words.Count; i++)
        {
            Word word1 = _words[i];
            scriptures = scriptures + word1.GetDisplayText() + " ";
        }
        scriptures = scriptures.Trim();
        string referenced = _reference.GetDisplayText();
        return $"{referenced} {scriptures}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}