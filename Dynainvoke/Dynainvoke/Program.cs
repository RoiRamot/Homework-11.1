using System;
using System.Reflection;
using Dynainvoke.Class;

namespace Dynainvoke
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            Console.WriteLine(InvokeHello(a,"roi"));
            Console.WriteLine(InvokeHello(b,"roi"));
            Console.WriteLine(InvokeHello(c,"roi"));
            Console.ReadLine();
        }

        public static string InvokeHello(object obj, string name)
        {
            string methodName = "Hello";
            if (obj!=null)
            {
                Type type = obj.GetType();
                if (type.GetMethod(methodName)!=null)
                {
                    MethodInfo method = type.GetMethod(methodName);

                    object value = method.Invoke(obj, new object[] { name });
                    return value.ToString();
                }
                return "No Method Found";
            }
            return "Object Null";
        }
    }
}
