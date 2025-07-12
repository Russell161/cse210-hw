class FictionBook : Book
{
    private string subGenre;

    public FictionBook(int id, string title, string author, string genre, string subGenre)
        : base(id, title, author, genre)
    {
        this.subGenre = subGenre;
    }

    public override string ToString() => base.ToString() + $" (Fiction: {subGenre})";
}
