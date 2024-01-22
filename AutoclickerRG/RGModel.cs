using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace AutoclickerRG
{
    public class RGModel
    {
        public int CPS { get; set; }
        public Frame Frame { get; set; }

        public bool IsRunning { get; set; }

        public bool FrameIsVisible { get; set; }

        public RGModel()
        {
            CPS = 1;
            Frame = new Frame();
        }

        public void Run(bool isChecked)
        {
            IsRunning = isChecked;
            if (IsRunning)
            {
                Thread side = new Thread(DoClicks);
                side.Start();
            }
        }

        private void GenerateClicks()
        {
            AutoClick.DoLeftClick(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
            Console.WriteLine("Do click!");
        }

        public void DoClicks()
        {
            while (IsRunning)
            {
                AutoClick.DoLeftClick(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
                Console.WriteLine("Do click!");
                Thread.Sleep(1000 / CPS);
            }
        }

        public void SetCPS(int trueCPS)
        {
            CPS = trueCPS;
        }

        public void SetFrame(int[] trueCoords)
        {
            Point firstPoint = new Point(trueCoords[0], trueCoords[1]);
            Point secondPoint = new Point(trueCoords[2], trueCoords[3]);
            Frame = new Frame(firstPoint, secondPoint);
        }

        internal void ShowFrame(bool FrameVisibleIsChecked)
        {
            FrameIsVisible = FrameVisibleIsChecked;
            Thread side = new Thread(frame => RefreshFrame((Frame)frame));
            side.Start(Frame);
        }

        private void RefreshFrame(Frame frame)
        {
            while (FrameIsVisible)
            {
                OverlayDrawer.DrawFrame(frame);
                Console.WriteLine("Board frame must be on the screen");
            }
        }
    }
}