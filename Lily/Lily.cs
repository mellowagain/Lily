using System;
using System.Collections.Generic;

namespace Lily
{
    public class Lily
    {
        private static readonly List<ILilyHook> Hooks = new List<ILilyHook>()
        {
            new HookVirtualMachineDetector(),
            new HookRemoteSessionDetector()
        };

        static Lily()
        {
            HookManager manager = new HookManager();

            foreach (ILilyHook hook in Hooks)
            {
                manager.Hook(hook.GetOriginalMethod(), hook.GetReplacementMethod());
                Console.WriteLine($"[Lily] Hook success: {hook.GetOriginalMethod().Name} -> {hook.GetReplacementMethod().Name}");
            }
        }
        
    }
}
