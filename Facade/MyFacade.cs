using Facade.Dao;
using Facade.Service;

namespace Facade
{
    public class MyFacade
    {
        private readonly CountryService _countryService = new CountryService();
        private readonly ShoppingCartService _shoppingCartService = new ShoppingCartService();
        private readonly PaymentService _paymentService = new PaymentService();
        public FacadeObject GetTotalSumFromCustomer(int customerId, string countryCode)
        {
            Currency currency = _countryService.GetCurrency(countryCode);

            IList<Product> products = _shoppingCartService.GetMyProduct(customerId);

            decimal amount = _paymentService.GetAmount(products);

            FacadeObject facadeObject = new FacadeObject
            {
                Amount = amount,
                Currency = currency
            };

            return facadeObject;
        }
    }
}
