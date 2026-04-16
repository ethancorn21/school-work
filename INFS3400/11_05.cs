using System;
using static System.Console;
using System.Globalization;

class BookExceptionDemo
{
    static void Main()
    {
        Book[] books = new Book[5];

        for (int i = 0; i < books.Length; i++)
        {
            Write($"Enter title for book {i + 1}: ");
            string title = ReadLine();
            Write("Enter author: ");
            string author = ReadLine();
            Write("Enter price: $");
            double price = double.Parse(ReadLine());
            Write("Enter number of pages: ");
            int pages = int.Parse(ReadLine());

            try
            {
                books[i] = new Book(title, author, price, pages);
            }
            catch (BookException ex)
            {
                WriteLine(ex.Message);
                price = 0.10 * pages;
                WriteLine("Price corrected to {0}.", price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                books[i] = new Book(title, author, price, pages);
            }

            WriteLine();
        }

        WriteLine("All book records:");
        foreach (Book b in books)
        {
            WriteLine("Title: {0}  Author: {1}  Price: {2}  Pages: {3}",
                b.Title, b.Author, b.Price.ToString("C", CultureInfo.GetCultureInfo("en-US")), b.Pages);
        }
    }
}

class BookException : Exception
{
    public BookException(string title, double price, int pages) :
        base($"For {title}, ratio is invalid.\n...Price is {price.ToString("C", CultureInfo.GetCultureInfo("en-US"))} for {pages} pages.") { }
}

class Book
{
    private string title;
    private string author;
    private double price;
    private int pages;

    public string Title { get { return title; } set { title = value; } }
    public string Author { get { return author; } set { author = value; } }
    public double Price { get { return price; } set { price = value; } }
    public int Pages { get { return pages; } set { pages = value; } }

    public Book(string title, string author, double price, int pages)
    {
        if (price > 0.10 * pages)
            throw new BookException(title, price, pages);
        this.title = title;
        this.author = author;
        this.price = price;
        this.pages = pages;
    }
}
