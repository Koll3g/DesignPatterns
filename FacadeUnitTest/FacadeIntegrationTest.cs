using Facade;
using Facade.Dao;
using Xunit;

namespace FacadeUnitTest
{
    public class FacadeIntegrationTest
    {
        [Fact]
        public void TestFacadeMethode()
        {
            //arrange
            MyFacade myFacade = new MyFacade();

            //act
            FacadeObject facadeObject = myFacade.GetTotalSumFromCustomer(1, "De");

            //assert
            Assert.Equal(Currency.Euro, facadeObject.Currency);
        }
    }
}
