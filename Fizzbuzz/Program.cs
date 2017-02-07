using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type how many numbers you want:");
            int printCount = int.Parse(Console.ReadLine());
            Console.Write("\n");

            for (int i = 1; i <= printCount; i++)
            {
                string textToDisplay = $"{i} ";
                if (i % 3 == 0)
                {
                    textToDisplay += "fizz";
                }
                if (i % 5 == 0)
                {
                    textToDisplay += "buzz";
                }
                Console.Write(textToDisplay += "\n");
            }
            Console.ReadKey();
        }
    }
}
