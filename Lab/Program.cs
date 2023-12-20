namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Library library = new Library();
            library.AddBook(new Book
            {
                Name = "Test",
                AuthorName = "Test",
                Code = 1231,
                PageCount = 1,
                Price = 123.43
            });

            library.AddBook(new Book
            {
                Name = "Test",
                AuthorName = "Test",
                Code = 1231,
                PageCount = 1,
                Price = 123.43
            });
            library.AddBook(new Book
            {
                Name = "Test",
                AuthorName = "Test",
                Code = 1231,
                PageCount = 1,
                Price = 123.43
            });


            library.AddBook(new Book
            {
                Name = "Test",
                AuthorName = "Test",
                Code = 1231,
                PageCount = 1,
                Price = 123.43
            });
            library.AddBooks();
            library.getBook();
            library.FindBook("Test");
        }
    }
}