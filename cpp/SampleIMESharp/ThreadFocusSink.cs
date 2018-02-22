using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME : ITfThreadFocusSink
    {
        HRESULT ITfThreadFocusSink.OnSetThreadFocus()
        {
            throw new NotImplementedException();
        }

        HRESULT ITfThreadFocusSink.OnKillThreadFocus()
        {
            throw new NotImplementedException();
        }
    }
}
