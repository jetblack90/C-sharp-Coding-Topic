namespace _27._Constructors
{
    internal class CarModels
    {
        private static void Main(string[] args)
        {
            // Creating an object with the constructor
            Car myCar = new Car("Toyota", "Camry", 2022, "Silver");

            // Accessing object properties
            myCar.DisplayDetails();
        }
    }
}