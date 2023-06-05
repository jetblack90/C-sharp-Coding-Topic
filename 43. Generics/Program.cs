namespace _43._Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            string[] names = { "John", "Jane", "Mike" };

            PrintArray(numbers);
            PrintArray(names);
        }

        static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}