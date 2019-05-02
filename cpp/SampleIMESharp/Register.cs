using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME
    {
        const string RegInfo_Prefix_CLSID = "CLSID\\";
        const string RegInfo_Key_InProSvr32 = "InProcServer32";
        const string RegInfo_Key_ThreadModel = "ThreadingModel";

        const string TEXTSERVICE_DESC = "Sample IME";

        readonly IReadOnlyList<Guid> SupportCategories = new Guid[] {
            Guids.GUID_TFCAT_TIP_KEYBOARD,
            Guids.GUID_TFCAT_DISPLAYATTRIBUTEPROVIDER,
            Guids.GUID_TFCAT_TIPCAP_UIELEMENTENABLED,
            Guids.GUID_TFCAT_TIPCAP_SECUREMODE,
            Guids.GUID_TFCAT_TIPCAP_COMLESS,
            Guids.GUID_TFCAT_TIPCAP_INPUTMODECOMPARTMENT,
            Guids.GUID_TFCAT_TIPCAP_IMMERSIVESUPPORT,
            Guids.GUID_TFCAT_TIPCAP_SYSTRAYSUPPORT,
        };

        void RegisterProfiles()
        {
            var pITfInputProcessorProfileMgr = new ITfInputProcessorProfileMgr();

            pITfInputProcessorProfileMgr.RegisterProfile(
                Globals.SampleIMECLSID,
                new LangID((0x04 << 10) & 0x02), // MAKELANGID(LANG_CHINESE, SUBLANG_CHINESE_SIMPLIFIED)
                Globals.SampleIMEGuidProfile,
                TEXTSERVICE_DESC.ToCharArray(),
                (uint)TEXTSERVICE_DESC.Length,
                "".ToCharArray(),
                0,
                unchecked((uint)-12), (IntPtr)null, 0, true, 0);
        }
    }
}
