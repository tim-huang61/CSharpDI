using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExplicitImp
{
    interface IControl
    {
        void Paint();
    }

    interface ISurface
    {
        void Paint();
    }

    class SampleClass : IControl, ISurface
    {
        public void Paint()
        {
            Console.WriteLine("這是 SampleClass 的 Paint方法實作");
        }

        void IControl.Paint()
        {
            Console.WriteLine("這是 IControl 的 Paint方法實作");
        }

        void ISurface.Paint()
        {
            Console.WriteLine("這是 ISurface 的 Paint方法實作");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SampleClass fooSampleClass = new SampleClass();
            IControl fooIControl = (IControl)fooSampleClass;
            ISurface fooISurface = (ISurface)fooSampleClass;

            Console.WriteLine($"fooSampleClass.Paint() 的執行結果");
            fooSampleClass.Paint();
            Console.WriteLine($"fooIControl.Paint() 的執行結果");
            fooIControl.Paint();
            Console.WriteLine($"fooISurface.Paint() 的執行結果");
            fooISurface.Paint();


            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();

        }
    }

}
