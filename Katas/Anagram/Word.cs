using System.Collections.Generic;

namespace Katas.Anagram
{

    public class Word
    {
        private string word;
        public Word(string word)
        {
            this.word = word;
        }

        public bool IsEmpty()
        {
            return this.word == "";
        }

        public int Length()
        {
            return this.word.Length;
        }

        public override bool Equals(object obj)
        {
            var aWord = obj as Word;
            if (aWord == null)
            {
                return false;
            }
            return aWord.SameWordAsString(this.word);
        }

        public bool SameWordAsString(string str)
        {
            return this.word == str;
        }
    }
}