using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME : ITfThreadMgrEventSink
    {
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
    }
}
