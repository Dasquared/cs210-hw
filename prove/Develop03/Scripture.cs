using System;

    public class Scripture
    {
        private List<Word> _text;
        private Reference _reference;
        
        public Scripture(string book, int chapter, int verse, string text)
        {
            _reference = new Reference(book, chapter, verse);

            _text = new List<Word>();

            string[] listOfWords = text.Split(' ');
            foreach (string word in listOfWords)
            {
                _text.Add(new Word(word));
            }
        }
        public Scripture(string book, int chapter, int verse, int endVerse, string text)
        {
            _reference = new Reference(book, chapter, verse, endVerse);

            _text = new List<Word>();

            string[] listOfWords = text.Split(' ');
            foreach (string word in listOfWords)
            {
                _text.Add(new Word(word));
            }
        }

        public void Display()
        {
            Console.WriteLine($"{_reference}");
            foreach (Word word in _text)
            {
                if (word.GetIfIsHidden())
                {
                    Console.Write(new string('_', word.GetWord().Length) + " ");
                }
                else
                {
                    Console.Write(word.GetWord() + " ");
                }
            }
        }

        private List<Word> GetWords()
        {
            List<Word> wordsNotHidden = new List<Word>();
            foreach (Word word in _text)
            {
                if (!word.GetIfIsHidden())
                    wordsNotHidden.Add(word);
            }
            return wordsNotHidden;
        }
        public bool Hide()
        {
            List<Word> wordsNotHidden = GetWords();
            Random random = new Random();
            
            if (wordsNotHidden.Count() < 2)
            {
                if (wordsNotHidden.Count() != 0)
                {
                int indexOfWord3 = random.Next(wordsNotHidden.Count);
                wordsNotHidden[indexOfWord3].Hidden();
                }
                return false;
            }                
            
            int indexOfWord1 = random.Next(wordsNotHidden.Count);
            int indexOfWord2;

            do
            {
                indexOfWord2 = random.Next(wordsNotHidden.Count);
            } while (indexOfWord1 == indexOfWord2);
            
            wordsNotHidden[indexOfWord1].Hidden();
            wordsNotHidden[indexOfWord2].Hidden();
            wordsNotHidden = GetWords();
            if (wordsNotHidden.Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }    
    }
