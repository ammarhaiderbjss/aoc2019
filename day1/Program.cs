using System;
using System.Collections.Generic;
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
                .Select(GetFuelRequiredPartTwo)
                .Sum();

            Console.WriteLine(result);
        }

        public static long GetFuelRequiredPartOne(long mass)
        {
            return mass / 3 - 2;
        }

        public static long GetFuelRequiredPartTwo(long mass)
        {
            long fuelRequired = mass / 3 - 2;

            return fuelRequired <= 0 ? 0 : fuelRequired + GetFuelRequiredPartTwo(fuelRequired);
        }
    }
}
