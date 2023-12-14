//Username və password istifadəçidən alınacaq, istifadəçi daxil olana qədər istifadəçi bu prosesi təkrarlayacaq.
//Məlumatları tupple-də saxlayırsız.(string username, string password) user = ("admin", "123");
//Tapşırığın github linkini classroom-a əlavə etdikdən sonra turn in etməyi unutmayın :)

namespace Login
{
    internal partial class Program
    {
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