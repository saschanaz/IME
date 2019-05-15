using System;
using System.Collections.Generic;
using System.Text;

namespace SampleIMESharp
{
    class VirtualKeys
    {
        /*
 * Virtual Keys, Standard Set
 */
        public static readonly uint VK_LBUTTON = 0x01;
        public static readonly uint VK_RBUTTON = 0x02;
        public static readonly uint VK_CANCEL = 0x03;
        public static readonly uint VK_MBUTTON = 0x04; /* NOT contiguous with L & RBUTTON */

        public static readonly uint VK_XBUTTON1 = 0x05; /* NOT contiguous with L & RBUTTON */
        public static readonly uint VK_XBUTTON2 = 0x06; /* NOT contiguous with L & RBUTTON */

        /*
         * 0x07 : reserved
         */


        public static readonly uint VK_BACK = 0x08;
        public static readonly uint VK_TAB = 0x09;

        /*
         * 0x0A - 0x0B : reserved
         */

        public static readonly uint VK_CLEAR = 0x0C;
        public static readonly uint VK_RETURN = 0x0D;

        /*
         * 0x0E - 0x0F : unassigned
         */

        public static readonly uint VK_SHIFT = 0x10;
        public static readonly uint VK_CONTROL = 0x11;
        public static readonly uint VK_MENU = 0x12;
        public static readonly uint VK_PAUSE = 0x13;
        public static readonly uint VK_CAPITAL = 0x14;

        public static readonly uint VK_KANA = 0x15;
        public static readonly uint VK_HANGEUL = 0x15; /* old name - should be here for compatibility */
        public static readonly uint VK_HANGUL = 0x15;

        /*
         * 0x16 : unassigned
         */

        public static readonly uint VK_JUNJA = 0x17;
        public static readonly uint VK_FINAL = 0x18;
        public static readonly uint VK_HANJA = 0x19;
        public static readonly uint VK_KANJI = 0x19;

        /*
         * 0x1A : unassigned
         */

        public static readonly uint VK_ESCAPE = 0x1B;

        public static readonly uint VK_CONVERT = 0x1C;
        public static readonly uint VK_NONCONVERT = 0x1D;
        public static readonly uint VK_ACCEPT = 0x1E;
        public static readonly uint VK_MODECHANGE = 0x1F;

        public static readonly uint VK_SPACE = 0x20;
        public static readonly uint VK_PRIOR = 0x21;
        public static readonly uint VK_NEXT = 0x22;
        public static readonly uint VK_END = 0x23;
        public static readonly uint VK_HOME = 0x24;
        public static readonly uint VK_LEFT = 0x25;
        public static readonly uint VK_UP = 0x26;
        public static readonly uint VK_RIGHT = 0x27;
        public static readonly uint VK_DOWN = 0x28;
        public static readonly uint VK_SELECT = 0x29;
        public static readonly uint VK_PRINT = 0x2A;
        public static readonly uint VK_EXECUTE = 0x2B;
        public static readonly uint VK_SNAPSHOT = 0x2C;
        public static readonly uint VK_INSERT = 0x2D;
        public static readonly uint VK_DELETE = 0x2E;
        public static readonly uint VK_HELP = 0x2F;

        /*
         * VK_0 - VK_9 are the same as ASCII '0' - '9' (0x30 - 0x39)
         * 0x3A - 0x40 : unassigned
         * VK_A - VK_Z are the same as ASCII 'A' - 'Z' (0x41 - 0x5A)
         */

        public static readonly uint VK_LWIN = 0x5B;
        public static readonly uint VK_RWIN = 0x5C;
        public static readonly uint VK_APPS = 0x5D;

        /*
         * 0x5E : reserved
         */

        public static readonly uint VK_SLEEP = 0x5F;

        public static readonly uint VK_NUMPAD0 = 0x60;
        public static readonly uint VK_NUMPAD1 = 0x61;
        public static readonly uint VK_NUMPAD2 = 0x62;
        public static readonly uint VK_NUMPAD3 = 0x63;
        public static readonly uint VK_NUMPAD4 = 0x64;
        public static readonly uint VK_NUMPAD5 = 0x65;
        public static readonly uint VK_NUMPAD6 = 0x66;
        public static readonly uint VK_NUMPAD7 = 0x67;
        public static readonly uint VK_NUMPAD8 = 0x68;
        public static readonly uint VK_NUMPAD9 = 0x69;
        public static readonly uint VK_MULTIPLY = 0x6A;
        public static readonly uint VK_ADD = 0x6B;
        public static readonly uint VK_SEPARATOR = 0x6C;
        public static readonly uint VK_SUBTRACT = 0x6D;
        public static readonly uint VK_DECIMAL = 0x6E;
        public static readonly uint VK_DIVIDE = 0x6F;
        public static readonly uint VK_F1 = 0x70;
        public static readonly uint VK_F2 = 0x71;
        public static readonly uint VK_F3 = 0x72;
        public static readonly uint VK_F4 = 0x73;
        public static readonly uint VK_F5 = 0x74;
        public static readonly uint VK_F6 = 0x75;
        public static readonly uint VK_F7 = 0x76;
        public static readonly uint VK_F8 = 0x77;
        public static readonly uint VK_F9 = 0x78;
        public static readonly uint VK_F10 = 0x79;
        public static readonly uint VK_F11 = 0x7A;
        public static readonly uint VK_F12 = 0x7B;
        public static readonly uint VK_F13 = 0x7C;
        public static readonly uint VK_F14 = 0x7D;
        public static readonly uint VK_F15 = 0x7E;
        public static readonly uint VK_F16 = 0x7F;
        public static readonly uint VK_F17 = 0x80;
        public static readonly uint VK_F18 = 0x81;
        public static readonly uint VK_F19 = 0x82;
        public static readonly uint VK_F20 = 0x83;
        public static readonly uint VK_F21 = 0x84;
        public static readonly uint VK_F22 = 0x85;
        public static readonly uint VK_F23 = 0x86;
        public static readonly uint VK_F24 = 0x87;



