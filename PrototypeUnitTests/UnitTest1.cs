using FluentAssertions;
using Prototype;
using Xunit;

namespace PrototypeUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void WhenCloneMethodOfCircleIsUsed_ThenObjectAreEqual()
        {
            // arrange
            Circle c1 = new Circle();
            c1.x = 10;
            c1.y = 20;
            c1.radius = 50;

            Circle c2 = new Circle(c1);

            // act
            var equality = c1.Equals(c2);

            // assert
            equality.Should().BeTrue();
        }

        [Fact]
        public void WhenCloneMethodOfRectangleIsUsed_ThenObjectAreEqual()
        {
            // arrange
            Rectangle r1 = new Rectangle();
            r1.x = 10;
            r1.y = 20;
            r1.width = 50;
            r1.height = 50;

            Rectangle r2 = new Rectangle(r1);

            // act
            var equality = r1.Equals(r2);

            // assert
            equality.Should().BeTrue();
        }
    }
}