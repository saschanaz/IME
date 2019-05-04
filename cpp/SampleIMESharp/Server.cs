using System.Runtime.InteropServices;

namespace SampleIMESharp
{
    partial class SampleIME
    {
        [ComRegisterFunction]
        static void Register()
        {
            ComRegister.RegisterProfiles();
            ComRegister.RegisterCategories();
        }

        [ComUnregisterFunction]
        static void Unregister()
        {
            ComRegister.UnregisterProfiles();
            ComRegister.UnregisterCategories();
        }
    }
}
