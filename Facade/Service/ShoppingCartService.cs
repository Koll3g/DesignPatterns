using Facade.Dao;

namespace Facade.Service
{
    public class ShoppingCartService
    {
        public IList<Product> GetMyProduct(int customerId)
        {
            IList<Product> myProductList = new List<Product>();

            switch (customerId)
            {
                case 1:
                    myProductList.Add(Product.Buch);
                    myProductList.Add(Product.Kaugumi);
                    break;
                case 2:
                    myProductList.Add(Product.Föhn);
                    myProductList.Add(Product.Kaugumi);
                    break;
                case 3:
                    myProductList.Add(Product.Buch);
                    myProductList.Add(Product.Föhn);
                    break;
                default: throw new ArgumentException($"'{customerId}' not implemented");
            };

            return myProductList;
        }
    }
}
