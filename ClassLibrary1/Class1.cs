using System;

namespace ClassLibraryMCA4_11
{
    public class StringUtils
    {
        public static string SpaceRemover(string input)
        {
            if (input == null)
            {
                return null;
            }
            return input.TrimStart().TrimEnd();
        }
        public static string StringReverser(string input)
        {
            if (input == null)
            {
                return null;
            }
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}