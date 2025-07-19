public class ReturnTransaction : Transaction
{
    private string title;
    private int patronId;

    public ReturnTransaction(string title, int patronId)
    {
        this.title = title;
        this.patronId = patronId;
    }

    public override void Execute(Library library)
    {
        Book book = library.FindBookByTitle(title);
        Patron patron = library.FindPatronById(patronId);

        if (book == null || patron == null)
        {
            Console.WriteLine("Book or Patron not found.");
            return;
        }

        if (book.CurrentHolder != patron)
        {
            Console.WriteLine("This book is not checked out by this patron.");
            return;
        }

        book.Return();
        patron.ReturnBook(book);
        Console.WriteLine($"{patron.Name} returned '{book.Title}'.");
    }
}
