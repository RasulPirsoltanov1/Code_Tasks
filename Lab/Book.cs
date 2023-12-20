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
                Console.WriteLine("Book with the same name already exists.");
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
                    Price = i,
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
                Console.WriteLine(item.Name);
            }
        }
        public void FindBook(string name)
        {
            Console.WriteLine("finded book :" + Books.FirstOrDefault(x => x.Name == name)?.Name);
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
        public List<Book> Books { get; set; }
        public double TotalPrice
        {
            get => Total; set
            {

            }
        }
        public DateTime OrderDate { get; set; }
    }
}
