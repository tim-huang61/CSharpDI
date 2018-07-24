using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace MultiConstructor
{
    interface IDependency1 { }
    class Dependency1 : IDependency1 { }
    interface IDependency2 { }
    class Dependency2 : IDependency2 { }
    interface IDependency3 { }
    class Dependency3 : IDependency3 { }
    interface IDependency4 { }
    class Dependency4 : IDependency4 { }
    interface IInfrastructure
    {
    }

    class Infrastructure : IInfrastructure
    {
        public Infrastructure(IDependency1 d1)
        { Console.WriteLine("使用了需要 1 個參數的建構函式來生成物件"); }
        // 方法一，使用 InjectionConstructor 標註使用這個建構函式來做為預設注入建構函式
        //[InjectionConstructor]
        public Infrastructure(IDependency1 d1, IDependency2 d2)
        { Console.WriteLine("使用了需要 2 個參數的建構函式來生成物件"); }
        public Infrastructure(IDependency1 d1, IDependency2 d2,
            IDependency3 d3)
        { Console.WriteLine("使用了需要 3 個參數的建構函式來生成物件"); }
        public Infrastructure(IDependency1 d1, IDependency2 d2,
            IDependency3 d3, IDependency4 d4)
        { Console.WriteLine("使用了需要 4 個參數的建構函式來生成物件"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IDependency1, Dependency1>();
            container.RegisterType<IDependency2, Dependency2>();
            container.RegisterType<IDependency3, Dependency3>();
            container.RegisterType<IDependency4, Dependency4>();

            #region 這裡使用預設選擇的建構式
            container.RegisterType<IInfrastructure, Infrastructure>();
            container.Resolve<IInfrastructure>();
            #endregion

            #region 這裡使用了 InjectionConstructor 物件，指明要使用甚麼樣建構式簽章函數
            container.RegisterType<IInfrastructure, Infrastructure>(new InjectionConstructor
                (new ResolvedParameter<IDependency1>(), new ResolvedParameter<IDependency2>()));
            container.Resolve<IInfrastructure>();
            #endregion

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
