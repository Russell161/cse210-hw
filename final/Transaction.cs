using System;

class Transaction
{
    protected Book book;
    protected Patron patron;
    protected DateTime date;

    public Transaction(Book book, Patron patron)
    {
        this.book = book;
        this.patron = patron;
        this.date = DateTime.Now;
    }

    public virtual void Execute() { }
}
