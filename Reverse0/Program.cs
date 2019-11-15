using System;

namespace Reverse0
{
    class Program
    {
        public static string stringReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            return new string(chars);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(stringReverseString("Hello World!"));
        }
    }
}
