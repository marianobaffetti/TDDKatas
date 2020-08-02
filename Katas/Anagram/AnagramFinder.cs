using System;
using System.Collections.Generic;
using Katas.Anagram;
using System.Linq;

namespace Katas.Anagram
{
    public class AnagramFinder
    {
        private IList<Word> words;
        public AnagramFinder(IList<Word> words)
        {
            this.words = words;
        }

        public IList<Word> FindTwoWordAnagrams(Word firstWord, Word secondWord)
        {
            if (firstWord.IsEmpty() || secondWord.IsEmpty())
                throw new EmptyWordsException();
                

            if (this.words.Contains(firstWord) && this.words.Contains(secondWord))
                return new List<Word> { firstWord, secondWord };
            else
                return new List<Word>();
        }
    }
}