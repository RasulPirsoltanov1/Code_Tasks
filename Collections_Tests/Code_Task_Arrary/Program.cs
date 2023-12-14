namespace Code_Task_Arrary
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            string[] cars = { "bmw", "merse3des", "lada" };
            int rnd = new Random().Next(0, cars.Length - 1);
            Console.WriteLine(cars[rnd]);
        }
        static void Main(string[] args)
        {
            List<string> cities = new List<string>() { "Ankara", "İstanbul" };
            cities.Add("Bursa");
            cities.Add("İzmir");
            cities.Add("Antalya");
            cities.Add("Adana");
            cities.Add("Trabzon");
            cities.Add("Samsun");
            cities.Add("Konya");
            cities.Add("Kayseri");
            cities.Add("Kocaeli");
            cities.Add("Diyarbakır");
            cities.Add("Gaziantep");
            cities.Add("Şanlıurfa");
            cities.Add("Mersin");
            cities.Add("Malatya");
            cities.Add("Kahramanmaraş");
            cities.Add("Erzurum");
            cities.Add("Eskişehir");
            foreach (var city in cities.Select((value, i) => new { i, value }))
            {
                Console.WriteLine($"index no => {city.i}  : "+city.value);
            }

        }

    }
}