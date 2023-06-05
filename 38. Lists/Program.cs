namespace _38._Lists
{
    internal class Program
    {
        private static List<string> fruits = new List<string>();

        /*
        If your list is going to be in one class and you want to call it from another class
        replace "private" to "public", and make sure to add the class name:
        "AnotherClass.fruits.Add("Apple");"

        If your list is going to be used in one method, such as the 'Main' method,
        then simply place "List<string> fruits = new List<string>();" inside the 'Main'.
        */

        private static void Main(string[] args)
        {
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            fruits.Remove("Banana");

            fruits.Insert(1, "Grapes");

            int count = fruits.Count;
            Console.WriteLine("Number of fruits: " + count);

            string firstFruit = fruits[0];
            Console.WriteLine("First fruit: " + firstFruit);

            bool containsApple = fruits.Contains("Apple");
            Console.WriteLine("List contains Apple: " + containsApple);
        }
    }
}