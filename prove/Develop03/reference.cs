public class ScriptureReference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int EndVerse { get; private set; }

    public ScriptureReference(string book, int chapter, int startVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = startVerse;
    }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (StartVerse == EndVerse)
        {
            return $"{Book} {Chapter}:{StartVerse}";
        }
        else
        {
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
    }
}
