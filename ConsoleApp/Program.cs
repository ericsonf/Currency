using System;
using System.Globalization;
using Currency;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringValue = "1.018,36";

            var formatCurrency = new FormatCurrency();
            var convertedValue = formatCurrency.GetValue(stringValue);

            Console.WriteLine(convertedValue);
            Console.WriteLine(convertedValue.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(convertedValue.ToString("C", NumberFormatInfo.CurrentInfo));
            Console.ReadLine();
        }
    }
}
