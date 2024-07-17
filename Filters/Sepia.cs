using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace MyPhotoshop.Filters
{
    internal class Sepia : PixelFilter
    {
        public override ParameterInfo[] GetParameters()
        {
            return new ParameterInfo[0];
        }
        public override string ToString()
        {
            return "Сепия";
        }

        protected override Pixel ProcessPixel(Pixel original, double[] parameters)
        {
            var newr = original.R * 0.393 + original.G * 0.769 + original.B * 0.189;
            var newg = original.R * 0.349 + original.G * 0.686 + original.B * 0.168;
            var newb = original.R * 0.272 + original.G * 0.534 + original.B * 0.131;
            return new Pixel(newr, newg, newb);
        }
        
    }
}
