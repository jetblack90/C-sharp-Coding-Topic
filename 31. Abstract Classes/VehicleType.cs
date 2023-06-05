namespace _31._Abstract_Classes
{
    public class VehicleType : VehicleBrand
    {
        public override void Drive()
        {
            Console.WriteLine("Driving the car...");
        }
    }

    public class Motorcycle : VehicleBrand
    {
        public override void Drive()
        {
            Console.WriteLine("Riding the motorcycle...");
        }
    }
}
