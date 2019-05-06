using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME : ITfActiveLanguageProfileNotifySink
    {
        private uint _activeLanguageProfileNotifySinkCookie = TextFrameworkDeclarations.TF_INVALID_COOKIE;

        HRESULT ITfActiveLanguageProfileNotifySink.OnActivated(ref Guid clsid, ref Guid guidProfile, int fActivated)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Advise a active language profile notify sink.
        /// </summary>
        /// <returns></returns>
        private bool _InitActiveLanguageProfileNotifySink()
        {
            ITfSource pSource = (ITfSource)_pThreadMgr;

            if (pSource == null)
            {
                return false;
            }

            // IID_ITfActiveLanguageProfileNotifySink
            if (!pSource.AdviseSink(new Guid("B246CB75-A93E-4652-BF8C-B3FE0CFD7E57"), this, out _activeLanguageProfileNotifySinkCookie).Succeeded)
            {
                _activeLanguageProfileNotifySinkCookie = TextFrameworkDeclarations.TF_INVALID_COOKIE;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Unadvise a active language profile notify sink.  Assumes we have advised one already.
        /// </summary>
        private void _UninitActiveLanguageProfileNotifySink()
        {
            if (_activeLanguageProfileNotifySinkCookie == TextFrameworkDeclarations.TF_INVALID_COOKIE)
            {
                return; // never Advised
            }

            ITfSource pSource = (ITfSource)_pThreadMgr;

            if (pSource != null)
            {
                pSource.UnadviseSink(_activeLanguageProfileNotifySinkCookie);
            }

            _activeLanguageProfileNotifySinkCookie = TextFrameworkDeclarations.TF_INVALID_COOKIE;
        }
    }
}
