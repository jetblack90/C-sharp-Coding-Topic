namespace _21._Exception_Handling
{
    internal class Exception
    {
        static void Main(string[] args)
        {
            try
            {
                // Code that might throw an exception

                // Division by zero, will throw an exception:
                int result = DivideNumbers(10, 0);
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                // Catching the specific exception type:
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Cleanup code or releasing resources:
                Console.WriteLine("Finally block executed.");
            }

            
        }
        // Custom method to divide two numbers:
        static int DivideNumbers(int dividend, int divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return dividend / divisor;
        }
    }
}