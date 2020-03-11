using System;
using Converter;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "22546543218414";

            try
            {
                var isConvertible = StringConverter.IsConvertibleToInt(str);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to convert:Exception: {e.Message}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Unable to convert:Exception: {e.Message}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Unable to convert:Exception: {e.Message}");
            }
        }
    }
}
