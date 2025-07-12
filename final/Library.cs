class Library
{
    private List<Book> books = new List<Book>();
    private List<Patron> patrons = new List<Patron>();
    private int nextPatronId = 1;

    public void SeedDemoData()
    {
        books.Add(new FictionBook(1, "The Hobbit", "J.R.R. Tolkien", "Fantasy", "Adventure"));
        books.Add(new NonFictionBook(2, "Sapiens", "Yuval Noah Harari", "History", "Anthropology"));
    }

    public void AddBook(Book book) => books.Add(book);

    public void RegisterPatron(Patron patron)
    {
        patrons.Add(patron);
    }

    public Book FindBookByTitle(string title)
    {
        return books.Find(b => b.GetTitle().ToLower() == title.ToLower());
    }

    public Patron FindPatronById(int id)
    {
        return patrons.Find(p => p.GetId() == id);
    }

    public List<Book> ListAvailableBooks()
    {
        return books.FindAll(b => b.IsAvailable());
    }

    public int GetNextPatronId() => nextPatronId++;
}
