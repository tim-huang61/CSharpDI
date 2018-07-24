using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public interface IMessage
    {
        void Send();
    }

    public class Email : IMessage
    {
        public void Send()
        {
        }
    }

    public class Notification
    {
        IMessage _Message;
        public Notification(IMessage message)
        {
            _Message = message;
        }
        public void Notify()
        {
            _Message.Send();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
