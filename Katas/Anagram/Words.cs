using System.Collections.Generic;
using System.Linq;

namespace Katas.Anagram
{
    public class Words
    {
        private IList<string> words;
        public Words(IList<string> words)
        {
            this.words = words;
        }

        public int CountLetters()
        {
            return this.words.Sum(aWord => aWord.Length);
        }

        public bool Contains(string aWord)
        {
            return this.words.Contains(aWord);
        }

         public bool Contains(IList<string> words)
        {
            return words.All(aWord => this.Contains(aWord));
        }
    }
}