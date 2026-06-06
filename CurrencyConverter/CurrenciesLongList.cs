using System.Collections.Generic;

namespace CurrencyConverter

{
    public class CurrenciesLongList
    {
        public static readonly List<string> All = new List<string>
        {
            "AED", "ARS", "AUD", "BGN", "BRL", "BSD", "CAD", "CHF",
            "CLP", "CNY", "COP", "CZK", "DKK", "DOP", "EGP", "EUR",
            "FJD", "GBP", "GTQ", "HKD", "HRK", "HUF", "IDR", "ILS",
            "INR", "ISK", "JPY", "KRW", "KZT", "MXN", "MYR", "NOK",
            "NZD", "PAB", "PEN", "PHP", "PKR", "PLN", "PYG", "RON",
            "RUB", "SAR", "SEK", "SGD", "THB", "TRY", "TWD", "UAH",
            "USD", "UYU", "ZAR"
        };
        
        public static Dictionary<string, string> Load()
        {
            string json = File.ReadAllText("currencies.json");
            return JsonSerializer.Deserialize<Dictionary<string, string>>(json);
        }
    }
}