        /*
         * 0x88 - 0x8F : UI navigation
         */

        public static readonly uint VK_NAVIGATION_VIEW = 0x88; // reserved
        public static readonly uint VK_NAVIGATION_MENU = 0x89; // reserved
        public static readonly uint VK_NAVIGATION_UP = 0x8A; // reserved
        public static readonly uint VK_NAVIGATION_DOWN = 0x8B; // reserved
        public static readonly uint VK_NAVIGATION_LEFT = 0x8C; // reserved
        public static readonly uint VK_NAVIGATION_RIGHT = 0x8D; // reserved
        public static readonly uint VK_NAVIGATION_ACCEPT = 0x8E; // reserved
        public static readonly uint VK_NAVIGATION_CANCEL = 0x8F; // reserved



        public static readonly uint VK_NUMLOCK = 0x90;
        public static readonly uint VK_SCROLL = 0x91;

        /*
         * NEC PC-9800 kbd definitions
         */
        public static readonly uint VK_OEM_NEC_EQUAL = 0x92;   // '=' key on numpad

        /*
         * Fujitsu/OASYS kbd definitions
         */
        public static readonly uint VK_OEM_FJ_JISHO = 0x92; // 'Dictionary' key
        public static readonly uint VK_OEM_FJ_MASSHOU = 0x93; // 'Unregister word' key
        public static readonly uint VK_OEM_FJ_TOUROKU = 0x94; // 'Register word' key
        public static readonly uint VK_OEM_FJ_LOYA = 0x95; // 'Left OYAYUBI' key
        public static readonly uint VK_OEM_FJ_ROYA = 0x96; // 'Right OYAYUBI' key

        /*
         * 0x97 - 0x9F : unassigned
         */

        /*
         * VK_L* & VK_R* - left and right Alt, Ctrl and Shift virtual keys.
         * Used only as parameters to GetAsyncKeyState() and GetKeyState().
         * No other API or message will distinguish left and right keys in this way.
         */
        public static readonly uint VK_LSHIFT = 0xA0;
        public static readonly uint VK_RSHIFT = 0xA1;
        public static readonly uint VK_LCONTROL = 0xA2;
        public static readonly uint VK_RCONTROL = 0xA3;
        public static readonly uint VK_LMENU = 0xA4;
        public static readonly uint VK_RMENU = 0xA5;

        public static readonly uint VK_BROWSER_BACK = 0xA6;
        public static readonly uint VK_BROWSER_FORWARD = 0xA7;
        public static readonly uint VK_BROWSER_REFRESH = 0xA8;
        public static readonly uint VK_BROWSER_STOP = 0xA9;
        public static readonly uint VK_BROWSER_SEARCH = 0xAA;
        public static readonly uint VK_BROWSER_FAVORITES = 0xAB;
        public static readonly uint VK_BROWSER_HOME = 0xAC;

        public static readonly uint VK_VOLUME_MUTE = 0xAD;
        public static readonly uint VK_VOLUME_DOWN = 0xAE;
        public static readonly uint VK_VOLUME_UP = 0xAF;
        public static readonly uint VK_MEDIA_NEXT_TRACK = 0xB0;
        public static readonly uint VK_MEDIA_PREV_TRACK = 0xB1;
        public static readonly uint VK_MEDIA_STOP = 0xB2;
        public static readonly uint VK_MEDIA_PLAY_PAUSE = 0xB3;
        public static readonly uint VK_LAUNCH_MAIL = 0xB4;
        public static readonly uint VK_LAUNCH_MEDIA_SELECT = 0xB5;
        public static readonly uint VK_LAUNCH_APP1 = 0xB6;
        public static readonly uint VK_LAUNCH_APP2 = 0xB7;

        /*
         * 0xB8 - 0xB9 : reserved
         */

        public static readonly uint VK_OEM_1 = 0xBA; // ';:' for US
        public static readonly uint VK_OEM_PLUS = 0xBB; // '+' any country
        public static readonly uint VK_OEM_COMMA = 0xBC; // ',' any country
        public static readonly uint VK_OEM_MINUS = 0xBD; // '-' any country
        public static readonly uint VK_OEM_PERIOD = 0xBE; // '.' any country
        public static readonly uint VK_OEM_2 = 0xBF; // '/?' for US
        public static readonly uint VK_OEM_3 = 0xC0; // '`~' for US
    }
}
