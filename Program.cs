using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var f = new StreamReader("test.txt");
            var s = f.ReadToEnd();
            Console.WriteLine(s.IndexOf("(", StringComparison.InvariantCultureIgnoreCase));
            Console.ReadLine();
        }
    }
}
