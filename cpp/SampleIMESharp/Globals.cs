﻿using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;

namespace SampleIMESharp
{
    static class Globals
    {
        public static readonly int SUBLANG_ENGLISH_US = 0x01;
        public static readonly int LANG_ENGLISH = 0x09;
        public static readonly int IDIS_SAMPLEIME = 12;
        public static readonly int IDS_DEFAULT_FONT = 13;
        public static readonly int IDS_IME_MODE = 20;
        public static readonly int IDI_IME_MODE_ON = 21;
        public static readonly int IDI_IME_MODE_OFF = 22;
        public static readonly int IDS_DOUBLE_SINGLE_BYTE = 23;
        public static readonly int IDI_DOUBLE_SINGLE_BYTE_ON = 24;
        public static readonly int IDI_DOUBLE_SINGLE_BYTE_OFF = 25;
        public static readonly int IDS_PUNCTUATION = 26;
        public static readonly int IDI_PUNCTUATION_ON = 27;
        public static readonly int IDI_PUNCTUATION_OFF = 28;
        public static readonly int IDR_VERSION2 = 107;

        public static readonly string TEXTSERVICE_MODEL = "Apartment";
        // MAKELANGID(LANG_CHINESE, SUBLANG_CHINESE_SIMPLIFIED)
        public static readonly LangID TEXTSERVICE_LANGID = new LangID((0x02 << 10) | 0x04);
        public static readonly uint TEXTSERVICE_ICON_INDEX = unchecked((uint)-12);
        public static readonly string TEXTSERVICE_DIC = "SampleIMESimplifiedQuanPin.txt";

        public static readonly int IME_MODE_ON_ICON_INDEX = IDI_IME_MODE_ON;
        public static readonly int IME_MODE_OFF_ICON_INDEX = IDI_IME_MODE_OFF;
        public static readonly int IME_DOUBLE_ON_INDEX = IDI_DOUBLE_SINGLE_BYTE_ON;
        public static readonly int IME_DOUBLE_OFF_INDEX = IDI_DOUBLE_SINGLE_BYTE_OFF;
        public static readonly int IME_PUNCTUATION_ON_INDEX = IDI_PUNCTUATION_ON;
        public static readonly int IME_PUNCTUATION_OFF_INDEX = IDI_PUNCTUATION_OFF;

        //---------------------------------------------------------------------
        // SampleIME CLSID
        //---------------------------------------------------------------------
        // {D2291A80-84D8-4641-9AB2-BDD1472C846B}
        public static readonly Guid SampleIMECLSID = new Guid(
            0xd2291a80,
            0x84d8,
            0x4641,
            0x9a, 0xb2, 0xbd, 0xd1, 0x47, 0x2c, 0x84, 0x6b
        );

        //---------------------------------------------------------------------
        // Profile GUID
        //---------------------------------------------------------------------
        // {83955C0E-2C09-47a5-BCF3-F2B98E11EE8B}
        public static readonly Guid SampleIMEGuidProfile = new Guid(
            0x83955c0e,
            0x2c09,
            0x47a5,
            0xbc, 0xf3, 0xf2, 0xb9, 0x8e, 0x11, 0xee, 0x8b
        );

        //---------------------------------------------------------------------
        // PreserveKey GUID
        //---------------------------------------------------------------------
        // {4B62B54B-F828-43B5-9095-A96DF9CBDF38}
        public static readonly Guid SampleIMEGuidImeModePreserveKey = new Guid(
            0x4b62b54b,
            0xf828,
            0x43b5,
            0x90, 0x95, 0xa9, 0x6d, 0xf9, 0xcb, 0xdf, 0x38
        );

        // {5A08D6C4-4563-4E46-8DDB-65E75C4E73A3}
        public static readonly Guid SampleIMEGuidDoubleSingleBytePreserveKey = new Guid(
            0x5a08d6c4,
            0x4563,
            0x4e46,
            0x8d, 0xdb, 0x65, 0xe7, 0x5c, 0x4e, 0x73, 0xa3
        );

        // {175F062E-B961-4AED-A3DF-59F78A02862D}
        public static readonly Guid SampleIMEGuidPunctuationPreserveKey = new Guid(
            0x175f062e,
            0xb961,
            0x4aed,
            0xa3, 0xdf, 0x59, 0xf7, 0x8a, 0x2, 0x86, 0x2d
        );

        //---------------------------------------------------------------------
        // Compartments
        //---------------------------------------------------------------------
        // {101011C5-CF72-4F0C-A515-153019593F10}
        public static readonly Guid SampleIMEGuidCompartmentDoubleSingleByte = new Guid(
            0x101011c5,
            0xcf72,
            0x4f0c,
            0xa5, 0x15, 0x15, 0x30, 0x19, 0x59, 0x3f, 0x10
        );

