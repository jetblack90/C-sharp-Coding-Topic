namespace _23._String_Interpolation
{
    internal class StringInterpolation
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 25;

            string message = $"My name is {name} and I am {age} years old.";
            Console.WriteLine(message);
        }
    }
}