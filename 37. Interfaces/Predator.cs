namespace _37._Interfaces
{
    public interface IPredator
    {
        void Hunt();
    }
    public class Lion : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The lion is hunting its prey.");
        }
    }
}
