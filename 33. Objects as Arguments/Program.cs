namespace _33._Objects_as_Arguments
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2022;

            StartCarEngine(myCar);
        }

        private static void StartCarEngine(Car car)
        {
            car.StartEngine();
        }
    }
    internal class Car
    {
        public string Make;
        public string Model;
        public int Year;

        public void StartEngine()
        {
            Console.WriteLine($"Starting the {Make} {Model}'s engine...");
        }
    }
}