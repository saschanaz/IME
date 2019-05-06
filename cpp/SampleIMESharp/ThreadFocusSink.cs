using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME : ITfThreadFocusSink
    {
        private uint _dwThreadFocusSinkCookie;

        HRESULT ITfThreadFocusSink.OnSetThreadFocus()
        {
            throw new NotImplementedException();
        }

        HRESULT ITfThreadFocusSink.OnKillThreadFocus()
        {
            throw new NotImplementedException();
        }

        private bool _InitThreadFocusSink()
        {
            ITfSource pSource = (ITfSource)_pThreadMgr;

            if (pSource == null)
            {
                return false;
            }

            // IID_ITfThreadMgrEventSink
            if (!pSource.AdviseSink(new Guid("C0F1DB0C-3A20-405C-A303-96B6010A885F"), this, out _dwThreadFocusSinkCookie).Succeeded)
            {
                return false;
            }

            return true;
        }

        private void _UninitThreadFocusSink()
        {
            ITfSource pSource = (ITfSource)_pThreadMgr;

            if (pSource != null)
            {
                pSource.UnadviseSink(_dwThreadFocusSinkCookie);
            }
        }
    }
}
