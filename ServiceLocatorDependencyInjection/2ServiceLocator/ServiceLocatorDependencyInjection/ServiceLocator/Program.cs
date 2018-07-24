using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator
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
        public Client()
        {
            // 在這裡透過 LocateService 服務定位，找到我們需要用的服務物件執行個體
            Console.WriteLine("使用服務定位物件，產生 IService 的具體實作執行個體");
            this._service = LocateService.GetService<IService>();
        }
        public void Start()
        {
            Console.WriteLine("MyService 啟動");
            this._service.Run();
        }

    }

    // 為了要能夠方便使用 LocateService 服務定位，因此，宣告為靜態類別
    public static class LocateService
    {
        public static Dictionary<object, object> servicecontainer = null;
        public static IService _Service { get; set; }

        static LocateService()
        {
            Console.WriteLine("在服務定位類別中，註冊抽象型別需要取得的具體物件對應關係");
            servicecontainer = new Dictionary<object, object>();
            servicecontainer.Add(typeof(IService), new MyService());
        }

        public static T GetService<T>()
        {
            try
            {
                Console.WriteLine("透過服務定位內部資料字典，取出具體實作物件");
                return (T)servicecontainer[typeof(T)];
            }
            catch (Exception ex)
            {
                throw new NotImplementedException("服務不存在");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("使用服務定位來取得具體實作物件之範例");
            Console.WriteLine("主程式啟動與執行中");
            new Client().Start();

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
