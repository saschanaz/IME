using System;
using System.Collections.Generic;
using TSF.TypeLib;

namespace SampleIMESharp
{
    static class ComRegister
    {
        //static readonly string RegInfo_Prefix_CLSID = "CLSID\\";
        //static readonly string RegInfo_Key_InProSvr32 = "InProcServer32";
        //static readonly string RegInfo_Key_ThreadModel = "ThreadingModel";

        static readonly string TEXTSERVICE_DESC = "Sample IME";

        static readonly IReadOnlyList<Guid> SupportCategories = new Guid[] {
            Guids.GUID_TFCAT_TIP_KEYBOARD,
            Guids.GUID_TFCAT_DISPLAYATTRIBUTEPROVIDER,
            Guids.GUID_TFCAT_TIPCAP_UIELEMENTENABLED,
            Guids.GUID_TFCAT_TIPCAP_SECUREMODE,
            Guids.GUID_TFCAT_TIPCAP_COMLESS,
            Guids.GUID_TFCAT_TIPCAP_INPUTMODECOMPARTMENT,
            Guids.GUID_TFCAT_TIPCAP_IMMERSIVESUPPORT,
            Guids.GUID_TFCAT_TIPCAP_SYSTRAYSUPPORT,
        };

        public static void RegisterProfiles()
        {
            var pITfInputProcessorProfileMgr = new ITfInputProcessorProfileMgr();

            var iconFile = System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName;

            pITfInputProcessorProfileMgr.RegisterProfile(
                Globals.SampleIMECLSID,
                Globals.TEXTSERVICE_LANGID,
                Globals.SampleIMEGuidProfile,
                TEXTSERVICE_DESC.ToCharArray(),
                (uint)TEXTSERVICE_DESC.Length,
                iconFile.ToCharArray(),
                (uint)iconFile.Length,
                Globals.TEXTSERVICE_ICON_INDEX, (IntPtr)null, 0, true, 0);
        }

        public static void UnregisterProfiles()
        {
            var pITfInputProcessorProfileMgr = new ITfInputProcessorProfileMgr();

            pITfInputProcessorProfileMgr.UnregisterProfile(Globals.SampleIMECLSID, Globals.TEXTSERVICE_LANGID, Globals.SampleIMEGuidProfile, 0);
        }

        public static void RegisterCategories()
        {
            var pCategoryMgr = new ITfCategoryMgr();

            foreach (Guid guid in SupportCategories)
            {
                pCategoryMgr.RegisterCategory(Globals.SampleIMECLSID, guid, Globals.SampleIMECLSID);
            }
        }

        public static void UnregisterCategories()
        {
            var pCategoryMgr = new ITfCategoryMgr();

            foreach (Guid guid in SupportCategories)
            {
                pCategoryMgr.UnregisterCategory(Globals.SampleIMECLSID, guid, Globals.SampleIMECLSID);
            }
        }

        //static void RecurseDeleteKey(RegistryKey hParentKey, string lpszKey)
        //{
        //    hParentKey.DeleteSubKeyTree(lpszKey);
        //}

        //static void RegisterServer()
        //{
        //    RegistryKey regKeyHandle;
        //    RegistryKey regSubkeyHandle;
        //    string achIMEKey;
        //    string achFileName;

        //    achIMEKey = RegInfo_Prefix_CLSID + Globals.SampleIMECLSID.ToString("B");

        //    regKeyHandle = Registry.ClassesRoot.CreateSubKey(achIMEKey);
        //    using (regKeyHandle)
        //    {
        //        regKeyHandle.SetValue("", TEXTSERVICE_DESC);

        //        regSubkeyHandle = regKeyHandle.CreateSubKey(RegInfo_Key_InProSvr32);
        //        using (regSubkeyHandle)
        //        {
        //            achFileName = System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName;
        //            regSubkeyHandle.SetValue("", achFileName);
        //            regSubkeyHandle.SetValue(RegInfo_Key_ThreadModel, Globals.TEXTSERVICE_MODEL);
        //        }
        //    }
        //}

        //static void UnregisterServer()
        //{
        //    string achIMEKey = RegInfo_Prefix_CLSID + Globals.SampleIMECLSID.ToString("B");

        //    Registry.ClassesRoot.DeleteSubKeyTree(achIMEKey);
        //}
    }
}
