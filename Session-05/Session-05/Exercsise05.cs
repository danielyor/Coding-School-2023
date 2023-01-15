using System;

namespace Exercise05
{
    internal class ArraySorter
    {
        public void BubbleSort(int[] input)
        {
            int temp = 0;

            for (int write = 0; write < input.Length; write++)
            {
                for (int sort = 0; sort < input.Length - 1; sort++)
                {
                    if (input[sort] > input[sort + 1])
                    {
                        temp = input[sort + 1];
                        input[sort + 1] = input[sort];
                        input[sort] = temp;
                    }
                }
            }

            Console.WriteLine($"[{String.Join(", ", input)}]");
        }

    }
}