using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;
using Unity.Interception.PolicyInjection.Pipeline;

namespace UnityInterception
{
    public interface IMessage
    {
        void Write(string message);
        void Empty();
    }

    public class ConsoleMessage : IMessage
    {
        public void Write(string message)
        {
            Console.WriteLine($"訊息: {message} 已經寫入到檔案上了");
        }
        public void Empty()
        {
            Console.WriteLine($"這是個空的方法");
        }
    }
    public class AppLog : IInterceptionBehavior
    {
        public bool WillExecute => true;

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            //return new Type[] { }; // 若為空型別集合物件，則表示任何物件皆會被攔截
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            IMethodReturn result = null;
            if (input.MethodBase.Name == "Write")
            {
                Console.WriteLine($"(AppLog)呼叫這個方法之前：{input.MethodBase.DeclaringType.Name}.{input.MethodBase.Name}");
                result = getNext()(input, getNext);
                Console.WriteLine($"(AppLog)呼叫這個方法之後：{input.MethodBase.DeclaringType.Name}{input.MethodBase.Name}");
                return result;
            }
            return getNext()(input, getNext);
        }
    }

    public class VirtualLog : IInterceptionBehavior
    {
        public bool WillExecute => true;

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            //return new Type[] { }; // 若為空型別集合物件，則表示任何物件皆會被攔截
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            IMethodReturn result = null;
            if (input.MethodBase.Name == "Empty")
            {
                Console.WriteLine($"(VirtualLog)呼叫這個方法之前：{input.MethodBase.DeclaringType.Name}.{input.MethodBase.Name}");
                result = getNext()(input, getNext);
                Console.WriteLine($"(VirtualLog)呼叫這個方法之後：{input.MethodBase.DeclaringType.Name}{input.MethodBase.Name}");
                return result;
            }
            return getNext()(input, getNext);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();

            var fooInterception = new Interception();
            container.AddExtension(fooInterception);

            container.RegisterType<IMessage, ConsoleMessage>(
                new Interceptor<InterfaceInterceptor>(),
                new InterceptionBehavior<AppLog>(),
                new InterceptionBehavior<VirtualLog>());

            IMessage message = container.Resolve<IMessage>();
            Console.WriteLine($"{Environment.NewLine}呼叫 IMessage.Write");
            message.Write("Hi Vulcan");
            Console.WriteLine($"{Environment.NewLine}呼叫 IMessage.Empty");
            message.Empty();

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
