using Facade.Dao;

namespace Facade.Service
{
    public class CountryService
    {
        public Currency GetCurrency(string countryCode)
        {
            if (countryCode != null)
                countryCode = countryCode.ToUpper();

            switch (countryCode)
            {
                case "DE":
                    return Currency.Euro;
                case "CH":
                    return Currency.Franken;
                case "USA":
                    return Currency.Dolar;
                default: throw new ArgumentException($"'{countryCode}' not implemented");
            };
        }
    }
}