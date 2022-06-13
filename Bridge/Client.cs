using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Client
    {
        public string ClientCode(Abstraction abstraction)
        {
            var result = abstraction.Operation();

            Console.Write(result);

            return result;
        }
    }
}
