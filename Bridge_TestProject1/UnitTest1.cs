using Bridge;

namespace Bridge_TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CheckOutput_Contains_ClientCode()
        {
            //Arrange
            Client client = new Client();

            Abstraction abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());

            //Act
            var result = client.ClientCode(abstraction);

            //Assert
            Assert.Contains("Abstract: Base operation with:\nConcreteImplementationA: The result in platform A.\n", result);            
        }
    }
}