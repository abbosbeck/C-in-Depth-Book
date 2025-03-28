﻿namespace Part2
{
    class YieldType
    {
        public IEnumerable<int> Numbers()
        {
            yield return SumNumber(5, 10);
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
            yield return 7;
            yield return 8;
            yield return 9;
            yield return 10;
            yield return 11;
            yield return 12;
            yield return 13;
            yield return 14;
        }

        public int SumNumber(int a, int b)
            => a + b;


        public static IEnumerable<int> Fibonacci()
        {
            int current = 0,
                next = 1;
            while (true)
            {
                yield return current;
                int oldCurrent = current;
                current = next;
                next = oldCurrent + next;
            }
        }

        public static IEnumerable<string> Iterator()
        {
            try
            {
                Console.WriteLine("Before first yield");
                yield return "first";
                Console.WriteLine("Between yields");
                yield return "second";
                Console.WriteLine("After second yield");
            }
            finally
            {
                Console.WriteLine("In finally block");
            }
        }

        public static IEnumerable<int> GenerateIntegers(int count)
        {
            try
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Yielding {0}", i);
                    yield return i;
                    int doubled = i * 2;
                    Console.WriteLine("Yielding {0}", doubled);
                    yield return doubled;
                }
            }
            finally
            {
                Console.WriteLine("In finally block");
            }
        }
    }
}
