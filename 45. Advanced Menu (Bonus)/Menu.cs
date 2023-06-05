namespace _45._Advanced_Menu__Bonus_
{
    public class Menu
    {
        private List<MenuItem> menuItems;

        public Menu()
        {
            menuItems = new List<MenuItem>();
        }

        public void AddMenuItem(string name, Action action)
        {
            MenuItem menuItem = new MenuItem { Name = name, Action = action };
            menuItems.Add(menuItem);
        }

        public void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Menu:");
            Console.ResetColor();

            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuItems[i].Name}");
            }
        }

        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                DisplayMenu();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter your choice (or 'q' to quit):");
                Console.ResetColor();
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "q")
                {
                    isRunning = false;
                    continue;
                }

                if (int.TryParse(userInput, out int choice))
                {
                    if (choice >= 1 && choice <= menuItems.Count)
                    {
                        MenuItem menuItem = menuItems[choice - 1];
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Selected: {menuItem.Name}");
                        Console.ResetColor();
                        Console.WriteLine();
                        menuItem.Action.Invoke();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please try again.");
                    Console.ResetColor();
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
