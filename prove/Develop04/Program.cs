using System;
// My assignment "Exceeds Requirements" because "Keeps a log of how many times activities were performed".
class Program
{
    static void Main(string[] args)
    {
        int option;
        LogRecord logRecord = new LogRecord(); // This is the part that exceeds requirements.
        do
        {   
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine($"  1. Start breathing activity - Times performed: {logRecord.GetBreathingLog()}");
            Console.WriteLine($"  2. Start reflecting activity - Times performed: {logRecord.GetReflectingLog()}");
            Console.WriteLine($"  3. Start listing activity - Times performed: {logRecord.GetListingLog()}");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplaySummary();
                breathingActivity.GetReady();
                
                breathingActivity.BreatheInAnOut();
                
                breathingActivity.DisplayEndMessage();
                logRecord.AddToBreathingLog();
            }
            else if (option == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.DisplaySummary();
                reflectingActivity.GetReady();

                reflectingActivity.DisplayReflectionPrompt();
                reflectingActivity.DisplayQuestion();

                reflectingActivity.DisplayEndMessage();
                logRecord.AddToReflectingLog();
            }
            else if (option == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplaySummary();
                listingActivity.GetReady();

                listingActivity.DisplayListingPrompt();
                listingActivity.Listing();
                listingActivity.DisplayItemsAmount();

                listingActivity.DisplayEndMessage();
                logRecord.AddToListingLog();
            }
            else
            {
                if (option != 4)
                {
                    Console.Write("Choose between 1-4. Press Enter to try again.");
                    Console.ReadLine();  
                }
                          
            }
        } while (option != 4);
        
    }
}