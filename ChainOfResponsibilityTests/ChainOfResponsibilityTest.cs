using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using ChainfOfResponsibility;

namespace ChainOfResponsibilityTests
{
    public class ChainOfResponsibilityTest
    {
        [Fact]
        public void Test()
        {
            //arrange
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            //act
            var result = monkey.SetNext(squirrel).SetNext(dog);

            //assert
            result.Should().BeOfType<DogHandler>();
        }
    }
}
