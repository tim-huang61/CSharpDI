using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling
{
    public class MyService
    {
        public void Run()
        {
            Console.WriteLine("MyService 正在執行中");
        }
    }

    public class Client
    {
        private MyService _service;

        public Client()
        {
            // 建立 Client & MyService 類別間的耦合關係
            Console.WriteLine("(Client 類別建構式) : 使用 new 建立一個新的 MyService 執行個體");
            this._service = new MyService();
        }
        public void Start()
        {
            Console.WriteLine("MyService 啟動");
            this._service.Run();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("具有緊密耦合的範例");
            Console.WriteLine("主程式啟動與執行中");
            new Client().Start();

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
