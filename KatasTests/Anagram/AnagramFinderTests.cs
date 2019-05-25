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
            IList<Word> words = new List<Word>();
            AnagramFinder finder = new AnagramFinder(words);
            Assert.Throws<EmptyWordsException>(()=> finder.FindTwoWordAnagrams(new Word(""), new Word("")));
        }

        [Fact]        
        public void LettersQuantityInAnagramsSameAsInInput()
        {
            IList<Word> words = new List<Word>{ new Word("a"), new Word("b"), new Word("cde")};
            AnagramFinder finder = new AnagramFinder(words);
            var anagrams = finder.FindTwoWordAnagrams(new Word("a"),new Word("b"));
            Assert.Equal(2,anagrams.Sum(aWord => aWord.Length()));
        }

        [Fact]
        public void AnagramsShouldBeWords() 
        {
            Word word_a = new Word("a");
            var word_b = new Word("b");
            var word_cde = new Word("cde");

            IList<Word> words = new List<Word>{word_a, word_b, word_cde};
            AnagramFinder finder = new AnagramFinder(words);
            var firstWord = new Word("a");
            var secondWord = new Word("cde");
            var anagrams = finder.FindTwoWordAnagrams(firstWord,secondWord);
            Assert.True(anagrams.All( word => words.Contains(word)));
        }

        [Fact]
        public void AnagramsAreEmptyIfNotFound() 
        {
            var z = new Word("z");
            var x = new Word("x");
            var yyy = new Word("yyy");

            var words = new List<Word>{z, x, yyy};
            AnagramFinder finder = new AnagramFinder(words);
            var firstWord = new Word("a");
            var secondWord = new Word("c");
            var anagrams = finder.FindTwoWordAnagrams(firstWord,secondWord);
            Assert.False(anagrams.Any());
        }
    }
}       