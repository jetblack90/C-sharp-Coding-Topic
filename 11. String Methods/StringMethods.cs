namespace _11._String_Methods
{
    internal class StringMethods
    {
        static void Main(string[] args)
        {
            // String length:

            string message1 = "Hello, world!";
            int length = message1.Length;

            Console.WriteLine("Length of the string: " + length);


            // String to upper/lower case:

            string message2 = "Hello, world!";
            string upperCase = message2.ToUpper();
            string lowerCase = message2.ToLower();

            Console.WriteLine("Upper case: " + upperCase);
            Console.WriteLine("Lower case: " + lowerCase);


            // Sub-string:

            string message3 = "Hello, world!";
            string subString = message1.Substring(7, 5);

            Console.WriteLine("Sub-string: " + subString);


            // String concatenate:

            string firstName = "John";
            string lastName = "Doe";
            string fullName = string.Concat(firstName, " ", lastName);

            Console.WriteLine("Full name: " + fullName);


            // String replacement:

            string message4 = "Hello, world!";
            string newMessage = message1.Replace("world", "everyone");

            Console.WriteLine("New message: " + newMessage);


            // String index of...

            string message = "Hello, world!";
            int index = message.IndexOf("world");

            Console.WriteLine("Index of 'world': " + index);
        }
    }
}