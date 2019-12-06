using System;
using System.IO;

namespace day2
{
    class Program
    {
        private static int outPutToMatch = 19690720;
        static void Main(string[] args)
        {
            var intArr = GetOriginalInputArr();
            intArr[1] = 12;
            intArr[2] = 2;
            ProcessNounsAndVerbs(intArr);
        }

        private static void ProcessNounsAndVerbs(int[] intArr)
        {
            for (int noun = 0; noun < 100; noun++)
            {
                for (int verb = 0; verb < 100; verb++)
                {
                    var opArr = GetOriginalInputArr();
                    opArr[1] = noun;
                    opArr[2] = verb;
                    var result = ProcessOpCodes(opArr);
                    if (result[0] == outPutToMatch)
                    {
                        Console.WriteLine(100 * noun + verb);
                        return;
                    }
                }
            }
        }

        private static int[] GetOriginalInputArr()
        {
            var text = File.ReadAllText("input.txt");
            var strArr = text.Split(',');
            var intArr = Array.ConvertAll(strArr, s => int.Parse(s));
            return intArr;
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