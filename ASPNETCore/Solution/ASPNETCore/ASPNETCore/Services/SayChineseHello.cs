using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore.Services
{
    public class SayChineseHello : ISayHello
    {
        public string Hi(string message)
        {
            return $"你好 {message}";
        }
    }
}
