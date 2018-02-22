using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME : ITfActiveLanguageProfileNotifySink
    {
        HRESULT ITfActiveLanguageProfileNotifySink.OnActivated(ref Guid clsid, ref Guid guidProfile, int fActivated)
        {
            throw new NotImplementedException();
        }
    }
}
