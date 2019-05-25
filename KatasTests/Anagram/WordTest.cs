using Xunit;
using Katas.Anagram;
using System.Collections.Generic;

namespace KatasTests.Anagram
{
    public class WordTests
    {
        [Fact]
        public void IsEmptyTest()
        {
            var word = new Word("");
            Assert.True(word.IsEmpty());
        }

        [Fact]
        public void WordLengthTest()
        {
            var word = new Word("123");
            Assert.Equal(3, word.Length());
        }

        [Fact]
        public void SameWordTest()
        {
            var word = new Word("123");
            Assert.True(word.SameWordAsString("123"));
        }
    }
}