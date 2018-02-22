using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME : ITfCompositionSink
    {
        HRESULT ITfCompositionSink.OnCompositionTerminated(uint ecWrite, ITfComposition pComposition)
        {
            throw new NotImplementedException();
        }
    }
}
