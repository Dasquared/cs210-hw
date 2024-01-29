using System;
// My assignment "Exceeds Requirements" because "the program loads scriptures from a file" and "the program works with a library of scriptures rather than a single one". Also, the user can choose what scripture he wants to memorize.

    class Program
    {        
        static void Main()
        {            
            Scripture scripture;
            Console.Clear();
            Finder finder = new Finder(); // This is the part that exceeds requirements.
            Console.WriteLine("Scripture Memorizer");
            Console.Write("Press Enter to display the last scripture or type 'no' to change it: ");
            finder.SetInput(Console.ReadLine());
            finder.Display();
            if (finder.GetVerse() == finder.GetEndVerse())
            {
                scripture = new Scripture(finder.GetBook(), finder.GetChapter(), finder.GetVerse(), finder.GetText());
            }
            else
            {
                scripture = new Scripture(finder.GetBook(), finder.GetChapter(), finder.GetVerse(), finder.GetEndVerse(), finder.GetText());
            }
            Console.Clear();
            scripture.Display(); 
            Console.WriteLine();
            Console.Write("\nPress Enter to continue or type 'quit' to finish: ");
            string answer;
            do
            {
                answer = Console.ReadLine();
                if (!scripture.Hide())
                {
                    Console.Clear();
                    scripture.Display();
                    Console.WriteLine();
                    Console.Write("\nPress Enter to continue or type 'quit' to finish: ");
                    break;
                }
                if (answer != "quit")
                {
                    Console.Clear();
                    scripture.Display();
                    Console.WriteLine();
                    Console.Write("\nPress Enter to continue or type 'quit' to finish: ");
                }                                
            } while (answer != "quit");
        }
    }
