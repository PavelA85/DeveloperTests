using System;

namespace DeveloperTests
{
    public class Second
    {
        public static string Foo(string argument)
        {
            var charArray = argument.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}