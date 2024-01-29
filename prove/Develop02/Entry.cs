    public class Entry 
    {
        // Attributes to store date, prompt text, and entry text
        public string _date;
        public string _promptText;
        public string _entryText;

        // Method to display an entry in the console
        public void Display()
        {
            Console.WriteLine($"\nDate: {_date} - Prompt: {_promptText} \n> {_entryText}");
        }

        // Overriding the ToString method to get a string representation of the entry
        public override string ToString()
        {
            return $"\nDate: {_date} - Prompt: {_promptText} \n> {_entryText}";
        }
    }