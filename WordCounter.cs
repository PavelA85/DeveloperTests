using System;
using System.Collections.Generic;

namespace DeveloperTests
{
    public class WordCounter
    {
        public static (Dictionary<string, int> byWord, SortedDictionary<int, int> byLenght) Do(string sentence)
        {
            string[] Split(string s) => s
                .Split(new[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var byWord = new Dictionary<string, int>();
            var byLenght = new SortedDictionary<int, int>();

            foreach (var word in Split(sentence))
            {
                byWord[word] = byWord.GetValueOrDefault(word, 0) + 1;
                byLenght[word.Length] = byLenght.GetValueOrDefault(word.Length, 0) + 1;
            }

            return (byWord, byLenght);
        }
    }
}