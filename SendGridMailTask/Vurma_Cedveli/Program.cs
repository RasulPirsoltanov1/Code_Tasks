namespace Vurma_Cedveli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                Vurma Cedveli\n");
            int length = 10;

            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j < length; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + i * j);
                }
                if (i != length)
                    Console.WriteLine("\n------------------------\n");
            }
        }

    }
}