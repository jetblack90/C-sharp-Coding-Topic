namespace _39._List_of_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Fruit> fruits = new List<Fruit>();

            Fruit apple = new Fruit { Name = "Apple", Color = "Red" };
            Fruit banana = new Fruit { Name = "Banana", Color = "Yellow" };
            Fruit orange = new Fruit { Name = "Orange", Color = "Orange" };

            fruits.Add(apple);
            fruits.Add(banana);
            fruits.Add(orange);

            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine("Name: " + fruit.Name);
                Console.WriteLine("Color: " + fruit.Color + "\n");
            }

            fruits.RemoveAt(1); // Removes the second fruit (banana) from the list

            Fruit firstFruit = fruits[0];
            Console.WriteLine("First fruit: " + firstFruit.Name);

            int count = fruits.Count;
            Console.WriteLine("Number of fruits: " + count);
        }
    }
}