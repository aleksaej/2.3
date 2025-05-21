using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = new ClassLibrary1.Text();
            text.AddLine("hello world");
            text.AddLine("this is a test");
            text.AddLine("another line here");

            Console.WriteLine("Original text:");
            Console.WriteLine(text);

            text.CapitalizeFirstLetters();
            Console.WriteLine("\nAfter capitalizing:");
            Console.WriteLine(text);

            text.RemoveLinesContaining("test");
            Console.WriteLine("\nAfter removing lines with 'test':");
            Console.WriteLine(text);

            Console.WriteLine($"\nLength of the longest line: {text.LongestLineLength()}");

            text.Clear();
            Console.WriteLine("\nAfter clearing text:");
            Console.WriteLine(text);

            
            Class2.Demo();
        }
    }
}
