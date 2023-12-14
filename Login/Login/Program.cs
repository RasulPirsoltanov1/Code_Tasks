//Username və password istifadəçidən alınacaq, istifadəçi daxil olana qədər istifadəçi bu prosesi təkrarlayacaq.
//Məlumatları tupple-də saxlayırsız.(string username, string password) user = ("admin", "123");
//Tapşırığın github linkini classroom-a əlavə etdikdən sonra turn in etməyi unutmayın :)


using System.Diagnostics;
using System.Numerics;

namespace Login
{
    internal class Program
    {
        private static (string username, string password) user = ("admin", "123");
        static void Main(string[] args)
        {
            string username = string.Empty;
            string password = string.Empty;
            bool isAuthenticated = false;
            Console.WriteLine("Welcome to login console ");
            while (!isAuthenticated)
            {
                Console.Write("Username: ");
                username = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
                Console.WriteLine("Working....");
                var afterOneMinute = DateTime.UtcNow.AddSeconds(1);
                while (DateTime.UtcNow < afterOneMinute)
                {
                    new ConsoleSpiner().Turn();
                }
                if (username == user.username && password == user.password)
                {

                    isAuthenticated = true;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Successfully authenticated");
                    Console.ResetColor();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n---------------------------------------------------");
                    Console.WriteLine("username or passwor is incorrect! please try again.\n");
                    Console.ResetColor();
                }
            }
        }

        public class ConsoleSpiner
        {
            int counter;
            public ConsoleSpiner()
            {
                counter = 0;
            }
            public void Turn()
            {
                counter++;
                switch (counter % 4)
                {
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
    }
}