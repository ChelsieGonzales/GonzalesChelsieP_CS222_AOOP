using System;

enum FoodCategory
{
    MainCourse = 1,
    Dessert
}

class OrderingSystem
{
    static void DisplayCategories()
    {
        Console.WriteLine("Available Food Categories:");
        foreach (FoodCategory category in Enum.GetValues(typeof(FoodCategory)))
        {
            Console.WriteLine($"{(int)category}. {category}");
        }
    }

    static void DisplayMenu(FoodCategory category, string[] dishes)
    {
        Console.WriteLine($"Available {category}s:");
        for (int i = 0; i < dishes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {dishes[i]}");
        }
    }

    static void Main()
    {
        string[] mainCourseDishes = { "Steak", "Grilled Chicken" };
        string[] dessertDishes = { "Ice Cream", "Cake" };

        while (true)
        {
            DisplayCategories();
            Console.Write("\nEnter the number of your preferred category: ");
            if (int.TryParse(Console.ReadLine(), out int categoryInput) && Enum.IsDefined(typeof(FoodCategory), categoryInput))
            {
                FoodCategory selectedCategory = (FoodCategory)categoryInput;
                string[] selectedDishes = selectedCategory == FoodCategory.MainCourse ? mainCourseDishes : dessertDishes;
                
                DisplayMenu(selectedCategory, selectedDishes);
                Console.Write("\nEnter the number of the dish you want to order: ");
                
                if (int.TryParse(Console.ReadLine(), out int dishInput) && dishInput > 0 && dishInput <= selectedDishes.Length)
                {
                    Console.WriteLine($"\nYou ordered '{selectedDishes[dishInput - 1]}'. Enjoy your meal!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.\n");
            }
        }
    }
}
