using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME : ITfDisplayAttributeProvider
    {
        private uint _gaDisplayAttributeInput;
        private uint _gaDisplayAttributeConverted;

        HRESULT ITfDisplayAttributeProvider.EnumDisplayAttributeInfo(out IEnumTfDisplayAttributeInfo ppEnum)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfDisplayAttributeProvider.GetDisplayAttributeInfo(ref Guid guid, out ITfDisplayAttributeInfo ppInfo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Because it's expensive to map our display attribute GUID to a TSF
        /// TfGuidAtom, we do it once when Activate is called.
        /// </summary>
        /// <returns></returns>
        private bool _InitDisplayAttributeGuidAtom()
        {
            var pCategoryMgr = new ITfCategoryMgr();

            if (!pCategoryMgr.RegisterGUID(Globals.SampleIMEGuidDisplayAttributeInput, out _gaDisplayAttributeInput).Succeeded)
            {
                return false;
            }

            if (!pCategoryMgr.RegisterGUID(Globals.SampleIMEGuidDisplayAttributeConverted, out _gaDisplayAttributeConverted).Succeeded)
            {
                return false;
            }

            return true;
        }
    }
}
