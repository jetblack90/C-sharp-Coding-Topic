namespace _30._Inheritance
{
    public class VehiclePart
    {
        public void Install()
        {
            Console.WriteLine("Installing vehicle part...");
        }
    }

    public class Engine : VehiclePart
    {
        public void Start()
        {
            Console.WriteLine("Starting the engine...");
        }
    }

    public class Wheel : VehiclePart
    {
        public void Rotate()
        {
            Console.WriteLine("Wheel rotating...");
        }
    }

    public class Vehicle
    {
        public static void Main()
        {
            Engine engine = new Engine();
            Wheel wheel = new Wheel();

            engine.Install();
            engine.Start();

            wheel.Install();
            wheel.Rotate();
        }
    }
}