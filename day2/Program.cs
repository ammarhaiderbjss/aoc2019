using System;
using System.IO;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("input.txt");
            var strArr = text.Split(',');
            var intArr = Array.ConvertAll(strArr, s => int.Parse(s));
            intArr[1] = 12;
            intArr[2] = 2;
            var result = ProcessOpCodes(intArr);

            Console.WriteLine(result[0]);
        }

        private static int[] ProcessOpCodes(int[] intArr)
        {
            var position = 0;
            var opCode = intArr[position];
            while (opCode != 99)
            {
                var first = intArr[intArr[position + 1]];
                var second = intArr[intArr[position + 2]];
                switch (opCode)
                {
                    case 1:
                        intArr[intArr[position + 3]] = first + second;
                        break;
                    case 2:
                        intArr[intArr[position + 3]] = first * second;
                        break;
                }
                position += 4;
                opCode = intArr[position];
            }
            return intArr;
        }
    }
}