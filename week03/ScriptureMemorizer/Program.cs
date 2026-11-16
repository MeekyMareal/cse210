// i added different scriptures that is randomly selected from the list

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> list = new List<Scripture>();
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths");
        list.Add(scripture);
        Reference reference2 = new Reference("John", 3, 6);
        Scripture scripture2 = new Scripture(reference2, "That which is born of the flesh is flesh; and that which is born of the Spirit is spirit.");
        list.Add(scripture2);
        
        Reference reference3 = new Reference("Psalm", 118, 24);
        Scripture scripture3 = new Scripture(reference3, "This is the day that the Lord has made; let us rejoice and be glad in it");
        list.Add(scripture3);

        Random random = new Random();
        int i = random.Next(list.Count);
        Scripture generated = list[i];
        string input = "";

        while (input != "quit" && generated.IsCompletelyHidden() == false)
        {
            Console.Clear();
            Console.WriteLine(generated.GetDisplayText() );
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            input = Console.ReadLine();

            if (input != "quit")
            {
                generated.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(generated.GetDisplayText());
        
    }
}