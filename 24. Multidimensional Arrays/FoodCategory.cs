namespace _24._Multidimensional_Arrays
{
    internal class FoodCategory
    {
        static void Main(string[] args)
        {
            string[] vegetables = { "Carrots", "Broccoli", "Spinach" };
            string[] grains = { "Rice", "Quinoa", "Oats" };
            string[] meat = { "Chicken", "Beef", "Fish" };

            string[,] foodCategory =
            {
                { "Carrots", "Broccoli", "Spinach" },
                { "Rice", "Quinoa", "Oats" },
                { "Chicken", "Beef", "Fish" }
            };

            // Replaces "Spinach" with "Salad":
            foodCategory[0, 2] = "Salad";

            Console.WriteLine(foodCategory[0, 2]); // Outputs "Salad"
            Console.WriteLine(foodCategory[1, 0]); // Outputs "Rice"
            Console.WriteLine(foodCategory[2, 2]); // Outputs "Fish"

            int loopSwitch = 1;

            switch (loopSwitch)
            {
                case 1:
                    // Accessing elements in the multidimensional array
                    for (int i = 0; i < foodCategory.GetLength(0); i++)
                    {
                        for (int j = 0; j < foodCategory.GetLength(1); j++)
                        {
                            Console.WriteLine(foodCategory[i, j]);
                        }
                    }
                    break;

                case 2:
                    foreach (string food in foodCategory)
                    {
                        Console.WriteLine(food);
                    }
                    break;
            }
        }
    }
}