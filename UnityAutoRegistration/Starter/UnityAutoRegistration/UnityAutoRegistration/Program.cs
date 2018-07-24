using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityAutoRegistration
{
    public interface IMessage
    {
        void Write(string message);
    }

    public class ConsoleMessage : IMessage
    {
        public void Write(string message)
        {
            Console.WriteLine($"此物件的 HashCode {this.GetHashCode()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
