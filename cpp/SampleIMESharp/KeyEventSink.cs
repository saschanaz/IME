using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME : ITfKeyEventSink
    {
        HRESULT ITfKeyEventSink.OnSetFocus(int fForeground)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfKeyEventSink.OnTestKeyDown(ITfContext pic, UIntPtr wParam, IntPtr lParam, out bool pfEaten)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfKeyEventSink.OnTestKeyUp(ITfContext pic, UIntPtr wParam, IntPtr lParam, out bool pfEaten)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfKeyEventSink.OnKeyDown(ITfContext pic, UIntPtr wParam, IntPtr lParam, out bool pfEaten)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfKeyEventSink.OnKeyUp(ITfContext pic, UIntPtr wParam, IntPtr lParam, out bool pfEaten)
        {
            throw new NotImplementedException();
        }

        HRESULT ITfKeyEventSink.OnPreservedKey(ITfContext pic, ref Guid rguid, out bool pfEaten)
        {
            throw new NotImplementedException();
        }
    }
}
