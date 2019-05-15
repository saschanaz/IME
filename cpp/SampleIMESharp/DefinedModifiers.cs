using System;
using System.Collections.Generic;
using System.Text;
using TSF.TypeLib;

namespace SampleIMESharp
{
    class DefinedModifiers
    {
        public static readonly TF_MOD _TF_MOD_ON_KEYUP_SHIFT_ONLY = (TF_MOD)(0x00010000 | (uint)TF_MOD.TF_MOD_ON_KEYUP);
        public static readonly TF_MOD _TF_MOD_ON_KEYUP_CONTROL_ONLY = (TF_MOD)(0x00020000 | (uint)TF_MOD.TF_MOD_ON_KEYUP);
        public static readonly TF_MOD _TF_MOD_ON_KEYUP_ALT_ONLY = (TF_MOD)(0x00040000 | (uint)TF_MOD.TF_MOD_ON_KEYUP);
    }
}
