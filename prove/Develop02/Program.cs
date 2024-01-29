using System;
using System.Collections.Generic;
using System.IO;

// Notes: 
// I implemented the function to avoid repeated prompts in option 1 - Write. 
// I did this in the PromptGenerator class with the help of some internet links on StarkFlow forum and from a 
// friend who already studied C# and knew the language.

class Program
{
    static void Main(string[] args)
    {
        // A Welcome Message.
        Console.WriteLine("\nWelcome to the Journal Program!");

        // Instance of the Journal class to manage the journal
        Journal journal = new Journal();

        // Instance of the PromptGenerator class to generate random prompts
        PromptGenerator promptGenerator = new PromptGenerator();

        // Variable to store user choice
        int userChoice = -1;

        // Main program loop
        while (userChoice != 5)
        {   
            // Displaying menu options for the user
            Console.WriteLine("\nPlease select one of the following choices: \n1. Write \n2. Display \n3. Load" +
                                "\n4. Save \n5. Quit");
            
            // Ask the user which of the options to perform an action.
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());
            
            // Write
            if (userChoice == 1) 
            {
                // Get a random prompt
                string prompt = promptGenerator.GetRandomPrompt();

                // Check if the prompt is not null before creating a new entry
                if (prompt != null)
                {   
                    // Creating a new entry with the current date, the prompt, and the text entered by the user
                    Entry newEntry = new Entry
                    {
                        _date = DateTime.Now.ToString(),
                        _promptText = prompt,
                    };

                    // Ask user to input the entry text
                    Console.WriteLine($"{prompt}");
                    Console.Write("> ");
                    newEntry._entryText = Console.ReadLine();

                    // Ask user for additional information
                    Console.Write("Enter additional information: ");
                    string additionalInfo = Console.ReadLine();

                    // Save other information in the journal entry
                    newEntry._entryText = promptGenerator.SaveOtherInformation(newEntry._entryText, additionalInfo);

                    // Add the entry to the journal
                    journal.AddEntry(newEntry);
                }

                // A message is displayed if all the prompts are used
                else
                {
                    Console.WriteLine("All prompts have been used. Cannot create a new entry.");
                }
            }

            // Dispay functionality.
            else if (userChoice == 2)
            {
                journal.DisplayAll();
            }

            // Load functionality.
            else if (userChoice == 3)
            {
                // Asking the user for the filename to load
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();

                // Loading journal entries from the file
                journal.LoadFromFile(filename);
            }

            // Save functionality.
            else if (userChoice == 4)
            {
                // Asking the user for the filename to save
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();
                
                // Saving journal entries to the file
                journal.SaveToFile(filename);

                Console.WriteLine("Entries saved successfully!");
            }

            // Quit functionality.
            else if (userChoice == 5)
            {
                // Thank you message and program termination
                Console.WriteLine("\nThank you! \nCome back soon.");
                Console.WriteLine();
                
            }

            // Invalid option
            else
            {
                Console.WriteLine("Invalid option. Try again!");
            }
        }
        
    }
}
