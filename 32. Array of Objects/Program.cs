namespace _32._Array_of_Objects
{
    internal class Program
    {
        private static void Main()
        {
            Fruit[] fruits = new Fruit[3];

            fruits[0] = new Apple();
            fruits[1] = new Banana();
            fruits[2] = new Apple();

            foreach (Fruit fruit in fruits)
            {
                fruit.Eat();
            }
        }
    }
}