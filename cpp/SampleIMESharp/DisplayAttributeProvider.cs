using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME : ITfDisplayAttributeProvider
    {
        HRESULT ITfDisplayAttributeProvider.EnumDisplayAttributeInfo(out IEnumTfDisplayAttributeInfo ppEnum)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfDisplayAttributeProvider.GetDisplayAttributeInfo(ref Guid guid, out ITfDisplayAttributeInfo ppInfo)
        {
            throw new NotImplementedException();
        }
    }
}
