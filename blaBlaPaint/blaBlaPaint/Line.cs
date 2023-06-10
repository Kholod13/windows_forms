using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blaBlaPaint
{
    internal class Line : IDrawable
    {
        private Point startPoint;
        private Point endPoint;
        private Color color;
        private float size;

        public Line(Color color, float size)
        {
            this.color = color;
            this.size = size;
        }

        public void StartDrawing(Point startPoint)
        {
            this.startPoint = startPoint;
        }

        public void ContinueDrawing(Point nextPoint)
        {
            endPoint = nextPoint;
        }

        public void Drawing(Graphics graphics)
        {
            using (Pen pen = new Pen(color, size))
            {
                graphics.DrawLine(pen, startPoint, endPoint);
            }
        }
    }
}
