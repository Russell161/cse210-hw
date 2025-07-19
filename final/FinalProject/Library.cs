using System.Collections.Generic;
using System.Linq;

public class Library
{
    private List<Book> books = new List<Book>();
    private List<Patron> patrons = new List<Patron>();

    public void AddBook(Book book) => books.Add(book);
    public void RegisterPatron(Patron patron) => patrons.Add(patron);

    public Book FindBookByTitle(string title) =>
        books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

    public Patron FindPatronById(int id) =>
        patrons.FirstOrDefault(p => p.ID == id);

    public List<Book> GetAllBooks() => books;
    public List<Patron> GetAllPatrons() => patrons;
}
