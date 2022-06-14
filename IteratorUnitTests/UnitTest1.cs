using FluentAssertions;
using Iterator;

namespace IteratorUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CreateCollection_IterateOverCollection_ResultTrueIfLastItemInColIsItemD()
        {
            // arrange
            ConcreteAggregate col = new ConcreteAggregate();
            col[0] = "Item A";
            col[1] = "Item B";
            col[2] = "Item C";
            col[3] = "Item D";

            string test = null;

            // act
            var iterator = col.CreateIterator();
            var item = iterator.First();

            while (item != null)
            {
                test =(string)item;
                item = iterator.Next();
            }

            // assert
            col[3].Should().BeSameAs(test);
        }
    }
}