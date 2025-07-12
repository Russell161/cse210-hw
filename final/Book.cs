class Book
{
    private int id;
    private string title;
    private string author;
    private string genre;
    private bool isAvailable = true;

    public Book(int id, string title, string author, string genre)
    {
        this.id = id;
        this.title = title;
        this.author = author;
        this.genre = genre;
    }

    public string GetTitle() => title;

    public void Borrow() => isAvailable = false;

    public void Return() => isAvailable = true;

    public bool IsAvailable() => isAvailable;

    public virtual string ToString() => $"{title} by {author} [{genre}] - {(isAvailable ? "Available" : "Checked out")}";
}
