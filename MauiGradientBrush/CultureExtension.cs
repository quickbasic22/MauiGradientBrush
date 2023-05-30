using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGradientBrush
{
    public class CultureExtension : IMarkupExtension
    {
        public string CultureName { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return new CultureInfo(CultureName);
        }
    }
}
