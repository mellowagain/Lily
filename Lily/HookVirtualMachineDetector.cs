using System;
using System.Reflection;

namespace Lily
{
    public class HookVirtualMachineDetector : ILilyHook
    {
        public static bool IsVirtualMachine()
        {
            Console.WriteLine("[Lily] (SEB Invoke) IsVirtualMachine() -> false");
            return false;
        }

        public MethodInfo GetOriginalMethod()
        {
            throw new System.NotImplementedException();
        }
        
        public MethodInfo GetReplacementMethod()
        {
            return typeof(HookVirtualMachineDetector).GetMethod(nameof(IsVirtualMachine));
        }
    }
}
