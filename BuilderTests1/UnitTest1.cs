using Builder;

namespace BuilderTests1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMinimumViableObject_UsingDirector()
        {
            //Arrange
            var director = new Director();
            var builder = new ConcreteBuilder();

            director.Builder = builder;
            director.BuildMinimalViableProduct();

            //Act
            var result = builder.GetProduct();

            //Assert
            Assert.Equal("PartA1", result._parts[0]);
        }

        [Fact]
        public void TestFullFeaturedObject_UsingDirector()
        {
            //Arrange
            var director = new Director();
            var builder = new ConcreteBuilder();

            director.Builder = builder;
            director.BuildFullFeaturedProduct();

            //Act
            var result = builder.GetProduct();

            //Assert
            Assert.Equal("PartA1", result._parts[0]);
            Assert.Equal("PartB1", result._parts[1]);
            Assert.Equal("PartC1", result._parts[2]);
        }

        [Fact]
        public void WhenListMinimalProduct_ThenString_ContainPartA1()
        {
            //Arrange
            var director = new Director();
            var builder = new ConcreteBuilder();

            director.Builder = builder;

            //Act
            director.BuildMinimalViableProduct();
            var result = builder.GetProduct().ListParts();

            //Assert
            Assert.Contains("PartA1", result);

        }

        [Fact]
        public void WhenListFullProduct_ThenProduct_ContainPartA1B1C1()
        {
            //Arrange
            var director = new Director();
            var builder = new ConcreteBuilder();

            director.Builder = builder;

            //Act
            director.BuildFullFeaturedProduct();
            var result = builder.GetProduct().ListParts();

            //Assert
            Assert.Contains("PartA1, PartB1, PartC1", result);

        }

    }
}