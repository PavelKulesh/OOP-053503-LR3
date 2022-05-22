using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lib
{
    public class Trapeze
    {
        /*public int x1 { get; set; }
        public int y1 { get; set; }
        public int lengthDown { get; set; }
        public int lengthUp { get; set; }
        public Color PenColor { get; set; }
        public float PenWidth { get; set; }
        public Color BrushColor { get; set; }
        public Trapeze(int x1, int y1, int lengthDown, int lengthUp, Color PenColor, float PenWidth, Color BrushColor)
        {
            //Name = "Trapeze";
            this.x1 = x1;
            this.y1 = y1;
            this.lengthDown = lengthDown;
            this.lengthUp = lengthUp;
            this.PenColor = PenColor;
            this.PenWidth = PenWidth;
            this.BrushColor = BrushColor;
        }*/
        public void Draw(int x1, int y1, int lengthDown, int lengthUp, Pen pen, Brush brush, Graphics graphics)
        {
            int height = Math.Abs((lengthDown - lengthUp) / 2);
            if (lengthDown - lengthUp > 0)
            {
                Point[] points = { new Point(x1, y1), new Point(x1 + height, y1 - height), new Point(x1 + lengthDown - height, y1 - height), new Point(x1 + lengthDown, y1) };
                graphics.DrawPolygon(pen, points);
                if (pen.Width % 2 != 0)
                {
                    Point[] points2 = { new Point(x1, y1), new Point(x1 + height, y1 - height + 1), new Point(x1 + lengthDown - height, y1 - height), new Point(x1 + lengthDown, y1) };
                    graphics.FillPolygon(brush, points2);
                }
                else
                {
                    graphics.FillPolygon(brush, points);
                }
            }
            else
            {
                Point[] points = { new Point(x1, y1), new Point(x1 + height, y1 + height), new Point(x1 + lengthUp - height, y1 + height), new Point(x1 + lengthUp, y1) };
                graphics.DrawPolygon(pen, points);
                if (pen.Width % 2 != 0)
                {
                    Point[] points2 = { new Point(x1 + 2, y1 + 1), new Point(x1 + height, y1 + height), new Point(x1 + lengthUp - height, y1 + height), new Point(x1 + lengthUp, y1) };
                    graphics.FillPolygon(brush, points2);
                }
                else
                {
                    graphics.FillPolygon(brush, points);
                }
            }
        }
    }
}
