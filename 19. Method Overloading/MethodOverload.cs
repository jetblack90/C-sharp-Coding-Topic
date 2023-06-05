namespace _19._Method_Overloading
{
    internal class MethodOverload
    {
        static void Main()
        {
            Greet("John"); // output: Hello, John!
            Greet("Jane", "Doe"); // output: Hello, Jane Doe!
        }
        static void Greet(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
        static void Greet(string firstName, string lastName)
        {
            Console.WriteLine("Hello, " + firstName + " " + lastName + "!");
        }
    }
}