using System.Drawing;

namespace Loops_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            //triangle
            Console.WriteLine("\n Triangle \n");
            string fiqure = "";
            for (int i = 0; i < length / 2; i++)
            {
                Console.WriteLine(fiqure.PadLeft(i + 1, '*'));
            }

            //rectangle
            Console.WriteLine("\n Rectangular \n");
            for (int i = 0; i < length / 2; i++)
            {
                if (i == 0 || i == length / 2 - 1)
                {
                    Console.WriteLine(fiqure.PadLeft(length, '*'));
                }
                else
                {
                    Console.WriteLine(fiqure.PadLeft(1, '*') + fiqure.PadRight(length - 2, ' ') + fiqure.PadRight(1, '*'));
                }
            }

            Console.WriteLine("\n Square \n");

            for (int i = 0; i < length / 2; i++)
            {
                Console.WriteLine(fiqure.PadLeft(length, '*'));
            }

        }
    }
}