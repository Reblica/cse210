class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        int b_Activity = 0;
        int r_Activity = 0;
        int l_Activity = 0;
        
        int choice = 0;
        

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            if (choice == 1)
            {
                b_Activity++;
                breathingActivity.RunBreathingActivity();
            }
            else if (choice == 2)
            {
                r_Activity++;
                reflectingActivity.RunReflectingActivity();
            }
            else if (choice == 3)
            {
                l_Activity++;
                listingActivity.RunListingActivity();
            }
        }
        Console.WriteLine($"You have completed the following activities:");
        Console.WriteLine();
        Console.WriteLine($"Breathing Activity: {b_Activity} times");
        Console.WriteLine($"Reflecting Activity: {r_Activity} times");
        Console.WriteLine($"Listing Activity: {l_Activity} times");
    }
}