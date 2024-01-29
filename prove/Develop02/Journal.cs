using System;
using System.Collections.Generic;
using System.IO;

public class Journal 
{   
    // List for storing diary entries
    public List<Entry> _entries = new List<Entry>();

    // Method for adding a new journal entry
    public void AddEntry(Entry newEntry)
    {   
        _entries.Add(newEntry);
    }

    // Method to display all journal entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Method for saving diary entries to a file
    public void SaveToFile(string filename)
    {   
        // StreamWriter to write input to a file
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry userEntry in _entries)
            {   
                // Writing each entry to the file
                outputFile.WriteLine(userEntry.ToString());
            }
        }
    }

    // Method to load journal entries from a file
    public void LoadFromFile(string filename)
    {
        // Reading all lines from the file
        string[] lines = System.IO.File.ReadAllLines(filename);

        // Displaying each line read from the file in the console
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    // New method to save other information in the journal entry
    public void SaveOtherInformation(int entryIndex, string additionalInfo)
    {
        // Verifying if the index is within the array bounds
        if (entryIndex >= 0 && entryIndex < _entries.Count)
        {
            // Concatenating additional information to the journal entry
            _entries[entryIndex]._entryText += $" | Additional Info: {additionalInfo}";
        }
        else
        {
            Console.WriteLine("Invalid entry index.");
        }
    }
}
