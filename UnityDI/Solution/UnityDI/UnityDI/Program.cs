using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Attributes;

namespace UnityDI
{
    public interface IEmployee
    {
        void DisplaySalary();
    }

    public class Employee : IEmployee
    {
        [Dependency]
        public ICompany PropertyInjectionCompany { get; set; }
        public ICompany ConstructorInjectionCompany { get; set; }
        public ICompany MethodInjectionCompany { get; set; }

        [InjectionConstructor]
        public Employee(ICompany tmpCompany)
        {
            ConstructorInjectionCompany = tmpCompany;
        }

        [InjectionMethod]
        public void Initialize(ICompany tmpCompany)
        {
            MethodInjectionCompany = tmpCompany;
        }
        public void DisplaySalary()
        {
            PropertyInjectionCompany.ShowSalary();
            ConstructorInjectionCompany.ShowSalary();
            MethodInjectionCompany.ShowSalary();

            Console.WriteLine($"Property Injection Object Hash Code is {PropertyInjectionCompany.GetHashCode()}");
            Console.WriteLine($"Constructor Injection Object Hash Code is {ConstructorInjectionCompany.GetHashCode()}");
            Console.WriteLine($"Method Injection Object Hash Code is {MethodInjectionCompany.GetHashCode()}");
        }
    }

    public interface ICompany
    {
        void ShowSalary();
    }

    public class Company : ICompany
    {
        public Company()
        {
            Console.WriteLine($"Company Object Hash Code = {this.GetHashCode()}");
        }
        public void ShowSalary()
        {
            Console.WriteLine("你的薪水是 22 K");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer unitycontainer = new UnityContainer();
            unitycontainer.RegisterType<ICompany, Company>();
            unitycontainer.RegisterType<IEmployee, Employee>();

            IEmployee emp = unitycontainer.Resolve<IEmployee>();
            emp.DisplaySalary();
            
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
