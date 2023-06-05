namespace _40._Getters_and_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            int currentSpeed = myCar.Speed;
            Console.WriteLine("Current Speed: " + currentSpeed);

            myCar.Speed = 60;

            currentSpeed = myCar.Speed;
            Console.WriteLine("Updated Speed: " + currentSpeed);
        }
    }
}