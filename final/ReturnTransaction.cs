class ReturnTransaction : Transaction
{
    private int daysLate;

    public ReturnTransaction(Book book, Patron patron, int daysLate) : base(book, patron)
    {
        this.daysLate = daysLate;
    }

    public override void Execute()
    {
        if (patron.ReturnBook(book))
            Console.WriteLine($"Book returned. Late fee: ${CalculateLateFee()}");
        else
            Console.WriteLine("Book was not borrowed by this patron.");
    }

    public double CalculateLateFee()
    {
        return daysLate * 0.5; // $0.50 per day late
    }
}
