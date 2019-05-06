using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME
    {
        private bool _InitFunctionProviderSink()
        {
            var pSourceSingle = (ITfSourceSingle)_pThreadMgr;
            if (pSourceSingle == null)
            {
                return false;
            }

            if (!pSourceSingle.AdviseSingleSink(_tfClientId, new Guid("101D6610-0990-11D3-8DF0-00105A2799B5"), this).Succeeded)
            {
                return false;
            }

            throw new NotImplementedException();
        }
    }
}
