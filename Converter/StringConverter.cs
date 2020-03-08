using System;

namespace Converter
{
    public static class StringConverter
    {
        public static int? ParseString(string str)
        {
            try
            {
                return Convert.ToInt32(str);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to convert:Exception: {e.Message}");
                return null;
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Unable to convert:Exception: {e.Message}");
                return null;
            }
        }
    }
}
