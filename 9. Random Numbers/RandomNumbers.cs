namespace _9._Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomInt = random.Next(1, 11);
            Console.WriteLine("Random Integer: " + randomInt);

            double randomFloat = random.NextDouble();
            Console.WriteLine("Random Float: " + randomFloat);
        }
    }
}