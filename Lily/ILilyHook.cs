using System.Reflection;

namespace Lily
{
    public interface ILilyHook
    {
        MethodInfo GetOriginalMethod();
        
        MethodInfo GetReplacementMethod();
    }
}
