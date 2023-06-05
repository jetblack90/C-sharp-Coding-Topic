namespace _44._Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread countdownThread = new Thread(CountDown);
            Thread countupThread = new Thread(CountUp);

            countdownThread.Start();
            //countupThread.Start();
        }
        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Countdown: {i}");
                Thread.Sleep(1000); // Pause the execution for 1 second
            }
        }
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Countup: {i}");
                Thread.Sleep(500); // Pause the execution for 500 milliseconds
            }
        }
    }
}