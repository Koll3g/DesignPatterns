namespace Proxy
{
    public class Service : IService
    {
        private readonly IConsole _console;

        public Service(IConsole console)
        {
            _console = console;
        }
        public void Operation(string user)
        {
            _console.WriteLine($"{user}: Operation called!");
        }
    }
}
