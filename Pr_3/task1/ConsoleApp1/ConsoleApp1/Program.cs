using System;

class Book
{
    private readonly Title title;
    private readonly Author author;
    private readonly Content content;

    public Book(string title, string author, string content)
    {
        this.title = new Title(title);
        this.author = new Author(author);
        this.content = new Content(content);
    }

    public void SetAuthor(string author)
    {
        this.author.SetContent(author);
    }

    public void SetContent(string content)
    {
        this.content.SetContent(content);
    }

    public void Show()
    {
        title.Show();
        author.Show();
        content.Show();
    }
}

class Title
{
    private readonly string title;

    public Title(string title)
    {
        this.title = title;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Title: {title}");
        Console.ResetColor();
    }
}

class Author
{
    private string author;

    public Author(string author)
    {
        this.author = author;
    }

    public void SetContent(string author)
    {
        this.author = author;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Author: {author}");
        Console.ResetColor();
    }
}

class Content
{
    private string content;

    public Content(string content)
    {
        this.content = content;
    }

    public void SetContent(string content)
    {
        this.content = content;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Content: {content}");
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("C# Programming", "John Doe", "This is the content of the book.");
        book.Show();

        // Редагування автора та змісту
        book.SetAuthor("Jane Smith");
        book.SetContent("This is the new content.");

        // Виведення оновлених даних
        book.Show();

        Console.ReadLine();
    }
}