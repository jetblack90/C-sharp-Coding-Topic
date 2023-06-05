namespace _31._Abstract_Classes
{
    internal class Drive
    {
        static void Main(string[] args)
        {
            VehicleType car = new VehicleType();
            car.Brand = "Toyota";
            car.Drive();

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Brand = "Honda";
            motorcycle.Drive();
        }
    }
}