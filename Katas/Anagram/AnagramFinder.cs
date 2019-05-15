using System;
using System.Collections.Generic;
using Katas.Anagram;

namespace Katas.Anagram
{
    public class AnagramFinder
    {
        private Words words;
        public AnagramFinder(Words words)
        {
            this.words = words;
        }

        public IList<string> FindTwoWordAnagrams(string firstWord, string secondWord)
        {
            if (firstWord.IsEmpty())
            {
                throw new EmptyWordsException();
            }

            return new List<string>{"a","b"};
        }

    }
}