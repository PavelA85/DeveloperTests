using System;
using System.Linq;

namespace DeveloperTests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var (byWord, byLenght) = WordCounter.Do("I have a transportation device which is a red bike which I love to ride.");

            Console.WriteLine("First task:");
            Console.WriteLine("byWord:");
            Console.WriteLine(string.Join("\r\n", byWord.Select(x => $"{x.Key}={x.Value}")));
            Console.WriteLine();
            Console.WriteLine("byLenght:");
            Console.WriteLine(string.Join("\r\n", byLenght.Select(x => $"{x.Key}={x.Value}")));
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("Second task:");
            Console.WriteLine("Hello World!");
            var r = StringReverser.Do("Hello World!");
            Console.WriteLine(r);
        }
    }
}
