public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _chapter = chapter;
        _verse = verse;
        _book = book;
        _endVerse = 0;


    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;

    }

    public string GetDisplayText()
    {
        string book = _book;
        int chapter = _chapter;
        int verse =  _verse;
        int endVerse = _endVerse;
        string format1 = $"{book} {chapter}:{verse}";
        string format2 = $"{book} {chapter}:{verse}-{endVerse}";
        if (endVerse == 0)
        {
            return format1;
        } else
        {
            return format2;
        }
    }



}