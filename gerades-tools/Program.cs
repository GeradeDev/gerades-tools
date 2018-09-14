using System;
using System.Reflection;

namespace gerades_tools
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                var versionString = Assembly.GetEntryAssembly()
                                        .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                                        .InformationalVersion
                                        .ToString();

                Console.WriteLine($"gerade tools v{versionString}");
                Console.WriteLine("-------------");
                return;
            }

            StartMyTools(string.Join(' ', args));
        }

        public static void StartMyTools(string args)
        {
            Console.WriteLine("Off we go");
        }
    }
}
