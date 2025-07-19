public class BorrowTransaction : Transaction
{
    private string title;
    private int patronId;

    public BorrowTransaction(string title, int patronId)
    {
        this.title = title;
        this.patronId = patronId;
    }

    public override void Execute(Library library)
    {
        Book book = library.FindBookByTitle(title);
        Patron patron = library.FindPatronById(patronId);

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (!book.IsAvailable)
        {
            Console.WriteLine("Book is currently borrowed.");
            return;
        }

        if (patron == null)
        {
            Console.WriteLine("Patron not found.");
            return;
        }

        book.Borrow(patron);
        patron.BorrowBook(book);
        Console.WriteLine($"{patron.Name} successfully borrowed '{book.Title}'.");
    }
}
