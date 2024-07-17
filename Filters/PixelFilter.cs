using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoshop
{
    public abstract class PixelFilter : ParametizedFilter
    {
        protected abstract Pixel ProcessPixel(Pixel original, IParameters parameters);
        public PixelFilter(IParameters parameters) : base(parameters) { }

        public Photo Process(Photo original, IParameters parameters)
        {
            var result = new Photo(original.width, original.height);

            for (int x = 0; x < result.width; x++)
                for (int y = 0; y < result.height; y++)
                    result[x, y] = ProcessPixel(original[x, y], parameters);

            return result;
        }
    }
}
