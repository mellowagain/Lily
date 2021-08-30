using System;
using System.Reflection;

namespace Lily
{
    public class HookRemoteSessionDetector : ILilyHook
    {
        public static bool IsRemoteSession()
        {
            Console.WriteLine("[Lily] (SEB Invoke) IsRemoteSession() -> false");
            return false;
        }

        public MethodInfo GetOriginalMethod()
        {
            throw new System.NotImplementedException();
        }

        public MethodInfo GetReplacementMethod()
        {
            return typeof(HookRemoteSessionDetector).GetMethod(nameof(IsRemoteSession));
        }
    }
}