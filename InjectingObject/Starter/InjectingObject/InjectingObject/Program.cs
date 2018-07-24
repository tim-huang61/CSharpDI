using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace InjectingObject
{
    public interface IMessage
    {
        void Write(string message);
    }

    public class ConsoleMessage : IMessage
    {

        public void Write(string message)
        {
            Console.WriteLine($"此物件的 HashCode {this.GetHashCode()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IMessage, ConsoleMessage>();

            IMessage message1 = container.Resolve<IMessage>();
            IMessage message2 = container.Resolve<IMessage>();
            IMessage message3 = container.Resolve<IMessage>();
            message1.Write("Hi Vulcan1");
            message2.Write("Hi Vulcan2");
            message3.Write("Hi Vulcan3");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
