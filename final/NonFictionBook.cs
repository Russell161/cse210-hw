class NonFictionBook : Book
{
    private string subjectArea;

    public NonFictionBook(int id, string title, string author, string genre, string subjectArea)
        : base(id, title, author, genre)
    {
        this.subjectArea = subjectArea;
    }

    public override string ToString() => base.ToString() + $" (Non-Fiction: {subjectArea})";
}
