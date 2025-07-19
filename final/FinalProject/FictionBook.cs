public class FictionBook : Book
{
    public FictionBook(string title, string author) : base(title, author) { }

    public override string GetGenre() => "Fiction";
}
