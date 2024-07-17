using MyPhotoshop.Filters;
using System;

namespace MyPhotoshop
{
	public class GrayFilter : PixelFilter
    {
        public override string ToString ()
		{
			return "Серый фильтр";
		}
        public PixelFilter(IParameters parameters) : base(parameters) { }

        protected override Pixel ProcessPixel(Pixel original, IParameters parameters)
		{
            var gray = 0.299 * original.R + 0.587 * original.G + 0.114 * original.B;
            return new Pixel(gray, gray, gray);
        }
    }
}

