using System;
using TSF.TypeLib;

namespace SampleIMESharp
{
    public class SampleIME : ITfTextInputProcessorEx,
        ITfThreadMgrEventSink,
        ITfTextEditSink,
        ITfKeyEventSink,
        ITfCompositionSink,
        ITfDisplayAttributeProvider,
        ITfActiveLanguageProfileNotifySink,
        ITfThreadFocusSink,
        ITfFunctionProvider,
        ITfFnGetPreferredTouchKeyboardLayout
    {

    }
}
