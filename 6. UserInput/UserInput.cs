namespace _6._User_Input
{
    internal class UserInput
    {
        static void Main(string[] args)
        {
            Console.Write("\n\tWhat is your name? >>> ");
            string name = Console.ReadLine();


            Console.Write("\n\tWhat is your age? >>> ");
            string ageInput = Console.ReadLine();

            int age = int.Parse(ageInput);
        }
    }
}