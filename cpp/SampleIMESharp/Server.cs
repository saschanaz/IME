using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace SampleIMESharp
{
    partial class SampleIME
    {
        [ComRegisterFunction]
        public static void RegisterSTA(Type t)
        {
            Thread thread = new Thread(() => Register());
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        public static void Register()
        {
            try
            {
                ComRegister.RegisterProfiles();
                ComRegister.RegisterCategories();
            }
            catch (Exception err)
            {
                Unregister();
                throw err;
            }
        }

        [ComUnregisterFunction]
        public static void UnregisterSTA(Type t)
        {
            Thread thread = new Thread(() => Unregister());
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        static void Unregister()
        {
            ComRegister.UnregisterProfiles();
            ComRegister.UnregisterCategories();
        }
    }
}
