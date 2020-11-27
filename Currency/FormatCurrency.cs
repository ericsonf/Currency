using System.Globalization;

namespace Currency
{
    public class FormatCurrency
    {
        public decimal GetValue(string value)
        {
            decimal.TryParse(value, NumberStyles.Currency, new CultureInfo("pt-BR"), out var convertedValuept);
            decimal.TryParse(value, NumberStyles.Currency, new CultureInfo("en-US"), out var convertedValue);

            var result = convertedValuept <= 0 ? convertedValue
                : convertedValue <= 0 ? convertedValuept
                : convertedValuept > convertedValue ? convertedValue
                : convertedValuept;

            return result;
        }
    }
}
