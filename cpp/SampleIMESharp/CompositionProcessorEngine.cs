using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME
    {
        private CompositionProcessorEngine _pCompositionProcessorEngine;

        private bool _AddTextProcessorEngine()
        {
            LangID langid;
            Guid clsid;
            Guid guidProfile;

            // Get default profile.
            var profile = new ITfInputProcessorProfiles();

            if (!profile.GetCurrentLanguage(out langid).Succeeded)
            {
                return false;
            }

            if (!profile.GetDefaultLanguageProfile(langid, Guids.GUID_TFCAT_TIP_KEYBOARD, out clsid, out guidProfile).Succeeded)
            {
                return false;
            }

            // Is this already added?
            
            if (_pCompositionProcessorEngine == null)
            {
                _pCompositionProcessorEngine = new CompositionProcessorEngine();
            }
            if (_pCompositionProcessorEngine == null)
            {
                return false;
            }

            if (!_pCompositionProcessorEngine.SetupLanguageProfile(langid, guidProfile, ThreadMgr, ClientId, IsSecureMode, IsComLess))
            {
                return false;
            }

            return true;
        }
    }

    class CompositionProcessorEngine
    {
        public bool SetupLanguageProfile(LangID langid, Guid guidLanguageProfile, ITfThreadMgr pThreadMgr, uint tfClientId, bool isSecureMode, bool isComLessMode)
        {
            throw new NotImplementedException();
        }
    }
}
