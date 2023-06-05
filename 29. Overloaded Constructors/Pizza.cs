namespace _29._Overloaded_Constructors
{
    public class MozzarellaPizza
    {
        private string size;
        private int cheeseAmount;

        public MozzarellaPizza(string size)
        {
            this.size = size;
            cheeseAmount = 1; // Default cheese amount
        }

        public MozzarellaPizza(string size, int cheeseAmount)
        {
            this.size = size;
            this.cheeseAmount = cheeseAmount;
        }

        public void DisplayPizzaDetails()
        {
            Console.WriteLine("Mozzarella Pizza Details:");
            Console.WriteLine("Size: " + size);
            Console.WriteLine("Cheese Amount: " + cheeseAmount);
        }
    }

    internal class Pizza
    {
        static void Main(string[] args)
        {
            MozzarellaPizza smallPizza = new MozzarellaPizza("Small");
            MozzarellaPizza largePizza = new MozzarellaPizza("Large", 2);

            smallPizza.DisplayPizzaDetails();
            largePizza.DisplayPizzaDetails();
        }
    }
}