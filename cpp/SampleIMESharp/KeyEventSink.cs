using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME : ITfKeyEventSink
    {
        HRESULT ITfKeyEventSink.OnSetFocus(int fForeground)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfKeyEventSink.OnTestKeyDown(ITfContext pic, UIntPtr wParam, IntPtr lParam, out bool pfEaten)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfKeyEventSink.OnTestKeyUp(ITfContext pic, UIntPtr wParam, IntPtr lParam, out bool pfEaten)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfKeyEventSink.OnKeyDown(ITfContext pic, UIntPtr wParam, IntPtr lParam, out bool pfEaten)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfKeyEventSink.OnKeyUp(ITfContext pic, UIntPtr wParam, IntPtr lParam, out bool pfEaten)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfKeyEventSink.OnPreservedKey(ITfContext pic, ref Guid rguid, out bool pfEaten)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Advise a keystroke sink.
        /// </summary>
        /// <returns></returns>
        private bool _InitKeyEventSink()
        {
            ITfKeystrokeMgr pKeystrokeMgr = (ITfKeystrokeMgr)_pThreadMgr;

            if (pKeystrokeMgr == null)
            {
                return false;
            }

            return pKeystrokeMgr.AdviseKeyEventSink(_tfClientId, this, 1).Succeeded;
        }

        /// <summary>
        /// Unadvise a keystroke sink.  Assumes we have advised one already.
        /// </summary>
        /// <returns></returns>
        private void _UninitKeyEventSink()
        {
            ITfKeystrokeMgr pKeystrokeMgr = (ITfKeystrokeMgr)_pThreadMgr;

            if (pKeystrokeMgr == null)
            {
                return;
            }

            pKeystrokeMgr.UnadviseKeyEventSink(_tfClientId);
        }
    }
}
