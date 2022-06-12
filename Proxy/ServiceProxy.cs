namespace Proxy
{
    public class ServiceProxy : IService
    {
        private readonly IService _concreteService;

        public ServiceProxy(IService service)
        {
            _concreteService = service;
        }

        public bool HasAccess(string user)
        {
            return user.Equals("Admin");
        }

        public void Operation(string user)
        {
            if (HasAccess(user))
            {
                _concreteService.Operation(user);
            }
        }
    }
}
