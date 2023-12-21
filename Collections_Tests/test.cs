
using System;

namespace C__Learning   // Here Input Your Folder Name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Random
            //Change the color of Text
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "C#Learning";
            Console.WindowHeight = 40;
			//Creating Var for input
            Double num01;
            Double num02;
			//Writing a line in terminal saying Input a number:
            Console.Write(" Input a number: ");
			//converting it to a double because its og is a string
            num01 = Convert.ToDouble( Console.ReadLine());
			// gettin a second number
            Console.Write("Input a second number: ");
			//converting it to a double because its og is a string again
            num02 = Convert.ToDouble( Console.ReadLine());
			// multiplying both the numbers
            Double result = num01 * num02;
			//Giving the Result
            Console.WriteLine("The result is " + result);
            
            //Waiting for a key too close the program At the end
            Console.ReadKey();

        }
    }
}
