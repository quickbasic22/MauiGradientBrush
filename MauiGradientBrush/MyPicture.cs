using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGradientBrush
{
    public class MyPicture : IPicture
    {
        public float X => throw new NotImplementedException();

        public float Y => throw new NotImplementedException();

        public float Width => throw new NotImplementedException();

        public float Height => throw new NotImplementedException();

        public void Draw(ICanvas canvas)
        {
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 9;
            canvas.DrawEllipse(400, 400, 500, 500);
        }
    }
}
