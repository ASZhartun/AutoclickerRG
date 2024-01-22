using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace AutoclickerRG
{
    public static class OverlayDrawer
    {
        [DllImport("User32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);

        public static void DrawFrame(Frame frame)
        {
            IntPtr desktopPtr = GetDC(IntPtr.Zero);
            Graphics g = Graphics.FromHdc(desktopPtr);

            SolidBrush b = new SolidBrush(Color.Beige);
            g.FillRectangle(b, new Rectangle(frame.FirstPoint.X, frame.FirstPoint.Y, frame.SecondPoint.X - frame.FirstPoint.X, frame.SecondPoint.Y - frame.FirstPoint.Y));

            g.Dispose();
            ReleaseDC(IntPtr.Zero, desktopPtr);
        }
    }
}
