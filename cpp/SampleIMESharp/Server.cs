using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SampleIMESharp
{
    partial class SampleIME
    {
        [ComRegisterFunction]
        public static void Register(Type t)
        {
            ComRegister.RegisterProfiles();
            ComRegister.RegisterCategories();
        }

        [ComUnregisterFunction]
        public static void Unregister(Type t)
        {
            ComRegister.UnregisterProfiles();
            ComRegister.UnregisterCategories();
        }
    }
}
