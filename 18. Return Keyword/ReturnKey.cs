namespace _18._Return_Keyword
{
    internal class ReturnKey
    {
        static void Main()
        {
            int result = CalculateSum(5, 3);

            // output: The sum is 8:
            Console.WriteLine("The sum is: " + result);
        }
        static int CalculateSum(int a, int b)
        {
            int sum = a + b;

            // return the sum back to the caller:
            return sum;
        }
    }
}