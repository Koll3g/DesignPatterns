using Builder;
using FluentAssertions;
using Xunit;



namespace BuilderTests
{
    public class Test
    {
        [Fact]
        public void WhenBuildMinimalProduct_ThenProduct_ContainPartA1()
        {
            //Arrange
            var director = new Director();
            var builder = new ConcreteBuilder();


            director.Builder = builder;

            //Act
            director.BuildMinimalViableProduct();
            var result = builder.GetProduct().ListParts();

            //result
            result.Should().Contain("PartA1", result);

        }



    }
}
