using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MauiGradientBrush
{
    public class StarDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            PathF path = new PathF();
            for (int i = 0; i < 11; i++)
            {
                double angle = 5 * i * 2 * Math.PI / 11;
                PointF point = new PointF(100 * (float)Math.Sin(angle), -100 * (float)Math.Cos(angle));
                if (i == 0)
                    path.MoveTo(point);
                else
                    path.LineTo(point);
            }
            Matrix3x2 transform = new Matrix3x2(0.0f, 0.0f, 0.0f, 0.0f, 200.0f, 200.0f);
            canvas.ConcatenateTransform(transform);
           
            canvas.FillColor = Colors.Red;
            canvas.FillPath(path);
        }
    }
}
