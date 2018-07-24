using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStructureMap
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
            // 這裡可以在建立容器同時進行型別註冊
            //IContainer container = new Container(c =>
            //{
            //    c.For<IMessage>().Use<ConsoleMessage>();
            //});

            IContainer container = new Container();

            container.Configure(config =>
            {
                config.For<IMessage>().Use<ConsoleMessage>();
                config.For<IMessage>().Use<FileMessage>();
                config.For<ILog>().Use<Log>();
            });

            IMessage message = container.GetInstance<IMessage>();

            message.Write("Hi Vulcan");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
