using System;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading;

namespace SharedNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                if (int.TryParse(args[0], out int delay))
                {
                    Console.WriteLine(string.Format("Starting in {0} seconds", delay));
                    for (; delay > 0; delay--)
                    {
                        Console.WriteLine(string.Format("{0}...", delay));
                        Thread.Sleep(1000);
                    }
                }
            }

            string assemblyPath = Path.GetFullPath("./Loadee.dll");
            Assembly assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(assemblyPath);
            Console.WriteLine(assembly.DefinedTypes);
        }
    }
}
