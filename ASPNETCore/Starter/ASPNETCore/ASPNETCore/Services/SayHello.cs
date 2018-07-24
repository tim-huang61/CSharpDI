using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore.Services
{
    public class SayHello : ISayHello
    {
        public string Hi(string message)
        {
            return $"Hi {message}";
        }
    }
}
