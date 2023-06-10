using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blaBlaPaint
{
    internal class Ellipse : IDrawable
    {
        private Rectangle ellipse;
        private Color color;
        private float size;

        public Ellipse(Color color, float size)
        {
            this.color = color;
            this.size = size;
        }

        public void StartDrawing(Point startPoint)
        {
            ellipse.Location = startPoint;
            ellipse.Size = Size.Empty;
        }

        public void ContinueDrawing(Point nextPoint)
        {
            ellipse.Size = new Size(nextPoint.X - ellipse.Left, nextPoint.Y - ellipse.Top);
        }

        public void Drawing(Graphics graphics)
        {
            using (Pen pen = new Pen(color, size))
            {
                graphics.DrawEllipse(pen, ellipse);
            }
        }
    }
}
