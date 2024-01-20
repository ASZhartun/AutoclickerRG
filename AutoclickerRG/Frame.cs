using System.Drawing;

namespace AutoclickerRG
{
    public class Frame
    {
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }

        public Frame() { }

        public Frame(Point firstPoint, Point secondPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
        }
    }
}