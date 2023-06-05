namespace _41._Auto_implemented_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Model = "Toyota Camry";

            string carModel = myCar.Model;
            Console.WriteLine("Car Model: " + carModel);
        }
    }
}