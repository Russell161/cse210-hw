using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        library.SeedDemoData();

        Console.WriteLine("Welcome to the Community Library!");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n1. List Available Books");
            Console.WriteLine("2. Register New Patron");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    foreach (var book in library.ListAvailableBooks())
                        Console.WriteLine(book.ToString());
                    break;
                case "2":
                    Console.Write("Enter patron name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter patron email: ");
                    string email = Console.ReadLine();
                    library.RegisterPatron(new Patron(library.GetNextPatronId(), name, email));
                    Console.WriteLine("Patron registered.");
                    break;
                case "3":
                    Console.Write("Enter patron ID: ");
                    int pid = int.Parse(Console.ReadLine());
                    Console.Write("Enter book title: ");
                    string btitle = Console.ReadLine();
                    Patron patron = library.FindPatronById(pid);
                    Book book = library.FindBookByTitle(btitle);
                    if (patron != null && book != null)
                        new BorrowTransaction(book, patron).Execute();
                    else
                        Console.WriteLine("Invalid book or patron.");
                    break;
                case "4":
                    Console.Write("Enter patron ID: ");
                    int rpid = int.Parse(Console.ReadLine());
                    Console.Write("Enter book title: ");
                    string rtitle = Console.ReadLine();
                    Patron rpatron = library.FindPatronById(rpid);
                    Book rbook = library.FindBookByTitle(rtitle);
                    if (rpatron != null && rbook != null)
                        new ReturnTransaction(rbook, rpatron, 0).Execute();
                    else
                        Console.WriteLine("Invalid book or patron.");
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
