using System;

namespace Exercise02
{
    internal class SumOrProduct
    {
        public int Sum(int input)
        {
            int result = 0;
            for (int i=1; i<=input; i++)
            {
                result += i;
            }
            return result;
        }
        public int Product(int input)
        {
            int result = 1;
            for (int i=1; i <=input; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}