namespace _28._Static
{
    public class Fruit
    {
        public static int Count;  // Static field

        public string Name;  // Instance field

        public Fruit(string name)
        {
            Name = name;
            Count++;  // Incrementing the static field
        }

        public static void DisplayCount()  // Static method
        {
            Console.WriteLine("Total number of fruits: " + Count);
        }

        public void DisplayInfo()  // Instance method
        {
            Console.WriteLine("Fruit Name: " + Name);
        }
    }

    public class Goods
    {
        public static void Main(string[] args)
        {
            Fruit apple = new Fruit("Apple");
            Fruit orange = new Fruit("Orange");
            Fruit banana = new Fruit("Banana");

            apple.DisplayInfo();
            orange.DisplayInfo();
            banana.DisplayInfo();

            Fruit.DisplayCount();  // Accessing the static method
        }
    }
}