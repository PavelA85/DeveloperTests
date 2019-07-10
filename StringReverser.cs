using System;

namespace DeveloperTests
{
    public class StringReverser
    {
        public static string Do(string input)
        {
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}