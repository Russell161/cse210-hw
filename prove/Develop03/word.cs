public class Word
{
    public string Text { get; private set; }
    public bool Hidden { get; set; }

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }

    public override string ToString()
    {
        if (Hidden)
        {
            return "[Hidden]";
        }
        else
        {
            return Text;
        }
    }
}
