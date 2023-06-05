using System.Linq.Expressions;

namespace _12._If_Statements
{
    internal class IfStatement
    {
        static void Main(string[] args)
        {
            if (/* Condition */)
            {
                // Code to be executed if the condition is met.
            }

            // if:

            int number = 15;

            if (number > 10)
            {
                Console.WriteLine($"\n\t{number} is greater than 10.");
            }


            // if/else:

            if (number > 0)
            {
                Console.WriteLine($"\n\t{number} is greater than 10.");
            }
            else
            {
                Console.WriteLine($"\n\t{number} is greater than 10.");
            }


            // if/else if/else:

            int score = 85;

            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }
    }
}