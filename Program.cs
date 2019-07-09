using System;
using System.Linq;

namespace DeveloperTests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var (one, two) = First.Solve("I have a transportation device which is a red bike which I love to ride.");
            Console.WriteLine(string.Join("\r\n", one.Select(x => $"{x.Key}={x.Value}")));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(string.Join("\r\n", two.OrderBy(x=> x.Key).Select(x => $"{x.Key}={x.Value}")));
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Hello World!");
            var r = Second.Foo("Hello World!");
            Console.WriteLine(r);
        }
    }
}
