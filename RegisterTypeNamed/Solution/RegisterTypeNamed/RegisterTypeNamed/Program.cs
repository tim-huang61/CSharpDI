using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace RegisterTypeNamed
{
    public interface IMessage
    {
        void Write(string message);
    }

    public class ConsoleMessage : IMessage
    {
        public void Write(string message)
        {
            Console.WriteLine($"訊息: {message} 已經寫入到螢幕上了");
        }
    }

    public class FileMessage : IMessage
    {
        public void Write(string message)
        {
            Console.WriteLine($"訊息: {message} 已經寫入到檔案上了");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IMessage, ConsoleMessage>("Console");
            container.RegisterType<IMessage, FileMessage>();

            Console.WriteLine("每有指名具名名稱");

            IMessage message1 = container.Resolve<IMessage>();
            message1.Write("Hi Vulcan");
            Console.WriteLine("希望使用 ConsoleMessage 的具體實作物件");

            IMessage message2 = container.Resolve<IMessage>("Console");
            message2.Write("Hi Vulcan");

            Console.WriteLine();
            Console.WriteLine("顯示 IoC 容器中的所有型別對應");
            foreach (var item in container.Registrations)
            {
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
