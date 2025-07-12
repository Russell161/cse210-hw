class Patron
{
    private int id;
    private string name;
    private string email;
    private List<Book> borrowedBooks = new List<Book>();

    public Patron(int id, string name, string email)
    {
        this.id = id;
        this.name = name;
        this.email = email;
    }

    public int GetId() => id;

    public bool BorrowBook(Book book)
    {
        if (book.IsAvailable())
        {
            book.Borrow();
            borrowedBooks.Add(book);
            return true;
        }
        return false;
    }

    public bool ReturnBook(Book book)
    {
        if (borrowedBooks.Contains(book))
        {
            book.Return();
            borrowedBooks.Remove(book);
            return true;
        }
        return false;
    }

    public List<Book> GetBorrowedBooks() => borrowedBooks;
}
