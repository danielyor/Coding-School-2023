using System;

namespace Exercise04
{
    internal class ArrayMultiplier
    {
        public void MultiplyArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length];
            for (int i=0; i<arr1.Length; i++)
            {
                for (int j=0; j<arr2.Length; j++)
                {
                    result[i] += arr1[i] * arr2[j];
                }
            }

            Console.WriteLine($"[{String.Join(", ", result)}]");
        }

    }
}