using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace SampleIMESharp
{
    partial class SampleIME
    {
        [ComRegisterFunction]
        public static void Register(Type t)
        {
            ComRegister.RegisterProfiles();
            Thread thread = new Thread(() =>
            {
                ComRegister.RegisterCategories();
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        [ComUnregisterFunction]
        public static void Unregister(Type t)
        {
            ComRegister.UnregisterProfiles();
            Thread thread = new Thread(() =>
            {
                ComRegister.UnregisterCategories();
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
