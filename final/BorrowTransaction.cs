class BorrowTransaction : Transaction
{
    public BorrowTransaction(Book book, Patron patron) : base(book, patron) { }

    public override void Execute()
    {
        if (patron.BorrowBook(book))
            Console.WriteLine("Book borrowed successfully.");
        else
            Console.WriteLine("Book is not available.");
    }
}
