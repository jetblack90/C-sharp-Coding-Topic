namespace _16._Loops
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (count < 5)
            {
                Console.WriteLine("\n\tWhile count: " + count);
                count++;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n\tFor loop iteration: " + i);
            }

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("\n\tNested loop iteration: (" + i + ", " + j + ")");
                }
            }

            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (int number in numbers)
            {
                Console.WriteLine("\n\tForeach count: " + number);
            }
        }
    }
}