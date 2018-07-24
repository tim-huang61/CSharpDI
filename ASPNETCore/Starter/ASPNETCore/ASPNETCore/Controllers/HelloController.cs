using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore.Controllers
{
    public class HelloController : Controller
    {
        ISayHello _SayHello;
        public HelloController(ISayHello sayHello)
        {
            _SayHello = sayHello;
        }

        public string Index()
        {
            var foo = _SayHello.Hi("Vulcan");
            return foo;
        }
    }
}