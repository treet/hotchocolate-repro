namespace hotchocolate_repro;

public class Query1
{
    public Book GetBook() =>
        new Book
        {
            Title = "Schema 1 - a journey into GraphQL",
            Author = new Author
            {
                Name = "Unknown"
            }
        };
}

public class Query2
{
    public Book GetBook() =>
        new Book
        {
            Title = "Schema 2 - another journey into GraphQL",
            Author = new Author
            {
                Name = "Unknown"
            }
        };
}
