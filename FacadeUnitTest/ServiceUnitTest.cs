using Facade.Dao;
using Facade.Service;
using System.Collections.Generic;
using Xunit;

namespace FacadeUnitTest
{
    public class ServiceUnitTest
    {
        [Fact]
        public void Currency_Finde_ReturnFranken()
        {
            //arrange
            CountryService countryService = new CountryService();

            //act
            Currency currency = countryService.GetCurrency("CH");

            //assert
            Assert.Equal(Currency.Franken, currency);
        }

        [Fact]
        public void Amount_Calculate_ReturnSum()
        {
            //arrange
            PaymentService paymentService = new PaymentService();
            IList<Product> products = new List<Product>();
            products.Add(Product.Kaugumi);
            products.Add(Product.Föhn);

            //act
            decimal amount = paymentService.GetAmount(products);

            //assert
            Assert.Equal(31.75m, amount);
        }

        [Fact]
        public void Products_Find_ReturnCorrectCountOfProducts()
        {
            //arrange
            ShoppingCartService shoppingCartService = new ShoppingCartService();

            //act
            IList<Product> products = shoppingCartService.GetMyProduct(1);

            //assert
            Assert.Equal(2, products.Count);
        }
    }
}