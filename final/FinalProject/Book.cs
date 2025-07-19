public abstract class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public bool IsAvailable { get; private set; } = true;
    public Patron CurrentHolder { get; private set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void Borrow(Patron patron)
    {
        IsAvailable = false;
        CurrentHolder = patron;
    }

    public void Return()
    {
        IsAvailable = true;
        CurrentHolder = null;
    }

    public abstract string GetGenre();
}
