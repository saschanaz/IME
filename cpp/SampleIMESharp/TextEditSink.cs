using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME : ITfTextEditSink
    {
        HRESULT ITfTextEditSink.OnEndEdit(ITfContext pic, uint ecReadOnly, ITfEditRecord pEditRecord)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Init a text edit sink on the topmost context of the document.
        /// Always release any previous sink.
        /// </summary>
        /// <param name="pDocMgr"></param>
        /// <returns></returns>
        private bool _InitTextEditSink(ITfDocumentMgr pDocMgr)
        {
            throw new NotImplementedException();
        }
    }
}
