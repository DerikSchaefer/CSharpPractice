using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Mathdll;
using System.Reflection;
using System.IO;
using CustomAttributeDemo;
namespace Mod12_UsingReflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // static binding
            // MathCls mathCls = new MathCls();
            string assemblyPath = @"C:\Training\MSSA\20483\PCAD7\Mathdll\bin\Debug\Mathdll.dll";
            object[] parameters = new object[] { 20, 30 };
            var assembly=Assembly.LoadFrom(assemblyPath);
            Console.WriteLine($"Assembly name:{assembly.FullName} from gac: {assembly.GlobalAssemblyCache}");
            var types=assembly.GetTypes(); // all classes, enyms, structures, interfaces
            Console.WriteLine("Type information:");

          foreach (var type in types)
            {
                Console.WriteLine(type.FullName);
                Console.WriteLine($"Exploring {type.FullName} ");
                var methods=type.GetMethods();
                foreach (var method in methods)
                {
                    
                    Console.WriteLine($"Method name is {method.Name}");
                    if(method.Name=="Equals")
                    {
                        break;
                    }
                   if(!method.IsStatic)
                    {

                        // create an object to invoke methods dynamically
                        var dynamic_obj=Activator.CreateInstance(type);

                        var result=type.InvokeMember(method.Name,BindingFlags.InvokeMethod,null,dynamic_obj,parameters);
                        Console.Write("Result is :" + result.ToString());
                    }

                }

            }
            Console.ReadLine();
            Console.WriteLine("Reading Custom Attributes:");
            var type_attribute = typeof(Class1);
            var attributes = type_attribute.GetCustomAttributes(typeof(DeveloperAttribute));
            foreach(var attribute in attributes)
            {
                DeveloperAttribute attr = (DeveloperAttribute)attribute;
                Console.WriteLine($"Attribute values:{attr.Name}");
            }
            Console.ReadLine();


        }
    }
}
