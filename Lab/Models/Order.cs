namespace Lab.Models
{
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
                Console.WriteLine(item.Name + " : " + item.Price + "AZN");
            }
            Console.WriteLine("Total : " + TotalPrice);
        }
    }
}
