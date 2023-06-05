namespace _5._Type_Casting
{
    internal class TypeCasting
    {
        static void Main(string[] args)
        {
            // int

            double number = 3.14;
            int a = Convert.ToInt32(number);

            Console.WriteLine(a.GetType());

            // double

            float floatValue = 3.14f;
            double b = (double)floatValue;

            Console.WriteLine(b.GetType());

            // string

            int intValue = 42;
            string c = intValue.ToString();

            Console.WriteLine(c.GetType());

            // char

            int asciiValue = 65;
            char d = (char)asciiValue;

            Console.WriteLine(d.GetType());
        }
    }
}