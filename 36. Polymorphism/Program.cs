namespace _36._Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Car(),
                new Motorcycle(),
                new Boat(),
                new Bicycle(),
                new Airplane()
            };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Move();
            }
        }
    }
}