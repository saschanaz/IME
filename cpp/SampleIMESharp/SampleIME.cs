using System;
using System.Diagnostics;
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
        private ITfThreadMgr _pThreadMgr = null;
        private uint _tfClientId;
        private TF_TMAE _dwActivateFlags;

        public SampleIME()
        {
            Debug.Assert(false);
        }

        // destructor

        public HRESULT Activate(ITfThreadMgr ptim, uint tid)
        {
            return ActivateEx(ptim, tid, 0);
        }

        public HRESULT ActivateEx(ITfThreadMgr pThreadMgr, uint tfClientId, TF_TMAE dwFlags)
        {
            _pThreadMgr = pThreadMgr;
            _tfClientId = tfClientId;
            _dwActivateFlags = dwFlags;

            try
            {
                if (!_InitThreadMgrEventSink())
                {
                    throw new Exception();
                }

                if (pThreadMgr.GetFocus(out ITfDocumentMgr pDocMgrFocus).Succeeded && pDocMgrFocus != null)
                {
                    _InitTextEditSink(pDocMgrFocus);
                }

                if (!_InitKeyEventSink())
                {
                    throw new Exception();
                }

                if (!_InitActiveLanguageProfileNotifySink())
                {
                    throw new Exception();
                }

                if (!_InitThreadFocusSink())
                {
                    throw new Exception();
                }

                if (!_InitDisplayAttributeGuidAtom())
                {
                    throw new Exception();
                }

                if (!_InitFunctionProviderSink())
                {
                    throw new Exception();
                }

                // ...

                return new HRESULT { Code = 0 };
            }
            catch (Exception err)
            {
                Deactivate();
                throw err;
            }
        }

        public HRESULT Deactivate()
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

        ITfThreadMgr ThreadMgr
        {
            get
            {
                return _pThreadMgr;
            }
        }

        uint ClientId
        {
            get
            {
                return _tfClientId;
            }
        }

        bool IsSecureMode
        {
            get
            {
                return Convert.ToBoolean((_dwActivateFlags & TF_TMAE.TF_TMAE_SECUREMODE));
            }
        }

        bool IsComLess
        {
            get
            {
                return Convert.ToBoolean((_dwActivateFlags & TF_TMAE.TF_TMAE_COMLESS));
            }
        }
    }
}
