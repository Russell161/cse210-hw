public class NonFictionBook : Book
{
    public NonFictionBook(string title, string author) : base(title, author) { }

    public override string GetGenre() => "Non-Fiction";
}
