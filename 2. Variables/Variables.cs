namespace _2._Variables
{
    internal class Variables
    {
        static void Main(string[] args)
        {
            // Byte:

            byte myByte;
            myByte = 255;

            Console.WriteLine(myByte);

            // Float:

            float myFloat = 3.14f;

            Console.WriteLine(myFloat);

            float x = 2.5f;
            float y = 1.3f;
            float z = x + y;

            Console.WriteLine(z);

            // Char:

            char myChar = 'A';

            Console.WriteLine(myChar);

            char newLine = '\n';

            Console.WriteLine("Hello," + newLine + "World!");

            // String: 

            string myString = "Hello, World!";

            Console.WriteLine(myString);

            string headTitle = "C# Coding Topic";
            string subTitle = "A Beginner's Guide";
            string fullTitle = headTitle + ": " + subTitle;

            Console.WriteLine(fullTitle);

            // Boolean:

            bool isSunny = true;

            Console.WriteLine("Is it sunny today? " + isSunny);

            bool hasRain = false;

            Console.WriteLine("Is it raining? " + hasRain);

            // Concatenation, placeholder syntax, and string interpolation:

            string name = "John";
            int age = 25;

            // Concatenation:
            Console.WriteLine("My name is " + name + " and I am " + age + " years old.");

            // Placeholder syntax:
            Console.WriteLine("My name is {0} and I am {1} years old.", name, age);

            // String interpolation:
            Console.WriteLine($"My name is {name} and I am {age} years old.");
        }
    }
}