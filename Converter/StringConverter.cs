using System;
using System.Text.RegularExpressions;

namespace Converter
{
    public static class StringConverter
    {
        private static readonly Regex matchDigitsRegex = new Regex(@"^[-+]?[1-9][0-9]*");

        public static bool IsConvertibleToInt(this string str)
        {
            if (string.IsNullOrEmpty(str)) throw new ArgumentNullException();
            if (!matchDigitsRegex.IsMatch(str)) throw new FormatException();

            long longInt = 0;
            foreach (char c in str)
            {
                longInt *= 10;
                longInt += c - '0';
            }
            if (longInt < Int32.MinValue && longInt > Int32.MaxValue) throw new OverflowException();
            return true;
        }
    }
}
