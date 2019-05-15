using Xunit;
using Katas.Anagram;
using System.Collections.Generic;

namespace KatasTests.Anagram
{
    public class WordsTests
    {
        [Fact]
        public void TestCountLetters()
        {
            Words wordsWithoutLetters = new Words(new List<string>());
            Assert.True(wordsWithoutLetters.CountLetters() == 0);
            Words wordsWithLetters = new Words(new List<string>{"a", "abc"});
            Assert.True(wordsWithLetters.CountLetters() == 4);
        }

        [Fact]
        public void ContainsIsTrueWhenWordExists()
        {
            Words words = new Words(new List<string>{"a", "aaa"});
            Assert.True(words.Contains("a"));
        }

        [Fact]
        public void ContainsAgregateIsTrueWhenWordExists()
        {
            Words words = new Words(new List<string>{"a", "aaa", "ddd", "ccc"});
            Assert.True(words.Contains(new List<string>{"a", "aaa"}));
            Assert.False(words.Contains(new List<string>{"a", "c"}));
        }
    }
}