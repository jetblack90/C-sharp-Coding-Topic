namespace _8._Math_Class
{
    internal class MathClass
    {
        static void Main(string[] args)
        {
            // Absolute value:

            int num = -10;
            int absoluteValue = Math.Abs(num);

            Console.WriteLine("The absolute value is: " + absoluteValue);


            // Rounding value:

            double number = 3.75;
            double roundedValue = Math.Round(number);

            Console.WriteLine("The rounded value is: " + roundedValue);


            // Maximum value::

            int a = 10;
            int b = 7;
            int max = Math.Max(a, b);

            Console.WriteLine("The maximum value is: " + max);


            // Minimum value:

            int c = 10;
            int d = 7;
            int min = Math.Min(c, d);

            Console.WriteLine("The minimum value is: " + min);


            // Square root:

            double digit = 16;
            double squareRoot = Math.Sqrt(digit);

            Console.WriteLine("The square root is: " + squareRoot);


            // Power value:

            double baseNumber = 2;
            double exponent = 3;
            double result = Math.Pow(baseNumber, exponent);

            Console.WriteLine("The result is: " + result);


            // Floor value:

            double dec = 3.75;
            double floorValue = Math.Floor(dec);

            Console.WriteLine("The floor value is: " + floorValue);


            // Ceiling value:

            double numb = 3.75;
            double ceilingValue = Math.Ceiling(numb);

            Console.WriteLine("The ceiling value is: " + ceilingValue);

        }
    }
}