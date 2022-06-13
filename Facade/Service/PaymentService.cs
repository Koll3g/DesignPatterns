using Facade.Dao;

namespace Facade.Service
{
    public class PaymentService
    {
        public decimal GetAmount(IList<Product> products)
        {
            decimal amount = 0;
            foreach (Product product in products)
            {
                switch (product)
                {
                    case Product.Buch:
                        amount += 23.00m;
                        break;
                    case Product.Kaugumi:
                        amount += 1.25m;
                        break;
                    case Product.Föhn:
                        amount += 30.50m;
                        break;
                    default: throw new ArgumentException($"'{product}' not implemented");
                };
            }

            return amount;
        }
    }
}
