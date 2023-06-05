namespace _27._Constructors
{
    internal class Car
    {
        // Attributes
        public string Make;
        public string Model;
        public int Year;
        public string Color;

        // Constructor
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        // Method
        public void DisplayDetails()
        {
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Color: " + Color);
        }
    }
}
