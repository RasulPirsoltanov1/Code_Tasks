using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Diagnostics;
using System.Text;

namespace week_2_day_5_Strings
{
    internal class Program
    {
        static void Main(string[] a)
        {
            string triangle = "";

            for (int i = 0; i <= 8; i++)
            {
                triangle+=triangle.PadRight(i , '*');
            }

            Console.WriteLine(triangle);
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i <= 8; i++)
            {
                if(i == 0 ||i==8)
                {
                   
                }
                else
                {
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*      *");
                    }
                }
              
                Console.WriteLine();
            }


        }
        static void Main7(string[] a)
        {
            for (int i = 'A'; i <='z'; i++)
            {
                Console.WriteLine((char)(i));
            }
        }
        static void Main1(string[] args)
        {
            string text = "/.,f435fd;lskj--kewagfna;hfggdas./,+9*";
            string x = text.Replace('.', ' ');
            if (text.Contains(',') || text.Contains('*') || text.Contains('/'))
            {
                x = text.Replace(',', ' ').Replace('*', ' ').Replace('/', ' ').Replace('-', ' ');
                x = String.Join(" ", x.Split(" ", StringSplitOptions.RemoveEmptyEntries));
            }
            Console.WriteLine(x);
        }
        static void Main2(string[] args)
        {
            string text = "/.,f435fd;lskj--kewagfna;hfggdas./,+9*";
            string x = String.Join(" ", text.Split(new char[] { '.', '*' }, StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine(x);
        }
        static void Main3(string[] args)
        {
            int first = 0;
            string name = string.Empty;
            string surname = string.Empty;
            string email = string.Empty;
            string ext = string.Empty;
            int sedcond = 0;
            int ate = 0;
            string tre = new string('-', 40);
            string[] emails = { "test.testov@gmail.com", "test.testovasdasd@gmail.com" };

            for (int i = 0; i < emails.Length; i++)
            {
                
                first = emails[i].IndexOf('.');
                name = emails[i].Substring(0, first);
                sedcond = emails[i].LastIndexOf('.');
                ate = emails[i].IndexOf('@');
                surname = emails[i].Substring(first + 1, ate - 5);
                email = emails[i];
                ext = emails[i].Substring(sedcond);
                string rslt = $"" +
                    "\n" + $"{tre}" + "\n" +
             $"Name : " + $"{name}" + "\n" +
             $"Surname : " + $"{surname}" + "\n" +
             $"email : " + $"{email}" + "\n" +
             $"extension : " + $"{ext}" +
             "\n" + $"{tre}" + "\n";
                Console.WriteLine(rslt);
            }
        }
        static void Main5()
        {
            // Using the iterator
            foreach (int number in GenerateNumbers())
            {
                Console.WriteLine(number);
            }
        }

        // Iterator block using 'yield'
        static IEnumerable<int> GenerateNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                // 'yield return' produces the next element in the sequence
                yield return i;
            }
        }
        static void Mainewq()
        {
            BenchmarkRunner.Run<String_Vs_StringBuilder>();
            String_Vs_StringBuilder stringBuilder = new String_Vs_StringBuilder();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stringBuilder.StringTest();
            stopwatch.Stop();

            Console.WriteLine("StringTest : "+ stopwatch.ElapsedMilliseconds);

            Stopwatch stopwatch2 = new Stopwatch();

            stopwatch2.Start();
            stringBuilder.StringBuilderTest();
            stopwatch2.Stop();

            Console.WriteLine("StringBuilderTest : " + stopwatch2.ElapsedMilliseconds);

        }
    }
  
    public class String_Vs_StringBuilder
    {
        private const int _numIteration = 100000;
        [Benchmark]
       public  void StringTest()
        {
            string txt = "";
            for (int i = 0; i < 100000; i++)
            {
                txt += "a";
            }

        }

        [Benchmark]
      public   void StringBuilderTest()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                stringBuilder.Append("a");
            }
        }
    }
   
}