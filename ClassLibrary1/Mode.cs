using System;
using System.Reflection;

namespace ClassLibrary1
{
    [Flags]
    //[Obfuscation]
    public enum Mode
    {
        Unknown = 0,
        Mode1 = 1,
        Mode2 = 2
    }
}
