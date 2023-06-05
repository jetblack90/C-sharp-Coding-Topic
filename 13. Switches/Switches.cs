namespace _13._Switches
{
    internal class Switches
    {
        static void Main(string[] args)
        {
            int day = 3;
            string dayName;

            switch (day)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                default:
                    dayName = "Invalid day";
                    break;
            }
            Console.WriteLine("\n\tThe day is: " + dayName);
        }
    }
}