using Moq;
using Proxy;
using Xunit;

namespace ProxyUnitTests
{
    public class ServiceTests
    {
        [Fact]
        public void CallProxy_WhenUserAdmin_ThenCallProxyOperationCalled()
        {
            //Arrange
            var consoleMock = new Mock<IConsole>();
            var service = new Service(consoleMock.Object);
            var proxy = new ServiceProxy(service);
            var client = new Client("Admin");

            //Act
            client.Call(proxy);

            //Assert
            consoleMock.Verify(x => x.WriteLine("Admin: Operation called!"), Times.Once);
        }

        [Fact]
        public void CallService_WhenUserStudent_ThenServiceOperationCalled()
        {
            //Arrange
            var consoleMock = new Mock<IConsole>();
            var service = new Service(consoleMock.Object);
            var client = new Client("Student");

            //Act
            client.Call(service);

            //Assert
            consoleMock.Verify(x => x.WriteLine("Student: Operation called!"), Times.Once);
        }

        [Fact]
        public void CallProxy_WhenUserStudent_ThenNoProxyOperationCalled()
        {
            //Arrange
            var consoleMock = new Mock<IConsole>();
            var service = new Service(consoleMock.Object);
            var proxy = new ServiceProxy(service);
            var client = new Client("Student");

            //Act
            client.Call(proxy);

            //Assert
            consoleMock.Verify(x => x.WriteLine(""), Times.Never);
        }
    }
}