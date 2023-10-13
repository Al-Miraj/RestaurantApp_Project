public class AboutUs
{
    public static readonly string Location = "Wijnhaven 107, 3011 WN, Rotterdam, Zuid-Holland.";
    public static readonly string RestaurantName = "";
    public static readonly string OpeningHours = "11 am - 10 pm.";
    public static readonly string RestaurantEmail = "";
    public static readonly string PhoneNumber = "1234567890";
    public static readonly List<string> SocialMedia = new List<string>() { "Restaurant: " };

    public static void Info()
    {
        Console.WriteLine(RestaurantName);
        Console.WriteLine($"Location: {Location}");
        Console.WriteLine($"Openinghours: {OpeningHours}");

        Console.WriteLine("Do you want directions for public transport or directions for driving?");
        Console.WriteLine("1. public transport 2. car");
        string choice = Console.ReadLine().ToLower();

        if (choice == "1" )
        {
            publicTransport();
        }
        else
        {
            carTransport();
        }
    }

    public static void publicTransport()
    {
        Console.WriteLine("Directions to Wijnhaven 107, Rotterdam:");
        Console.WriteLine();

        //Blaak to Wijnhaven 107
        Console.WriteLine("From Blaak:");
        Console.WriteLine("1. Start at Blaak Station.");
        Console.WriteLine("2. Take Tram 21 towards De Esch.");
        Console.WriteLine("3. Get off at the Willemsplein tram stop.");
        Console.WriteLine("4. Wijnhaven 107 is within walking distance from the tram stop.");
        Console.WriteLine("There are alternative ways but this one is the fastest.");
        Console.WriteLine();

        //Beurs to Wijnhaven 107
        Console.WriteLine("From Beurs:");
        Console.WriteLine("1. Start at Beurs Metro Station.");
        Console.WriteLine("2. Take Metro Line D (Direction: De Akkers) or Line E (Direction: Slinge) depending on the platform.");
        Console.WriteLine("3. Get off at Leuvehaven Metro Station.");
        Console.WriteLine("4. Walk southeast on Wijnhaven Street.");
        Console.WriteLine("5. Wijnhaven 107 will be on your right.");
        Console.WriteLine("There are alternative ways but this one is the fastest.");
        Console.WriteLine();

        //Rotterdam Centraal to Wijnhaven 107
        Console.WriteLine("From Rotterdam Centraal:");
        Console.WriteLine("1. Start at Rotterdam Centraal Station.");
        Console.WriteLine("2. Take Metro Line D (Direction: De Akkers) or Line E (Direction: Slinge).");
        Console.WriteLine("3. Get off at Leuvehaven Metro Station.");
        Console.WriteLine("4. Walk southeast on Wijnhaven Street.");
        Console.WriteLine("5. Wijnhaven 107 will be on your right.");
        Console.WriteLine("There are alternative ways but this one is the fastest.");
        Console.WriteLine();
    }

    public static void carTransport()
    {
        Console.WriteLine("Driving Directions to Wijnhaven 107, Rotterdam:");
        Console.WriteLine();

        //Blaak to Wijnhaven 107 (by car)
        Console.WriteLine("From Blaak:");
        Console.WriteLine("1. Start at Blaak Station.");
        Console.WriteLine("2. Head southeast on Blaak.");
        Console.WriteLine("3. Continue on Blaak until you reach Wijnhaven Street.");
        Console.WriteLine("4. Turn right onto Wijnhaven Street.");
        Console.WriteLine("5. Continue on Wijnhaven Street, and Wijnhaven 107 will be on your right.");
        Console.WriteLine("There are alternative ways but this one is the fastest.");
        Console.WriteLine();

        //Beurs to Wijnhaven 107 (by car)
        Console.WriteLine("From Beurs:");
        Console.WriteLine("1. Start at Beurs Metro Station.");
        Console.WriteLine("2. Head northeast on Westblaak Street.");
        Console.WriteLine("3. Continue on Westblaak Street until you reach Wijnhaven Street.");
        Console.WriteLine("4. Turn right onto Wijnhaven Street.");
        Console.WriteLine("5. Continue on Wijnhaven Street, and Wijnhaven 107 will be on your right.");
        Console.WriteLine("There are alternative ways but this one is the fastest.");
        Console.WriteLine();

        //Rotterdam Centraal to Wijnhaven 107 (by car)
        Console.WriteLine("From Rotterdam Centraal:");
        Console.WriteLine("1. Start at Rotterdam Centraal Station.");
        Console.WriteLine("2. Head southeast on Proveniersplein.");
        Console.WriteLine("3. Continue on Proveniersplein until you reach Schiekade.");
        Console.WriteLine("4. Turn right onto Schiekade.");
        Console.WriteLine("5. Continue on Schiekade until you reach Wijnhaven Street.");
        Console.WriteLine("6. Turn left onto Wijnhaven Street.");
        Console.WriteLine("7. Wijnhaven 107 will be on your left.");
        Console.WriteLine("There are alternative ways but this one is the fastest.");
        Console.WriteLine();
    }
}