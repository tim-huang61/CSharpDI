using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoorManDI
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

    public static class MyDI
    {
        static readonly Dictionary<Type, Type> Maps = new Dictionary<Type, Type>();

        public static void Register<TAbstractType, TConcreteType>()
        {
            Maps[typeof(TAbstractType)] = typeof(TConcreteType);
        }

        public static TAbstractType Resolve<TAbstractType>()
        {
            Type fooConcreteType = Maps[typeof(TAbstractType)];
            Object instance = Activator.CreateInstance(fooConcreteType);
            return (TAbstractType)instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //MyDI.Register<IMessage, ConsoleMessage>();
            MyDI.Register<IMessage, FileMessage>();

            SendMessage("Hi Poor DI");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();

        }

        private static void SendMessage(string message)
        {
            var fooIMessage = MyDI.Resolve<IMessage>();
            fooIMessage.Write(message);
        }
    }
}
