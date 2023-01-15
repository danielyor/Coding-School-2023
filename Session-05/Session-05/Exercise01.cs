using System;

namespace Exercise01
{
    internal class StrReverser
    {
        public string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string reversedStr = new string(chars);

            return reversedStr;
        }
    }
}