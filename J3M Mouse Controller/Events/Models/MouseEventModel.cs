using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace J3M_Mouse_Controller.Events
{
    public class MouseEventModel
    {
        public struct INPUT
        {
            public SendInputEventType type;
            public MouseKeybdhardwareInputUnion mkhi;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct MouseKeybdhardwareInputUnion
        {
            [FieldOffset(0)]
            public MouseInputData mi;
            [FieldOffset(0)]
            public KEYBDINPUT ki;
            [FieldOffset(0)]
            public HARDWAREINPUT hi;
        }

        public struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        public struct HARDWAREINPUT
        {
            public int uMsg;
            public short wParamL;
            public short wParamH;
        }

        public struct MouseInputData
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public MouseEventFlags dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [Flags]
        public enum MouseEventFlags : uint
        {
            MOUSEEVENTF_MOVE = 1,
            MOUSEEVENTF_LEFTDOWN = 2,
            MOUSEEVENTF_LEFTUP = 4,
            MOUSEEVENTF_RIGHTDOWN = 8,
            MOUSEEVENTF_RIGHTUP = 16, // 0x00000010
            MOUSEEVENTF_MIDDLEDOWN = 32, // 0x00000020
            MOUSEEVENTF_MIDDLEUP = 64, // 0x00000040
            MOUSEEVENTF_XDOWN = 128, // 0x00000080
            MOUSEEVENTF_XUP = 256, // 0x00000100
            MOUSEEVENTF_WHEEL = 2048, // 0x00000800
            MOUSEEVENTF_VIRTUALDESK = 16384, // 0x00004000
            MOUSEEVENTF_ABSOLUTE = 32768, // 0x00008000
        }

        public enum SendInputEventType
        {
            InputMouse,
            InputKeyboard,
            InputHardware,
        }
    }
}
