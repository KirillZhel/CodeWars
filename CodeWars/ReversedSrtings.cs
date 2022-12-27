using System;

namespace CodeWars
{
    public class ReversedSrtings
    {
        public static string Solution(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
