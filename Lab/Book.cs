using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }
        public int Code { get; set; }
    }
    internal class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();

        public void AddBook(Book book)
        {
            if (Books.Any(x => x.Name == book.Name))
            {
                Console.WriteLine("Add book exception  : Book with the same name already exists.");
            }
            else
            {
                Books.Add(book);
            }
        }
        public void AddBooks()
        {
            for (int i = 0; i < 54; i++)
            {
                var book = new Book
                {
                    Price = Random.Shared.Next(1,10)*10,
                    AuthorName = RandomString(5),
                    Name = RandomString(5),
                    Code = i,
                    PageCount = i + 1,
                };
                Books.Add(book);
            }
        }

        public void getBook(int page = 1)
        {
            var books = Books.Skip(5 * (page - 1)).Take(5).ToList();
            foreach (var item in books)
            {
                Console.WriteLine(item.Name + " : " +item.Price+"AZN");
            }
        }
        public Book FindBook(string name)
        {
            try
            {
                var book= Books.FirstOrDefault(x => x.Name == name);
                if(book == null)
                {
                    throw new Exception(" book not found ");
                }
                return book;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public void RemoveAll()
        {
            Books.Clear();
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

    public class Order
    {
        public double Total;
        public int Id { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        public double TotalPrice
        {
            get
            {
                foreach (var item in Books)
                {
                    Total += item.Price;
                }
                return Total;
            }
        }
        public DateTime OrderDate { get; set; }


        public void AddToBasket(Book book)
        {
            Books.Add(book);
        }
        public void Show()
        {
            foreach (var item in Books)
            {
                Console.WriteLine(item.Name + " : "+ item.Price + "AZN");
            }
            Console.WriteLine("Total : " + TotalPrice);
        }
    }
}
