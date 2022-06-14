using FluentAssertions;
using Iterator;

namespace IteratorUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CreateCollection_ItereateOverCollection_ResultTrueIfIteratingEnds()
        {
            // arrange
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            // act
            var iterator = a.CreateIterator();

            // assert
            iterator.Should().Be("Iterating over collection");
        }
    }
}