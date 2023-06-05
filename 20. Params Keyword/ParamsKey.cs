namespace _20._Params_Keyword
{
    internal class ParamsKey
    {
        static void Main()
        {
            int sum1 = Sum(1, 2, 3, 4, 5); // sum1 = 15
            int sum2 = Sum(10, 20, 30); // sum2 = 60

            Console.WriteLine("Sum 1: " + sum1);
            Console.WriteLine("Sum 2: " + sum2);
        }
        static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }
    }
}