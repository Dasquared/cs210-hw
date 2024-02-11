using System;
// My assignment "Exceeds Requirements" because I "Added additional kinds of goals such as "negative goals" where users lose points for bad habits" this goal is similar to the Eternal Goal because cannot be marked as completed, also I "added a new feature that is an option to delete any goal" the user could delete any goal they completed or they don't need any more.

class Program
{
    static void Main(string[] args)
    {
        List<Goal> list = new List<Goal>();
        int totalPoints = 0;
        int option;
        int choice;
        int position;
        do {
            Console.WriteLine();
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal"); // Here is a part that exceeds requirements.
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Delete Goal"); // This is a part that exceeds requirements.
            Console.WriteLine("  7. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine("  4. Negative Goal"); // This is a part that exceeds requirements.
                Console.Write("Wich type of goal would you like to create? ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    SimpleGoal sGoal = new SimpleGoal();
                    sGoal.CreateGoal();
                    list.Add(sGoal);
                }
                else if (choice == 2)
                {
                    EternalGoal eGoal = new EternalGoal();
                    eGoal.CreateGoal();
                    list.Add(eGoal);
                }
                else if (choice == 3)
                {
                    ChecklistGoal cGoal = new ChecklistGoal();
                    cGoal.CreateGoal();
                    list.Add(cGoal);
                }
                else if (choice == 4)
                {
                    NegativeGoal nGoal = new NegativeGoal(); // This is a part that exceeds requirements.
                    nGoal.CreateGoal();
                    list.Add(nGoal);
                }
                else 
                {
                    Console.WriteLine("Please choose between 1-4.");
                }
                
            }
            else if (option == 2)
            {
                Console.WriteLine("The goals are:");
                position = 0;
                foreach (Goal aGoal in list)
                {
                    position++;
                    Console.WriteLine($"{position}{aGoal.GetList()}");
                }
            }
            else if (option == 3)
            {
                ActivityHandler actHandler = new ActivityHandler();
                actHandler.SetTotalPoints(totalPoints);
                actHandler.SetListGoals(list);
                actHandler.SaveFile();
            }
            else if (option == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                if (File.Exists(fileName))
                {
                    ActivityHandler actHandler = new ActivityHandler();
                    actHandler.LoadFile(fileName);
                    totalPoints = actHandler.GetTotalPoints();
                    list = actHandler.GetListGoals();
                } else {
                    Console.WriteLine("There is not such filename.");
                }
            }
            else if (option == 5)
            {
                Console.WriteLine("The goals are:");
                position = 0;
                foreach (Goal aGoal in list)
                {
                    position++;
                    Console.WriteLine($"{position}. {aGoal.GetName()}");
                }
                Console.Write("Which goal did you accomplish? ");
                int acomplished = int.Parse(Console.ReadLine());
                if (acomplished >= 1 && acomplished <= list.Count)
                {
                    acomplished -= 1;
                    int newPoints = list[acomplished].RecordEvent();
                    int completePoints = totalPoints;
                    completePoints += newPoints;
                    totalPoints = completePoints;

                    Console.WriteLine($"You now have {totalPoints} points.");
                }
                else
                {
                    Console.WriteLine("Invalid position. Please enter a valid position.");
                }

            }
            else if (option == 6) // This is a part that exceeds requirements.
            {
                position = 0;
                foreach (Goal aGoal in list)
                {
                    position++;
                    Console.WriteLine($"{position}{aGoal.GetList()}");
                }

                Console.Write("Enter the position of the goal to delete: ");
                int deletePosition = int.Parse(Console.ReadLine());

                if (deletePosition >= 1 && deletePosition <= list.Count)
                {
                    list.RemoveAt(deletePosition - 1);
                    Console.WriteLine("Goal deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid position. Please enter a valid position.");
                }
            }
            else if (option != 7)
            {
                Console.WriteLine("Please choose between 1-6.");
            }

        } while (option != 7);
    }
}