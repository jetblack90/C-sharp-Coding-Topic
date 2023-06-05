namespace _22._Conditional_Operator
{
    internal class ConditionalOperators
    {
        static void Main(string[] args)
        {
            int age = 18;
            string message = (age >= 18) ? "adult" : "minor";
            Console.WriteLine(message);

            Temperature();
        }
        
        static void Temperature()
        {
            int temperature = 17;

            string weatherStatus = temperature >= 19 ? "Hot" : "Cold";

            Console.WriteLine("Temperature: " + temperature + "°C");
            Console.WriteLine("Weather Status: " + weatherStatus);

            if (temperature >= 19)
            {
                Console.WriteLine("It's hot outside. Stay hydrated!");
            }
            else
            {
                Console.WriteLine("It's cold outside. Bundle up!");
            }
        }
    }
}