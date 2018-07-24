using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPWebFormsUnity.Services
{
    public class SayHello : ISayHello
    {
        public SayHello()
        {

        }
        public string Hi(string message)
        {
            return $"Hi {message}";
        }
    }
}