using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Eze.IO.Workspace
{
    /// <summary>
    /// Virtual key and keyboard types
    /// </summary>
    [ComVisible(true)]
    public enum VirtualKeys : Int32
    {
        ///<summary>0 key</summary>
        Zero = 0x30,
        ///<summary>1 key</summary>
        One = 0x31,
        ///<summary>2 key</summary>
        Two = 0x32,
        ///<summary>3 key</summary>
        Three = 0x33,
        ///<summary>4 key</summary>
        Four = 0x34,
        ///<summary>5 key</summary>
        Five = 0x35,
        ///<summary>6 key</summary>
        Six = 0x36,
        ///<summary>7 key</summary>
        Seven = 0x37,
        ///<summary>8 key</summary>
        Eight = 0x38,
        ///<summary>9 key</summary>
        Nine = 0x39,
        ///<summary>A key</summary>
        A = 0x41,
        ///<summary>B key</summary>
        B = 0x42,
        ///<summary>C key</summary>
        C = 0x43,
        ///<summary>D key</summary>
        D = 0x44,
        ///<summary>E key</summary>
        E = 0x45,
        ///<summary>F key</summary>
        F = 0x46,
        ///<summary>G key</summary>
        G = 0x47,
        ///<summary>H Key</summary>
        H = 0x48,
        ///<summary>I Key</summary>
        I = 0x49,
        ///<summary>J key</summary>
        J = 0x4A,
        ///<summary>K key</summary>
        K = 0x4B,
        ///<summary>L key</summary>
        L = 0x4C,
        ///<summary>M key</summary>
        M = 0x4D,
        ///<summary>N key</summary>
        N = 0x4E,
        ///<summary>O key</summary>
        O = 0x4F,
        ///<summary>P key</summary>
        P = 0x50,
        ///<summary>Q key</summary>
        Q = 0x51,
        ///<summary>R key</summary>
        R = 0x52,
        ///<summary>S key</summary>
        S = 0x53,
        ///<summary>T key</summary>
        T = 0x54,
        ///<summary>U key</summary>
        U = 0x55,
        ///<summary>V key</summary>
        V = 0x56,
        ///<summary>W key</summary>
        W = 0x57,
        ///<summary>X key</summary>
        X = 0x58,
        ///<summary>Z key</summary>
        Z = 0x5A,
        ///<summary>F1 key</summary>
        F1 = 0x70,
        ///<summary>F2 key</summary>
        F2 = 0x71,
        ///<summary>F3 key</summary>
        F3 = 0x72,
        ///<summary>F4 key</summary>
        F4 = 0x73,
        ///<summary>F5 key</summary>
        F5 = 0x74,
        ///<summary>F6 key</summary>
        F6 = 0x75,
        ///<summary>F7 key</summary>
        F7 = 0x76,
        ///<summary>F8 key</summary>
        F8 = 0x77,
        ///<summary>F9 key</summary>
        F9 = 0x78,
        ///<summary>F10 key</summary>
        F10 = 0x79,
        ///<summary>F11 key</summary>
        F11 = 0x7A,
        ///<summary>F12 key</summary>
        F12 = 0x7B,
        ///<summary>F13 key</summary>
        F13 = 0x7C,
        ///<summary>F14 key</summary>
        F14 = 0x7D,
        ///<summary>F15 key</summary>
        F15 = 0x7E,
        ///<summary>F16 key</summary>
        F16 = 0x7F,
        ///<summary>F17 key</summary>
        F17 = 0x80,
        ///<summary>F18 key</summary>
        F18 = 0x81,
        ///<summary>F19 key</summary>
        F19 = 0x82,
        ///<summary>F20 key</summary>
        F20 = 0x83,
        ///<summary>F21 key</summary>
        F21 = 0x84,
        ///<summary>F22 key</summary>
        F22 = 0x85,
        ///<summary>F23 key</summary>
        F23 = 0x86,
        ///<summary>F24 key</summary>
        F24 = 0x87,
        ///<summary>Escape key</summary>
        Esc = 0x1B,
        ///<summary>Alt key</summary>
        Alt = 0x12,
        ///<summary>Tab key</summary>
        Tab = 0x09,
        ///<summary>Control key</summary>
        Ctrl = 0x11,
        ///<summary>Shift key</summary>
        Shift = 0x10,
        ///<summary>Enter key</summary>
        Enter = 0x0D,
        ///<summary>Clear key</summary>
        Clear = 0x0C,
        ///<summary>Pause key</summary>
        Pause = 0x13,
        ///<summary>Spacebar key</summary>
        Spacebar = 0x20,
        ///<summary>Backspace key</summary>
        Backspace = 0x08,
        ///<summary>CapsLock key</summary>
        CapsLock = 0x14,
        ///<summary>^ Up arrow key</summary>
        UpArrow = 0x26,
        ///<summary>> Left arrow key</summary>
        LeftArrow = 0x25,
        ///<summary>v Down arrow key</summary>
        DownArrow = 0x28,
        ///<summary> &lt; Right arrow key</summary>
        RightArrow = 0x27,
        ///<summary>End key</summary>
        End = 0x23,
        ///<summary>Help key</summary>
        Help = 0x2F,
        ///<summary>Home key</summary>
        Home = 0x24,
        ///<summary>Print key</summary>
        Print = 0x2A,
        ///<summary>Del/Delete key</summary>
        Delete = 0x2E,
        ///<summary>Ins/Insert  key</summary>
        Insert = 0x2D,
        ///<summary>Select key</summary>
        Select = 0x29,
        ///<summary>Execute key</summary>
        Execute = 0x2B,
        ///<summary>Page up key</summary>
        PageUp = 0x21,
        ///<summary>Page down key</summary>
        PageDown = 0x22,
        ///<summary>Number Lock key</summary>
        NumLock = 0x90,
        ///<summary>Scroll/Scroll Lock key</summary>
        ScrollLock = 0x91,
        ///<summary>PrtSc/Print Screen key</summary>
        PrintScreen = 0x2C,
        ///<summary>+ Add key</summary>
        Add = 0x6B,
        ///<summary>/ Divide key</summary>
        Divide = 0x6F,
        ///<summary>. Decimal key</summary>
        Decimal = 0x6E,
        ///<summary>* Multiply key</summary>
        Multiply = 0x6A,
        ///<summary>- Subtract key</summary>
        Subtract = 0x6D,
        ///<summary>| Separator key</summary>
        Separator = 0x6C,
        ///<summary>0 Num Lock key</summary>
        Numeric0 = 0x60,
        ///<summary>1 Num Lock key</summary>
        Numeric1 = 0x61,
        ///<summary>2 Num Lock key</summary>
        Numeric2 = 0x62,
        ///<summary>3 Num Lock key</summary>
        Numeric3 = 0x63,
        ///<summary>4 Num Lock key</summary>
        Numeric4 = 0x64,
        ///<summary>5 Num Lock key</summary>
        Numeric5 = 0x65,
        ///<summary>6 Num Lock key</summary>
        Numeric6 = 0x66,
        ///<summary>7 Num Lock key</summary>
        Numeric7 = 0x67,
        ///<summary>8 Num Lock key</summary>
        Numeric8 = 0x68,
        ///<summary>9 Num Lock key</summary>
        Numeric9 = 0x69,
        ///<summary>Left shift key</summary>
        LeftShift = 0xA0,
        ///<summary>Left ctrl/control key</summary>
        LeftControl = 0xA2,
        ///<summary>Right shift key</summary>
        RightShift = 0xA1,
        ///<summary>Right ctrl/control key</summary>
        RightControl = 0xA3,
        ///<summary>+/= Plus key</summary>
        Plus = 0xBB,
        ///<summary>~ Tilde key</summary>
        Tilde = 0xC0,
        ///<summary>- Minus key</summary>
        Minus = 0xBD,
        ///<summary>, Comma key</summary>
        Comma = 0xBC,
        ///<summary>. Period key</summary>
        Period = 0xBE,
        ///<summary>/? Question key</summary>
        Question = 0xBF,
        ///<summary>\ Backslash key</summary>
        Backslash = 0xDC | 0xE2,
        ///<summary>;: Semicolon key</summary>
        Semicolon = 0xBA,
        ///<summary>[{ Left Brackets key</summary>
        LeftBrackets = 0xDB,
        ///<summary>Right Brackets }] key</summary>
        RightBrackets = 0xDD,
        ///<summary>"''" Single/Double quote key</summary>
        SingleDoubleQuote = 0xDE,
        ///<summary>Left Windows Logo key</summary>
        LeftWindowsApplication = 0x5B,
        ///<summary>Right Windows Logo key</summary>
        RightWindowsApplication = 0x5C,
        ///<summary>Right alt key</summary>
        RightMenu = 0xA5,
        ///<summary>Left alt key</summary>
        LeftMenu = 0xA4,
        ///<summary>Volume up key</summary>
        VolumeUp = 0xAF,
        ///<summary>Volume down key</summary>
        VolumeDown = 0xAE,
        ///<summary>Volume mute key</summary>
        VolumeMute = 0xAD
    }
}
