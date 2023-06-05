namespace _26._Objects
{
    internal class Human
    {
        public string Name;
        public int Age;

        public void SayHello()
        {
            Console.WriteLine("Hello, my name is " + Name + " and I'm " + Age + " years old.");
        }
    }

    internal class Identity
    {
        public static void Main(string[] args)
        {
            // Creating an object
            Human person = new Human();

            // Setting object properties
            person.Name = "John";
            person.Age = 30;

            // Accessing object properties
            Console.WriteLine("Person: Name - " + person.Name + ", Age - " + person.Age);

            // Invoking object methods
            person.SayHello();
        }
    }
}