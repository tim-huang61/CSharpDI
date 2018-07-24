using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualInjection
{
    public interface IService
    {
        void Run();
    }

    public class MyService : IService
    {
        public void Run()
        {
            Console.WriteLine("MyService 正在執行中");
        }
    }

    public class Client
    {
        private IService _service;
        public Client(IService service)
        {
            Console.WriteLine("透過建構式注入方式，取得 IService 的具體實作執行個體");
            this._service = service;
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
            Console.WriteLine("使用相依性注入(建構式注入)來注入具體實作物件之範例");
            Console.WriteLine("主程式啟動與執行中");
            Console.WriteLine("建立 Client 物件，並且透過建構式，注入需要的 MyService 具體實作物件");
            new Client(new MyService()).Start();

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
