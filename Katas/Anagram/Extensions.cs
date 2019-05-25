using System.Collections.Generic;
using System.Linq;

namespace Katas.Anagram
{
    public static class ExtensionsClass
    {
        public static bool IsEmpty(this string str)
        {
            return str == string.Empty;
        }

        public static IList<string> LettersAsList(this string str)
        {
            return str.Select(c => c.ToString()).ToList<string>();
        }
    }

}

