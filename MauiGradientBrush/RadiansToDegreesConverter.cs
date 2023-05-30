using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MauiGradientBrush
{
    public class RadiansToDegreesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Quaternion quaternion)
            {
                float angle = 2 * (float)Math.Acos(quaternion.W);
                float factor = (float)Math.Sin(angle / 2);
                if (Math.Abs(factor) < 0.000001)
                    return 0.0;

                return angle * (180.0 / Math.PI);
            }

            return 0.0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
