using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

public static class FoodMenu
{
    //parsed data
    public static List<MenuItem> MenuItems = new();

    static const Dictionary<string, string> categoryEmojis = new Dictionary<string, string>
    {
        { "Meat", "🥩" },
        { "Chicken", "🍗" },
        { "Fish", "🐟" },
        { "Vegetarian", "🥦" }
    };

    //raw data
    public static List<MenuItem>? LoadFoodMenuData()
    {
        try
        {
            using StreamReader reader = new StreamReader("items.json");
            string json = reader.ReadToEnd();
            var items = JsonConvert.DeserializeObject<List<MenuItem>>(json);
            return items;
        }
        catch (JsonReaderException)
        { return null; }
        catch (FileNotFoundException)
        { return null; }
        catch (UnauthorizedAccessException)
        { return null; }
    }

    public static void Display()
    {
        MenuItems = GetDefaultMenu();
        while (true)
        {
            Console.WriteLine(); Console.WriteLine("==================================================================================================================");
            for (int i = 0; i < MenuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {MenuItems[i].Name,-20} {MenuItems[i].Price,74}");
                if (MenuItems[i].Description.Length > 52)
                {
                    Console.WriteLine($"{MenuItems[i].Description.Substring(0, 50)}- {MenuItems[i].AllergensInfo,60}");
                    Console.WriteLine(MenuItems[i].Description.Substring(50, MenuItems[i].Description.Length - 50));
                }
                else
                {
                    Console.WriteLine($"{MenuItems[i].Description,-50} {MenuItems[i].AllergensInfo,60}");
                }
                Console.WriteLine($"Ingredients: {string.Join(", ", MenuItems[i].Ingredients)}");
                Console.WriteLine();
            }
            Console.WriteLine("==================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("Would you like to see the other menu?");
            Console.WriteLine("1. Lunch");
            Console.WriteLine("2. Dinner");
            Console.WriteLine("3. Sort menu by category");
            Console.WriteLine("4. Exit");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    MenuItems = GetLunchMenu();
                    break;
                case "2":
                    MenuItems = GetDinnerMenu();
                    break;
                case "3":
                    sortMenu();
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    break;
            }
        }
    }

    static List<MenuItem> sortMenu()
    {
        MenuItems.Clear():
        List<MenuItem> sortedMenu = new List<MenuItem>();
        List<MenuItem> sorteddinnerMenu = new List<MenuItem>();
        List<MenuItem> sortedlunchMenu = new List<MenuItem>();
        List<string> ingredients = new List<string>();


        while (true)
        {
            Console.WriteLine("What menu do you want to sort?");
            Console.WriteLine("1. Lunch, 2. Dinner");
            string? choiceMenu = Console.ReadLine();

            Console.WriteLine("What do you want to sort the menu on?");
            Console.WriteLine("These are the available options:");
            Console.WriteLine("ingredients/price/category (fish, meat, vegan, vegetarian)");
            Console.WriteLine("1. ingredients, 2. price, 3. category");
            string? sortChoice = Console.ReadLine();

            if (choice == "1" || choice == "1.")
            {
                switch (sortChoice)
                {
                    case "1":
                        Console.WriteLine("Enter the ingredients:");
                        string? ingredient = Console.ReadLine();
                        ingredients.Add(ingredient);
                        sortedMenu.AddRange(sortIngredients(ingredients));
                        break;
                    case "2":
                        Console.WriteLine("Enter the maximum price:");
                        double maxPrice = Convert.ToDouble(Console.ReadLine());
                        sortedMenu.AddRange(sortPrice(maxPrice));
                    case"3":
                        
                }
            }

    static List<MenuItem> 
            foreach (var category in categoryEmojis)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            Console.WriteLine("1. Meat, 2. Chicken, 3. Fish, 4. Vegetarian, ")
            Console.WriteLine("Enter 5 to exit.");
            string? category = Console.ReadLine();

            
                var unsorteddinnerMenu = GetDinnerMenu();

                switch (category)
                    {
                        case "1":
                            var sorteddinnerMenu = unsorteddinnerMenu.FindAll(x => x.Icon == "Meat");
                            break;
                        case "2":
                            var sorteddinnerMenu = unsorteddinnerMenu.FindAll(x => x.Icon == "Chicken");
                            break;
                        case "3":
                            var sorteddinnerMenu = unsorteddinnerMenu.FindAll(x => x.Icon == "Fish");
                            break;
                        case "4":
                            var sorteddinnerMenu = unsorteddinnerMenu.FindAll(x => x.Icon == "Vegetarian");
                            break;
                        case "5":
                            return;
                    }
                return sorteddinnerMenu;
            
        }
        
    }
    static List<MenuItem> sortPrice(double price)
    {
        var unsortedpriceItems = GetDinnerMenu();
        return unsortedpriceItems.FindAll(x => x.Price <= price);
    }

    static List<MenuItem> sortIngredients(List<string> ingredients)
    {
        var unsorteddinnerItems = GetDinnerMenu();
        return unsorteddinnerItems.FindAll(x => x.All(ingredients.Contains(ingredients));
    }

    static List<MenuItem> GetDefaultMenu()
    {

        var allItems = FoodMenu.LoadFoodMenuData();
        List<MenuItem> timeslotMenu = new List<MenuItem>();

        var dt = SetTime();
        DateOnly date = dt.date;
        TimeOnly time = dt.time;



        if (ifDinner(time) && allItems != null)
        {
            var dinnerMenuItems = allItems.FindAll(x => x.Timeslot == "Dinner");
            timeslotMenu.AddRange(dinnerMenuItems);

        }
        else
        {
            if (allItems != null)
            {
                var lunchMenuItems = allItems.FindAll(x => x.Timeslot == "Lunch");
                timeslotMenu.AddRange(lunchMenuItems);
            }
        }

        FoodMenu.MenuItems.AddRange(timeslotMenu);

        return timeslotMenu;
    }

    static bool ifDinner(TimeOnly time)
    {
        TimeOnly startTime = new TimeOnly(18, 0);
        TimeOnly endTime = new TimeOnly(22, 0);

        if (time >= startTime && time <= endTime)
        {
            return true;
        }

        return false;
    }

    static (DateOnly date, TimeOnly time) SetTime()
    {
        DateTime now = DateTime.Now;

        DateOnly date = DateOnly.FromDateTime(now);
        TimeOnly time = TimeOnly.FromDateTime(now);

        return (date, time);

    }

    static List<MenuItem> GetLunchMenu()
    {
        var allItems = FoodMenu.LoadFoodMenuData();
        List<MenuItem> tempMenu = new List<MenuItem>();

        var lunchMenuItems = allItems.FindAll(x => x.Timeslot == "Lunch");
        tempMenu.AddRange(lunchMenuItems);

        return tempMenu;
    }

    static List<MenuItem> GetDinnerMenu()
    {
        var allItems = FoodMenu.LoadFoodMenuData();
        List<MenuItem> tempMenu = new List<MenuItem>();

        var lunchMenuItems = allItems.FindAll(x => x.Timeslot == "Dinner");
        tempMenu.AddRange(lunchMenuItems);

        return tempMenu;
    }
}
