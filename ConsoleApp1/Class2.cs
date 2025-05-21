using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    public class Class2
    {
        public static void Demo()
        {
            var text = new ClassLibrary1.Text();
            text.AddLine("another class using the library");
            text.CapitalizeFirstLetters();
            Console.WriteLine("\n[Class2.Demo Output]");
            Console.WriteLine(text);
        }
    }
}
