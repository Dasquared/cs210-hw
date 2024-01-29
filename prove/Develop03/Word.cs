using System;

    public class Word
    {
        private bool _isHidden = false;
        private string _word;

        public Word(string word)
        {
            _word = word;
        }

        public string GetWord()
        {
            return _word;
        }

        public bool GetIfIsHidden()
        {
            return _isHidden;
        }
        
        public void Hidden()
        {
            _isHidden = true;
        }        
    }