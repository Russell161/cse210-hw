using System;

class Program
{
    static void Main()
    {
        Library library = new Library();
        Report report = new Report();

        library.AddBook(new FictionBook("1984", "George Orwell"));
        library.AddBook(new NonFictionBook("Sapiens", "Yuval Harari"));

        library.RegisterPatron(new Patron("Alice", 1));
        library.RegisterPatron(new Patron("Bob", 2));

        while (true)
        {
            Console.WriteLine("\nLibrary Menu:");
            Console.WriteLine("1. Borrow Book");
            Console.WriteLine("2. Return Book");
            Console.WriteLine("3. View Reports");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Enter Book Title: ");
                    string borrowTitle = Console.ReadLine();
                    Console.Write("Enter Patron ID: ");
                    int borrowId = int.Parse(Console.ReadLine());
                    new BorrowTransaction(borrowTitle, borrowId).Execute(library);
                    break;

                case "2":
                    Console.Write("Enter Book Title: ");
                    string returnTitle = Console.ReadLine();
                    Console.Write("Enter Patron ID: ");
                    int returnId = int.Parse(Console.ReadLine());
                    new ReturnTransaction(returnTitle, returnId).Execute(library);
                    break;

                case "3":
                    Console.WriteLine("\nReports:");
                    Console.WriteLine("1. Borrowed Books");
                    Console.WriteLine("2. Patron Info");
                    Console.WriteLine("3. Genre Summary");
                    Console.Write("Choose report: ");
                    string reportChoice = Console.ReadLine();

                    if (reportChoice == "1") report.DisplayBorrowedBooks(library);
                    else if (reportChoice == "2") report.DisplayPatronInfo(library);
                    else if (reportChoice == "3") report.DisplayGenreSummary(library);
                    break;

                case "4":
                    Console.WriteLine("Exiting.");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
