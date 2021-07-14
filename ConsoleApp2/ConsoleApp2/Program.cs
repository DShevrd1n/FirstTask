using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom("C:/Users/XoMe/source/repos/ConsoleApp1/ConsoleApp1/bin/Debug/ConsoleApp1.exe");
            Console.WriteLine(asm.FullName);

            Type t = asm.GetType("ConsoleApp1.Person", true, true);

            object obj = Activator.CreateInstance(t);

            MethodInfo method = t.GetMethod("Method1");
            object result = method.Invoke(obj, new object[] { });

            Console.WriteLine((result));
            Console.ReadLine();
        }
    }
}
