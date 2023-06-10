using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blaBlaPaint
{
    internal class MyRectangle : IDrawable
    {
        private Rectangle rectangle;
        private Color color;
        private float size;
        private Point start;
        public MyRectangle(Color color, float size)
        {
            this.color = color;
            this.size = size;
        }

        public void StartDrawing(Point startPoint)
        {
            rectangle.Location = startPoint;
            rectangle.Size = Size.Empty;
            start = startPoint;
        }

        public void ContinueDrawing(Point nextPoint)
        {
            Size newSize = new Size(Math.Abs(nextPoint.X - start.X), Math.Abs(nextPoint.Y - start.Y));
            rectangle = new Rectangle(new Point(start.X > nextPoint.X ? nextPoint.X : start.X, start.Y > nextPoint.Y ? nextPoint.Y : start.Y), newSize);
        }

        public void Drawing(Graphics graphics)
        {
            using (Pen pen = new Pen(color, size))
            {
                graphics.DrawRectangle(pen, rectangle);
            }
        }
    }
}
