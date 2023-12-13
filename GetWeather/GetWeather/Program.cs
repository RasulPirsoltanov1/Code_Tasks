
using Newtonsoft.Json;

namespace GetWeather
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/current.json?q=53.1%2C-0.13"),
                Headers =
    {
        { "X-RapidAPI-Key", "8a0b4388afmsh7ff887cca690cdep151b55jsnbca9dc528df8" },
        { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(body);
                Console.WriteLine("today weather : " + myDeserializedClass.current.condition.text);
                if (myDeserializedClass.current.temp_c < 0)
                {
                    await Console.Out.WriteLineAsync("yollar buz baglaya biler diqqetli olun");
                }
                else if (myDeserializedClass.current.temp_c > 45)
                {
                    await Console.Out.WriteLineAsync("hava istiliyi heddinde artiq coxdur!");
                }
                else if(myDeserializedClass.current.temp_c > 26 && myDeserializedClass.current.temp_c <40 )
                {
                    await Console.Out.WriteLineAsync("mulayim hava  tempraturu var " + myDeserializedClass.current.temp_c + " C");
                }
                else
                {
                    await Console.Out.WriteLineAsync("hava tempraturu var " + myDeserializedClass.current.temp_c + " C");
                }
            }
        }
    }


    public class Condition
    {
        public string text { get; set; }
        public string icon { get; set; }
        public double code { get; set; }
    }

    public class Current
    {
        public double last_updated_epoch { get; set; }
        public string last_updated { get; set; }
        public double temp_c { get; set; }
        public double temp_f { get; set; }
        public double is_day { get; set; }
        public Condition condition { get; set; }
        public double wind_mph { get; set; }
        public double wind_kph { get; set; }
        public double wind_degree { get; set; }
        public string wind_dir { get; set; }
        public double pressure_mb { get; set; }
        public double pressure_in { get; set; }
        public double precip_mm { get; set; }
        public double precip_in { get; set; }
        public double humidity { get; set; }
        public double cloud { get; set; }
        public double feelslike_c { get; set; }
        public double feelslike_f { get; set; }
        public double vis_km { get; set; }
        public double vis_miles { get; set; }
        public double uv { get; set; }
        public double gust_mph { get; set; }
        public double gust_kph { get; set; }
    }

    public class Location
    {
        public string name { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string tz_id { get; set; }
        public double localtime_epoch { get; set; }
        public string localtime { get; set; }
    }

    public class Root
    {
        public Location location { get; set; }
        public Current current { get; set; }
    }

}