using System;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    public partial class SampleIME : ITfTextInputProcessorEx,
        ITfFunctionProvider,
        ITfFunction,
        ITfFnGetPreferredTouchKeyboardLayout
    {
        SampleIME()
        {

        }
        
        // destructor

        // QueryInterface
        // AddRef
        // Release

        HRESULT ITfTextInputProcessorEx.Activate(ITfThreadMgr ptim, uint tid)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfTextInputProcessorEx.Deactivate()
        {
            throw new NotImplementedException();
        }

        HRESULT ITfTextInputProcessorEx.ActivateEx(ITfThreadMgr ptim, uint tid, TF_TMAE dwFlags)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfTextInputProcessor.Activate(ITfThreadMgr ptim, uint tid)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfTextInputProcessor.Deactivate()
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
