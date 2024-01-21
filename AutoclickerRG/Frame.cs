using System.Drawing;
using System.Windows.Forms;

namespace AutoclickerRG
{
    public class Frame
    {
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }

        public Frame()
        {
            FirstPoint = new Point(0, 0);
            SecondPoint = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        public Frame(Point firstPoint, Point secondPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
        }
    }
}