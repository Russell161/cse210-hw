using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private ScriptureReference reference;
    private List<Word> words;

    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(reference.ToString());
        foreach (var word in words)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine("\n\nPress Enter to continue or type 'quit' to exit.");
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(words.Count);
        words[index].Hidden = true;
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.Hidden);
    }
}
