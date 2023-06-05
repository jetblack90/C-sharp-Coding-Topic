namespace _14._Logical_Operators
{
    internal class LogicalOperators
    {
        static void Main(string[] args)
        {
            int age = 25;
            bool isStudent = true;

            if (age > 18 && isStudent)
            {
                Console.WriteLine("You are eligible for a student discount!");
            }
            else if (age > 18 || isStudent)
            {
                Console.WriteLine("You qualify for some discount!");
            }
            else
            {
                Console.WriteLine("Regular pricing applies.");
            }
        }
    }
}