namespace _17._Methods
{
    internal class Methods
    {
        static void Main(string[] args)
        {
            // Your code here
            Greet();
        }

        // No access modifier makes it automatically private access
        static void Method1()
        {
            Console.WriteLine("\n\tMethod1() - Method1() cannot be called from outside of the current class.");
        }

        // Private access
        private static void Method2()
        {
            Console.WriteLine("\n\tMethod2() - Same as Method1()");
        }

        // Public access
        public static void Method3()
        {
            Console.WriteLine("\n\tMethod3() - Method3() can be called from outside of the current class.");
        }

        static void Greet()
        {
            Console.WriteLine("\n\tHello!");
            string name = "John";
            
            Welcome(name);
        }

        static void Welcome(string name)
        {
            Console.WriteLine("\n\tWelcome, " + name + "!");
        }
    }
}