namespace _1._Print_Text
{
    internal class PrintText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Console.WriteLine();

            Console.Write("This is some text. ");
            Console.WriteLine("And here's more text on the same line.");

            Console.WriteLine("The 'Line' in 'WriteLine' breaks the end-point of this line of text.");

            Console.WriteLine("First line witrhout any escape characters.\n\tSecond line with escape characters.");
        }
    }
}