using System;
using System.Collections.Generic;
using System.Text;

namespace SampleIMESharp
{
    namespace BaseStructure
    {
        enum KEYSTROKE_FUNCTION
        {
            FUNCTION_NONE = 0,
            FUNCTION_INPUT,

            FUNCTION_CANCEL,
            FUNCTION_FINALIZE_TEXTSTORE,
            FUNCTION_FINALIZE_TEXTSTORE_AND_INPUT,
            FUNCTION_FINALIZE_CANDIDATELIST,
            FUNCTION_FINALIZE_CANDIDATELIST_AND_INPUT,
            FUNCTION_CONVERT,
            FUNCTION_CONVERT_WILDCARD,
            FUNCTION_SELECT_BY_NUMBER,
            FUNCTION_BACKSPACE,
            FUNCTION_MOVE_LEFT,
            FUNCTION_MOVE_RIGHT,
            FUNCTION_MOVE_UP,
            FUNCTION_MOVE_DOWN,
            FUNCTION_MOVE_PAGE_UP,
            FUNCTION_MOVE_PAGE_DOWN,
            FUNCTION_MOVE_PAGE_TOP,
            FUNCTION_MOVE_PAGE_BOTTOM,

            // Function Double/Single byte
            FUNCTION_DOUBLE_SINGLE_BYTE,

            // Function Punctuation
            FUNCTION_PUNCTUATION
        };
    }
}
