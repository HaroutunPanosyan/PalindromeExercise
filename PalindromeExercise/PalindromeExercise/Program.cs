using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main()
        {
            Palandrome bestPal = new Palandrome();
            Console.WriteLine("What word would you like to test to see if it is a palandrome?");
            string input = Console.ReadLine();
            string reversal = bestPal.Reverse(input);
            bool thisTest = bestPal.Check(input);
            Console.WriteLine();
            Console.WriteLine($"{input} reversed is: \n{reversal}");
            Console.WriteLine();
            Console.WriteLine("Is this a palandrome?");
            if (thisTest)
            {
                Console.WriteLine("Yes. It is a palandrome.");
            }
            else 
            {
                Console.WriteLine("No. It isn't a palandrome.");
            }
        }
    }
}
