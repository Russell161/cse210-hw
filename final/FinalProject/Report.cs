using System;
using System.Linq;

public class Report
{
    public void DisplayBorrowedBooks(Library library)
    {
        Console.WriteLine("Borrowed Books:");
        foreach (var book in library.GetAllBooks().Where(b => !b.IsAvailable))
        {
            Console.WriteLine($"- {book.Title} (by {book.Author}) borrowed by {book.CurrentHolder.Name}");
        }
    }

    public void DisplayPatronInfo(Library library)
    {
        foreach (var patron in library.GetAllPatrons())
        {
            Console.WriteLine(patron.GetInfo());
        }
    }

    public void DisplayGenreSummary(Library library)
    {
        var books = library.GetAllBooks();
        var fictionCount = books.Count(b => b.GetGenre() == "Fiction");
        var nonFictionCount = books.Count(b => b.GetGenre() == "Non-Fiction");

        Console.WriteLine($"Fiction: {fictionCount}");
        Console.WriteLine($"Non-Fiction: {nonFictionCount}");
    }
}
