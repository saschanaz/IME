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
            if (_pCompositionProcessorEngine != null)
            {
                LangID langidProfile;
                Guid guidLanguageProfile = _pCompositionProcessorEngine.GetLanguageProfile(out langidProfile);
                if ((langid.LCID == langidProfile.LCID) && guidProfile == guidLanguageProfile)
                {
                    return true;
                }
            }

            // Create composition processor engine
            if (_pCompositionProcessorEngine == null)
            {
                _pCompositionProcessorEngine = new CompositionProcessorEngine();
            }
            if (_pCompositionProcessorEngine == null)
            {
                return false;
            }

            // setup composition processor engine
            if (!_pCompositionProcessorEngine.SetupLanguageProfile(langid, guidProfile, ThreadMgr, ClientId, IsSecureMode, IsComLess))
            {
                return false;
            }

            return true;
        }
    }

    class CompositionProcessorEngine
    {
        private LangID _langid;
        private Guid _guidProfile;
        private uint _tfClientId;

        // Configuration data
        private bool _isWildcard;
        private bool _isDisableWildcardAtFirst;
        private bool _hasMakePhraseFromText;
        private bool _isKeystrokeSort;
        private bool _isComLessMode;

        /// <summary>
        /// Setup language profile for Composition Processor Engine.
        /// </summary>
        /// <param name="langid">Specify language ID</param>
        /// <param name="guidLanguageProfile">Specify GUID language profile which GUID is as same as Text Service Framework language profile.</param>
        /// <param name="pThreadMgr">ITfThreadMgr.</param>
        /// <param name="tfClientId">TfClientId value.</param>
        /// <param name="isSecureMode">secure mode</param>
        /// <param name="isComLessMode"></param>
        /// <returns></returns>
        public bool SetupLanguageProfile(LangID langid, Guid guidLanguageProfile, ITfThreadMgr pThreadMgr, uint tfClientId, bool isSecureMode, bool isComLessMode)
        {
            if ((tfClientId == 0) && (pThreadMgr == null))
            {
                return false;
            }

            _isComLessMode = isComLessMode;
            _langid = langid;
            _guidProfile = guidLanguageProfile;
            _tfClientId = tfClientId;

            SetupPreserved(pThreadMgr, tfClientId);
            InitializeSampleIMECompartment(pThreadMgr, tfClientId);
            SetupPunctuationPair();
            SetupLanguageBar(pThreadMgr, tfClientId, isSecureMode);
            SetupKeystroke();
            SetupConfiguration();
            SetupDictionaryFile();

            return true;
        }

        /// <summary>
        /// Get language profile.
        /// </summary>
        /// <param name="plangid"></param>
        /// <returns></returns>
        public Guid GetLanguageProfile(out LangID plangid)
        {
            plangid = _langid;
            return _guidProfile;
        }

        public LangID GetLocale()
        {
            return _langid;
        }

        private void SetupKeystroke()
        {
            throw new NotImplementedException();
        }

        private void SetupPreserved(ITfThreadMgr pThreadMgr, uint tfClientId)
        {
            throw new NotImplementedException();
        }

        private void SetupConfiguration()
        {
            throw new NotImplementedException();
        }

        private void SetupLanguageBar(ITfThreadMgr pThreadMgr, uint tfClientId, bool isSecureMode)
        {
            throw new NotImplementedException();
        }

        private void SetupPunctuationPair()
        {
            throw new NotImplementedException();
        }

        private void InitializeSampleIMECompartment(ITfThreadMgr pThreadMgr, uint tfClientId)
        {
            throw new NotImplementedException();
        }

        private bool SetupDictionaryFile()
        {
            throw new NotImplementedException();
        }
    }
}
