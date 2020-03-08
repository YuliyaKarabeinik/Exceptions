using Converter;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123";
            var number = StringConverter.ParseString(str);
        }
    }
}
