using System;
using System.Globalization;
using Currency;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringValue = "1.52";

            var formatCurrency = new FormatCurrency();
            var value = formatCurrency.GetValue(stringValue);

            Console.WriteLine(value);
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(value.ToString("C", NumberFormatInfo.CurrentInfo));
            Console.ReadLine();
        }
    }
}
