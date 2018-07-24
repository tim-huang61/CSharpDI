using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Email
    {
        public void Send() { }
    }

    public class Notification
    {
        private Email _Email;
        public Notification()
        {
            _Email = new Email();
        }
        public void Notify() { _Email.Send(); }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
