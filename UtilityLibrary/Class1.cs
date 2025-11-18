using System;

namespace UtilityLibrary
{
    public class Utils
    {
        public static string FormatText(string input)
        {
            return input.ToUpper();
        }

        public static bool ValidateNumber(string input)
        {
            return double.TryParse(input, out _);
        }
    }
}
