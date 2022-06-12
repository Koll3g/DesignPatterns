namespace Proxy
{
    public class Client
    {
        private readonly string _user;

        public Client(string user)
        {
            _user = user;
        }

        public void Call(IService service)
        {
            service.Operation(_user);
        }
    }
}
