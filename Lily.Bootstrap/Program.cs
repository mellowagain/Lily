using System;
using System.Reflection;

namespace Lily.Bootstrap
{
    public static class Program
    {
        
        private static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load("SafeExamBrowser.Client.dll");
            Type type = assembly.GetType("App");

            if (type == null)
            {
                Console.Error.WriteLine("Unable to find SEB. Please put Lily in the same folder.");
                return;
            }

            MethodInfo method = type.GetMethod("Main");

            if (method == null)
            {
                Console.Error.WriteLine("Unable to find SEB main method.");
                return;
            }
            
            Console.WriteLine("Sending off to SEB.");

            // Main() is static so it doesn't need a instance to be invoked
            method.Invoke(null, null);
        }
        
    }
}
