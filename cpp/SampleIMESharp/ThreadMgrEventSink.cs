using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME : ITfThreadMgrEventSink
    {
        private uint _threadMgrEventSinkCookie = 0xffffffff;

        HRESULT ITfThreadMgrEventSink.OnInitDocumentMgr(ITfDocumentMgr pdim)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfThreadMgrEventSink.OnUninitDocumentMgr(ITfDocumentMgr pdim)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfThreadMgrEventSink.OnSetFocus(ITfDocumentMgr pdimFocus, ITfDocumentMgr pdimPrevFocus)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfThreadMgrEventSink.OnPushContext(ITfContext pic)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfThreadMgrEventSink.OnPopContext(ITfContext pic)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Advise our sink.
        /// </summary>
        /// <returns></returns>
        private bool _InitThreadMgrEventSink()
        {
            ITfSource pSource = (ITfSource)_pThreadMgr;

            if (pSource == null)
            {
                return false;
            }

            // IID_ITfThreadMgrEventSink
            if (!pSource.AdviseSink(new Guid("AA80E80E-2021-11D2-93E0-0060B067B86E"), this, out _threadMgrEventSinkCookie).Succeeded)
            {
                _threadMgrEventSinkCookie = TextFrameworkDeclarations.TF_INVALID_COOKIE;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Unadvise our sink.
        /// </summary>
        private void _UninitThreadMgrEventSink()
        {
            if (_threadMgrEventSinkCookie == TextFrameworkDeclarations.TF_INVALID_COOKIE)
            {
                return;
            }

            ITfSource pSource = (ITfSource)_pThreadMgr;

            if (pSource != null)
            {
                pSource.UnadviseSink(_threadMgrEventSinkCookie);
            }

            _threadMgrEventSinkCookie = TextFrameworkDeclarations.TF_INVALID_COOKIE;
        }
    }
}
