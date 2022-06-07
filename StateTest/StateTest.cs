using FluentAssertions;
using Xunit;
using State;

namespace StateTest
{
    public class StateTest
    {
        [Fact]
        public void StateA_TransitionTo_ReturnsStateB()
        {
            var contextA = new Context(new ConcreteStateA());
            contextA.TransitionTo(new ConcreteStateB());
            var typeA = contextA.GetType();

            var contextB = new Context(new ConcreteStateB());
            var typeB = contextB.GetType();

            typeA.Should().BeSameAs(typeB);
        }
    }
}