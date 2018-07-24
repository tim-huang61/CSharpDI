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

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
