using System;
using System.Linq;

namespace ReverseString
{
    public static class Extension
    {
        public static bool CheckforNumbers(this string value)
        {
            bool checkString = false;
            checkString = value.Any(char.IsDigit);

            return checkString;
        }
    }
}
