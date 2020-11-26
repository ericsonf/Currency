using System.Globalization;

namespace Currency
{
    public class FormatCurrency
    {
        public decimal GetValue(string value)
        {
            value = value.Replace(",", "").Replace(".", "");
            value = $"{value.Substring(0, (value.Length - 2))},{value.Substring(value.Length - 2)}";
            decimal.TryParse(value, NumberStyles.Any, new CultureInfo("pt-BR"), out var convertedValue);

            return convertedValue;
        }
    }
}
