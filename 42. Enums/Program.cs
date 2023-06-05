namespace _42._Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planet myPlanet = Planet.Earth;

            Planet anotherPlanet = (Planet)3; // Assigns the enum value for Mars

            switch (myPlanet)
            {
                case Planet.Earth:
                    Console.WriteLine("You are on Earth!");
                    break;
                case Planet.Mars:
                    Console.WriteLine("You are on Mars!");
                    break;
                default:
                    Console.WriteLine("You are on a different planet.");
                    break;
            }
        }
    }
}