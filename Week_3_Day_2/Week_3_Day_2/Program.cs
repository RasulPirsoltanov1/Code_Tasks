namespace Week_3_Day_2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            double _cem;
            double _hasil;
            double _bolme;
            double _cixma;

            void Hesabla(out double cem, out double hasil, out double cixma, out double bolme, double num1, double num2)
            {
                cem = num1 + num2;
                hasil = num2 * num1;
                cixma = num2 - num2;
                bolme = num2 / num1;
            }

            Hesabla(out _cem, out _hasil, out _cixma, out _bolme, 2, 3);
            System.Console.WriteLine(_cem + " " + _hasil);
        }
        static void Main2(string[] args)
        {
            void Hesabla(out double cem, params double[] doubles)
            {
                cem = doubles.Sum();
            }
            Hesabla(out double x, 12, 32, 4345, 6, 345, 453, 12);
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            x:
            if(long.TryParse(Console.ReadLine(),out long phnmp))
            {
                Console.WriteLine(phnmp);
            }
            else
            {
                Console.WriteLine("again ");
                goto x;
            }
        }
    }
}