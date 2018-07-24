using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNinject
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
        ILog _Log;
        public FileMessage(ILog log)
        {
            _Log = log;
        }
        public void Write(string message)
        {
            Console.WriteLine($"訊息: {message} 已經寫入到檔案上了");
            _Log.Write(message);
        }
    }

    public interface ILog
    {
        void Write(string message);
    }

    public class Log : ILog
    {
        public void Write(string message)
        {
            Console.WriteLine($"訊息: {message} 已經寫入到 Log 上了");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();

            kernel.Bind<IMessage>().To<ConsoleMessage>();
            kernel.Bind<IMessage>().To<FileMessage>();
            kernel.Bind<ILog>().To<Log>();

            IMessage message = kernel.Get<IMessage>();

            message.Write("Hi Vulcan");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
