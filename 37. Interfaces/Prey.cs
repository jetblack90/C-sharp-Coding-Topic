namespace _37._Interfaces
{
    public interface IPrey
    {
        void Flee();
    }
    public class Gazelle : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The gazelle is fleeing from the predator.");
        }
    }
}
