using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blaBlaPaint
{
    internal interface IDrawable
    {
        void Drawing(Graphics graphics);
        void StartDrawing(Point startPoint);
        void ContinueDrawing(Point nextPoint);
    }
}
