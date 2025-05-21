using System;
using SimpleTextLibrary;

namespace SimpleTextConsoleApp
{
    class Program
    {
        static void Main()
        {
            var text = new Text();

            text.AddLine("hello world");
            text.AddLine("this is a test");
            text.AddLine("sample line");

            Console.WriteLine("Original text:");
            Console.WriteLine(text);

            text.CapitalizeFirstLetters();

            Console.WriteLine("\nAfter capitalizing:");
            Console.WriteLine(text);

            text.RemoveLinesContaining("test");

            Console.WriteLine("\nAfter removing lines with 'test':");
            Console.WriteLine(text);

            Console.WriteLine($"\nLongest line length: {text.LongestLineLength()}");

            text.Clear();

            Console.WriteLine("\nAfter clearing:");
            Console.WriteLine(text);
        }
    }
}
