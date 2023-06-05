namespace _10._Hypotenuse_Calculator
{
    internal class HypotenuseCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the base: ");
            string baseInput = Console.ReadLine();

            Console.WriteLine("Enter the length of the height: ");
            string heightInput = Console.ReadLine();

            double baseLength = Convert.ToDouble(baseInput);
            double height = Convert.ToDouble(heightInput);

            double hypotenuse = Math.Sqrt(baseLength * baseLength + height * height);

            Console.WriteLine("The length of the hypotenuse is: " + hypotenuse);
        }
    }
}