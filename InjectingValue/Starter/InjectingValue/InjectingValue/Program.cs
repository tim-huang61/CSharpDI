using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectingValue
{
    public interface IMessage
    {
        void Write(string message);
    }
    public class ConsoleMessage : IMessage
    {
        public string Name { get; }
        public int Age { get; }
        public double Cost { get; set; }
        public ConsoleMessage(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public void Write(string message)
        {
            Console.WriteLine($"Name: {Name}  Age: {Age}");
            Console.WriteLine($"Cost: {Cost}");
            Console.WriteLine($"訊息: {message} 已經寫入到螢幕上了");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
