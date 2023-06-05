namespace _45._Advanced_Menu__Bonus_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            menu.AddMenuItem("Option 1", () => Console.WriteLine("You selected Option 1"));
            menu.AddMenuItem("Option 2", () => Console.WriteLine("You selected Option 2"));
            menu.AddMenuItem("Option 3", () => Console.WriteLine("You selected Option 3"));

            menu.Run();
        }
    }
}