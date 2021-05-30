using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindrome
{
    public static class Palindrome
    {
        public static bool IsPermutationPalindrome(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (var symbol in str)
            {
                if (char.IsLetter(symbol))
                {
                    var lowerSymbol = char.ToLower(symbol);
                    
                    if (dictionary.ContainsKey(lowerSymbol))
                    {
                        dictionary[lowerSymbol]++;
                    }
                    else
                    {
                        dictionary[lowerSymbol] = 1;
                    }
                }
            }

            return dictionary.Count(pair => pair.Value % 2 == 1) < 2;
        }
    }
}