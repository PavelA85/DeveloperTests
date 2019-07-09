using System;
using System.Collections.Generic;

namespace DeveloperTests
{
    public class First
    {
        public static (Dictionary<string, int> one, Dictionary<int, int> two) Solve(string sentence)
        {
            string[] Split(string s) => s
                .Replace(".", "")
                .Replace(",", "")
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var one = new Dictionary<string, int>();
            var two = new Dictionary<int, int>();

            foreach (var word in Split(sentence))
            {
                one[word] = one.GetValueOrDefault(word, 0) + 1;
                two[word.Length] = two.GetValueOrDefault(word.Length, 0) + 1;
            }

            return (one, two);
        }
    }
}