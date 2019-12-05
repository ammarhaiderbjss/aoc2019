using System;
using System.IO;
using System.Linq;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = File.ReadAllLines("input.txt")
                .Select(long.Parse)
                .Select(num => (num / 3) - 2)
                .Sum();

            Console.WriteLine(result);
        }
    }
}
