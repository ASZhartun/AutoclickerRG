using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace AutoclickerRG
{
    public class RGModel
    {
        public int CPS { get; set; }
        public Frame Frame { get; set; }

        public bool IsRunning { get; set; }

        public bool FrameIsVisible { get; set; }

        public RGModel() {
            CPS = 1;
            Frame = new Frame();
        }

        public void Run(bool isChecked)
        {
            IsRunning = isChecked;
            GenerateClicks();
        }

        private void GenerateClicks()
        {
            return;
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
            DrawFrame();
        }

        private void DrawFrame()
        {
            return;
        }
    }
}