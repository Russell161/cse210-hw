using System.Collections.Generic;

public class Patron
{
    public string Name { get; private set; }
    public int ID { get; private set; }
    private List<Book> borrowedBooks = new List<Book>();

    public Patron(string name, int id)
    {
        Name = name;
        ID = id;
    }

    public void BorrowBook(Book book)
    {
        borrowedBooks.Add(book);
    }

    public void ReturnBook(Book book)
    {
        borrowedBooks.Remove(book);
    }

    public List<Book> GetBorrowedBooks() => borrowedBooks;

    public string GetInfo()
    {
        string info = $"Patron ID: {ID}, Name: {Name}, Books Borrowed: {borrowedBooks.Count}";
        foreach (var book in borrowedBooks)
        {
            info += $"\n  - {book.Title} by {book.Author}";
        }
        return info;
    }
}
