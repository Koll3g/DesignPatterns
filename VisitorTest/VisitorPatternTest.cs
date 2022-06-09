using Xunit;
using FluentAssertions;
using Visitor;

namespace VisitorTest
{
    public class VisitorPatternTest
    {
        [Fact]
        public void ShapeToStringVisitor_VisitCircle_ReturnStringWithRadius()
        {
            // Arrange
            var circle = new Circle(12.5);
            var visitor = new ShapeToStringVisitor();

            // Act
            var result = circle.AcceptVisitor(visitor);

            // Assert
            result.Should().Be("Kreis mit Radius = 12.5");
        }
        [Fact]
        public void ShapeToStringVisitor_VisitRectangle_ReturnStringWithSideLengths()
        {
            // Arrange
            var rectangle = new Rectangle(5.6, 7.9);
            var visitor = new ShapeToStringVisitor();

            // Act
            var result = rectangle.AcceptVisitor(visitor);

            // Assert
            result.Should().Be("Rechteck mit Seitenlängen 5.6 und 7.9");
        }
    }
}