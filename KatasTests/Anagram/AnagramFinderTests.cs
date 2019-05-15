using Xunit;
using Katas.Anagram;
using System.Collections.Generic;
using System.Linq;

namespace KatasTests.Anagram
{
    public class AnagramFinderTests
    {
        [Fact]
        public void EmptyWordsThrowException()
        {
            Words words = new Words(new List<string>());
            AnagramFinder finder = new AnagramFinder(words);
            Assert.Throws<EmptyWordsException>(()=> finder.FindTwoWordAnagrams("", ""));
        }

        [Fact]        
        public void LettersQuantityInResultSameAsInInput()
        {
            Words words = new Words(new List<string>{ "a", "b", "cde"});
            AnagramFinder finder = new AnagramFinder(words);
            var anagrams = finder.FindTwoWordAnagrams("a","b");
            Assert.Equal(2,anagrams.Sum(aWord => aWord.Length));
        }

        [Fact]
        public void AnagramsShouldBeWords() 
        {
            Words words = new Words(new List<string>{ "a", "b", "cde"});
            AnagramFinder finder = new AnagramFinder(words);
            var firstWord = "a";
            var secondWord = "c";
            var anagrams = finder.FindTwoWordAnagrams(firstWord,secondWord);
            Assert.True(words.Contains(anagrams));
        }
    }
}