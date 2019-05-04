using System;
using System.Runtime.InteropServices;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    [ComVisible(true)]
    [Guid("D2291A80-84D8-4641-9AB2-BDD1472C846B")]
    public partial class SampleIME : ITfTextInputProcessorEx,
        ITfFunctionProvider,
        ITfFunction,
        ITfFnGetPreferredTouchKeyboardLayout
    {
        SampleIME()
        {

        }

        // destructor

        public HRESULT Activate(ITfThreadMgr ptim, uint tid)
        {
            return ActivateEx(ptim, tid, 0);
        }

        public HRESULT Deactivate()
        {
            throw new NotImplementedException();
        }

        public HRESULT ActivateEx(ITfThreadMgr ptim, uint tid, TF_TMAE dwFlags)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfFunctionProvider.GetType(out Guid pguid)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfFunctionProvider.GetDescription(out string pbstrDesc)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfFunctionProvider.GetFunction(ref Guid rguid, ref Guid riid, out object ppunk)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfFunction.GetDisplayName(out string pbstrName)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfFnGetPreferredTouchKeyboardLayout.GetLayout(out TKBLayoutType pTKBLayoutType, out TKBLayoutId pwPreferredLayoutId)
        {
            throw new NotImplementedException();
        }
    }
}
