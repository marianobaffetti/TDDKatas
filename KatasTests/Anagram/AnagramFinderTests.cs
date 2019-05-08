using Xunit;
using Katas.Anagram;
using System.Collections.Generic;

namespace KatasTests
{
    public class AnagramFinderTests
    {
        [Fact]
        public void Test1()
        {
            IList<string> validWords = new List<string>{ "the", "eyes", "they", "see"}; 
            AnagramFinder finder = new AnagramFinder(validWords);
            Assert.Throws<AnagramException>(()=> finder.FindTwoWordAnagrams("", ""));
        }

        [Fact]
        public void Test2()
        {
            IList<string> validWords = new List<string>{ "the", "eyes", "they", "see"}; 
            AnagramFinder finder = new AnagramFinder(validWords);
            IList<string> anagrams = finder.FindTwoWordAnagrams("the", "eyes");
            Assert.True(anagrams.Contains("they") && anagrams.Contains("see"));
        }
    }
}