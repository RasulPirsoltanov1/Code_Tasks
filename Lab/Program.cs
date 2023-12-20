namespace Lab
{
    internal class Program
    {
        private static Order _order = new Order();
        private static Library library = new Library();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

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
            Console.WriteLine("All Books");
            library.getBook();
            bool chck = true;

            do
            {
                Console.Write($@"
                
                1-Add to basket
                2-get basket books
                3-get All books
                4-clear

ENTER : 
");
                int process = int.Parse(Console.ReadLine());

                switch (process)
                {
                    case 1:
                        Console.WriteLine("ENTER NAME OF BOOK : ");
                        var book = library.FindBook(Console.ReadLine());
                        _order.AddToBasket(book);
                        break;
                    case 2:
                        Console.WriteLine("Basket : ");
                        _order.Show();
                        break;
                    case 3:
                        Console.WriteLine("All Books : ");
                        library.getBook();
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    default:
                        chck = false;
                        break;
                }
            }
            while (chck);
        }
    }
}