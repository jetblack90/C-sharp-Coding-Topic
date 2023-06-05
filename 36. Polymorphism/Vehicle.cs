namespace _36._Polymorphism
{
    public class Vehicle
    {
        public virtual void Move()
        {
            // Common implementation for moving
        }
    }
    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("The car is moving.");
        }
    }
    public class Motorcycle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("The motorcycle is moving.");
        }
    }
    public class Boat : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("The boat is moving.");
        }
    }
    public class Bicycle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("The bicycle is moving.");
        }
    }
    public class Airplane : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("The airplane is flying.");
        }
    }
}
