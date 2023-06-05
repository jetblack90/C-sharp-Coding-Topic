namespace _37._Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPredator predator = new Lion();
            IPrey prey = new Gazelle();

            predator.Hunt(); // Invokes the hunting behavior of a lion
            prey.Flee(); // Invokes the fleeing behavior of a gazelle
        }
    }
}