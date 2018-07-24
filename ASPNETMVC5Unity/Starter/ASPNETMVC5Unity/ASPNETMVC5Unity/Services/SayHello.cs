using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETMVC5Unity.Services
{
    public class SayHello : ISayHello
    {
        public string Hi(string message)
        {
            return $"Hi {message}";
        }
    }
}