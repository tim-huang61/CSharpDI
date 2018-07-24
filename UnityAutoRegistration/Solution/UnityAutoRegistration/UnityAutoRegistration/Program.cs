using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Attributes;
using Unity.RegistrationByConvention;

namespace UnityAutoRegistration
{
    public interface IMyMessage
    {
        void Write(string message);
    }

    public class ConsoleMessage : IMyMessage
    {
        public ConsoleMessage()
        {

        }
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
            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies().Where(x=>x.Namespace.Contains("UnityAutoRegistration")),
                WithMappings.FromAllInterfaces,
                WithName.Default,
                WithLifetime.ContainerControlled);

            IMyMessage message = container.Resolve<IMyMessage>();
            message.Write("Vulcan");

            Console.WriteLine();
            Console.WriteLine("顯示 IoC 容器中的所有型別對應");
            foreach (var item in container.Registrations)
            {
                if (item.MappedToType.Name == item.RegisteredType.Name) continue;
                Console.WriteLine($"Name : {item.Name}");
                Console.WriteLine($"RegisteredType : {item.RegisteredType.Name}");
                Console.WriteLine($"MappedToType : {item.MappedToType.Name}");
                Console.WriteLine($"LifetimeManager : {item.LifetimeManager.LifetimeType.Name}");
                Console.WriteLine();
            }

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
