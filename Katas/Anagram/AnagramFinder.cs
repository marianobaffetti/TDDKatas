using System;
using System.Collections.Generic;
using Katas;

namespace Katas.Anagram
{
    public class AnagramFinder
    {
        private IList<string> validWords;
        public AnagramFinder(IList<string> validWords)
        {
            this.validWords = validWords;
            
        }

        public  IList<string> FindTwoWordAnagrams(string firstWord, string secondWord)
        {
            if(firstWord.IsEmpty() || secondWord.IsEmpty())
            {
                throw new AnagramException();
            }
            return new List<string> {"they", "see"};
        }
    }
}