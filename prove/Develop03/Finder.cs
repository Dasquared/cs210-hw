using System;
using System.Text.RegularExpressions;
using System.Globalization;
// My assignment "Exceeds Requirements" because "the program loads scriptures from a file" and "the program works with a library of scriptures rather than a single one". Also, the user can choose what scripture he wants to memorize. 
    public class Finder 
    {
        
        private string _input;
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;
        private string _text;
        private string _text2;
        private string _fileName = "last-scripture.txt";
        private string _fileName2 = "lds-scriptures.csv";

        public Finder()
        {   
            string[] lines = System.IO.File.ReadAllLines(_fileName);
            foreach (string line in lines)
            {
                string[] parts = Regex.Split(line, @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))");
                if (parts.Length >= 5)
                {   
                    parts[0] = parts[0].Replace("\"", string.Empty);
                    _book = parts[0];
                    _chapter = int.Parse(parts[1]);
                    _verse = int.Parse(parts[2]);
                    
                    if (int.TryParse(parts[3], out int endVerse))
                    {
                        _endVerse = endVerse;
                    }
                    else
                    {
                        _endVerse = int.Parse(parts[2]);
                        _text = parts[3];
                    }
                    
                    if (!string.IsNullOrEmpty(parts[4]))
                    {
                        _text = parts[4];
                        _text = _text.Replace("~", "\n");
                    }
                }
                else
                {
                    parts[0] = parts[0].Replace("\"", string.Empty);
                    _book = parts[0];
                    _chapter = int.Parse(parts[1]);
                    _verse = int.Parse(parts[2]);
                    _endVerse = int.Parse(parts[2]);
                    _text = parts[3];
                }
            }
        }
        public void SetInput(string input)
        {
            _input = input;
        }
        
        public string GetBook()
        {
            return _book;
        }

        public int GetChapter()
        {
            return _chapter;
        }
        public int GetVerse()
        {
            return _verse;
        }
        public int GetEndVerse()
        {
            return _endVerse;
        }
        public string GetText()
        {
            return _text;
        }

        public void Display()
        {
            if (_input == "no" ) 
            {
                Console.WriteLine("What book do you want? ");
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                string findBook = textInfo.ToTitleCase(Console.ReadLine());
                Console.WriteLine("What chapter do you want? ");
                string findChapter = Console.ReadLine();
                Console.WriteLine("What is the first verse? ");
                string findVerse = Console.ReadLine();
                Console.WriteLine("And the last verse? (If is 1 verse, put the same verse again.) ");
                string findEndVerse = Console.ReadLine();
                bool isNotFound = true;
                if (int.Parse(findEndVerse) < int.Parse(findVerse))
                {
                    Console.WriteLine("We could't find that selection of verses.");
                    Console.WriteLine("We will show the last displayed scripture. Press Enter.");
                    Console.ReadLine();
                    isNotFound = false;
                }
                else
                {
                    if (int.Parse(findEndVerse) == int.Parse(findVerse))
                    {
                        string[] lines = System.IO.File.ReadAllLines(_fileName2);
                        
                        foreach (string line in lines)
                        {
                            string[] parts = Regex.Split(line, @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))");
                            parts[5] = parts[5].Replace("\"", string.Empty);
                            if (parts[5] == findBook)
                            {
                        
                                if (parts[14] == findChapter)
                                {
                                    if (parts[15] == findVerse)
                                    {
                                        _book = parts[5];
                                        _chapter = int.Parse(parts[14]);
                                        _verse = int.Parse(parts[15]);
                                        _endVerse = int.Parse(parts[15]);
                                        _text2 = parts[16];
                                        isNotFound = false;
                                    }
                                }
                            }
        
                        }
                    }
                    else
                    {
                        string[] lines = System.IO.File.ReadAllLines(_fileName2);
                        _text2 = string.Empty;
                        foreach (string line in lines)
                        {
                            string[] parts = Regex.Split(line, @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))");
                            
                            parts[5] = parts[5].Replace("\"", string.Empty);
                            if (parts[5] == findBook)
                            {
                        
                                if (parts[14] == findChapter)
                                {
                                    if (int.Parse(parts[15]) >= int.Parse(findVerse) && int.Parse(parts[15]) <= int.Parse(findEndVerse))
                                    {
                                        _book = parts[5];
                                        _chapter = int.Parse(parts[14]);
                                        _verse = int.Parse(findVerse);
                                        _endVerse = int.Parse(parts[15]);
                                        _text2 += $"{parts[16]}\n";
                                        isNotFound = false;
                                    }
                                }
                            }
        
                        }
                        
                    }
                    
                }
                if (isNotFound)
                {
                    Console.WriteLine("We couldn't find the scripture.");
                    Console.WriteLine("We will show the last displayed scripture. Press Enter.");
                    Console.ReadLine();
                }
                else
                {
                    if (_text2 != null)
                    {
                        _text = string.Empty;
                        _text = _text2;
                    }
                    
                    if (!(int.Parse(findEndVerse) < int.Parse(findVerse)))
                    {
                        if (int.Parse(findEndVerse) == int.Parse(findVerse))
                        {
                            using (StreamWriter outputFile = new StreamWriter(_fileName))
                            {                        
                                outputFile.WriteLine($"{_book},{_chapter},{_verse},{_text}");                    
                            }
                        }
                        else
                        {
                            _text = _text.Replace("\n", "~");
                            using (StreamWriter outputFile = new StreamWriter(_fileName))
                            {                        
                                outputFile.WriteLine($"{_book},{_chapter},{_verse},{_endVerse},{_text}");                    
                            }
                            _text = _text.Replace("~", "\n");
                        }
                    }
                    
                }
            }            
        }
    }