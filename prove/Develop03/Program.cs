using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureReference reference = new ScriptureReference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (!scripture.AllWordsHidden())
        {
            scripture.Display();
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit")
            {
                break;
            }
            else if (input == "")
            {
                scripture.HideRandomWord();
            }
        }

        Console.WriteLine("Program ended. Press any key to exit.");
        Console.ReadKey();
    }
}