        // {DD321BCC-A7F8-4561-9B61-9B3508C9BA97}
        public static readonly Guid SampleIMEGuidCompartmentPunctuation = new Guid(
            0xdd321bcc,
            0xa7f8,
            0x4561,
            0x9b, 0x61, 0x9b, 0x35, 0x8, 0xc9, 0xba, 0x97
        );


        //---------------------------------------------------------------------
        // LanguageBars
        //---------------------------------------------------------------------

        // {89BE500C-9462-4070-9DB0-B467BB051327}
        public static readonly Guid SampleIMEGuidLangBarIMEMode = new Guid(
            0x89be500c,
            0x9462,
            0x4070,
            0x9d, 0xb0, 0xb4, 0x67, 0xbb, 0x5, 0x13, 0x27
        );

        // {6A11D9DE-46DB-455B-A257-2EB615746BF4}
        public static readonly Guid SampleIMEGuidLangBarDoubleSingleByte = new Guid(
            0x6a11d9de,
            0x46db,
            0x455b,
            0xa2, 0x57, 0x2e, 0xb6, 0x15, 0x74, 0x6b, 0xf4
        );

        // {F29C731A-A51E-49FB-8A3C-EE51752912E2}
        public static readonly Guid SampleIMEGuidLangBarPunctuation = new Guid(
            0xf29c731a,
            0xa51e,
            0x49fb,
            0x8a, 0x3c, 0xee, 0x51, 0x75, 0x29, 0x12, 0xe2
        );

        // {4C802E2C-8140-4436-A5E5-F7C544EBC9CD}
        public static readonly Guid SampleIMEGuidDisplayAttributeInput = new Guid(
            0x4c802e2c,
            0x8140,
            0x4436,
            0xa5, 0xe5, 0xf7, 0xc5, 0x44, 0xeb, 0xc9, 0xcd
        );

        // {9A1CC683-F2A7-4701-9C6E-2DA69A5CD474}
        public static readonly Guid SampleIMEGuidDisplayAttributeConverted = new Guid(
            0x9a1cc683,
            0xf2a7,
            0x4701,
            0x9c, 0x6e, 0x2d, 0xa6, 0x9a, 0x5c, 0xd4, 0x74
        );


        //---------------------------------------------------------------------
        // UI element
        //---------------------------------------------------------------------

        // {84B0749F-8DE7-4732-907A-3BCB150A01A8}
        public static readonly Guid SampleIMEGuidCandUIElement = new Guid(
            0x84b0749f,
            0x8de7,
            0x4732,
            0x90, 0x7a, 0x3b, 0xcb, 0x15, 0xa, 0x1, 0xa8
        );


        //---------------------------------------------------------------------
        // Unicode byte order mark
        //---------------------------------------------------------------------
        public static readonly char UnicodeByteOrderMark = (char)0xFEFF;

        //---------------------------------------------------------------------
        // dictionary table delimiter
        //---------------------------------------------------------------------
        public static readonly char KeywordDelimiter = '=';
        public static readonly char StringDelimiter = '\"';

        //---------------------------------------------------------------------
        // defined item in setting file table [PreservedKey] section
        //---------------------------------------------------------------------
        public static readonly string ImeModeDescription = "Chinese/English input (Shift)";
        public static readonly int ImeModeOnIcoIndex = IME_MODE_ON_ICON_INDEX;
        public static readonly int ImeModeOffIcoIndex = IME_MODE_OFF_ICON_INDEX;

        public static readonly string DoubleSingleByteDescription = "Double/Single byte (Shift+Space)";
        public static readonly int DoubleSingleByteOnIcoIndex = IME_DOUBLE_ON_INDEX;
        public static readonly int DoubleSingleByteOffIcoIndex = IME_DOUBLE_OFF_INDEX;

        public static readonly string PunctuationDescription = "Chinese/English punctuation (Ctrl+.)";
        public static readonly int PunctuationOnIcoIndex = IME_PUNCTUATION_ON_INDEX;
        public static readonly int PunctuationOffIcoIndex = IME_PUNCTUATION_OFF_INDEX;

        //---------------------------------------------------------------------
        // defined item in setting file table [LanguageBar] section
        //---------------------------------------------------------------------
        public static readonly string LangbarImeModeDescription = "Conversion mode";
        public static readonly string LangbarDoubleSingleByteDescription = "Character width";
        public static readonly string LangbarPunctuationDescription = "Punctuation";
    }
}
