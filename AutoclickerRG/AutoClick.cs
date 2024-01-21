using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoclickerRG
{
    public class AutoClick
    {
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        public const int MOUSEEVENTF_LEFTUP = 0x0004;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        public const int MOUSEEVENTF_MIDDLEUP = 0x0040;

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public static void DoLeftClick(int dx, int dy, int dwData = 0, int dwExtraInfo = 0) {
            mouse_event(MOUSEEVENTF_LEFTDOWN, dx, dy, dwData, dwExtraInfo);
            mouse_event(MOUSEEVENTF_LEFTUP, dx, dy, dwData, dwExtraInfo);
        }
    }
}
