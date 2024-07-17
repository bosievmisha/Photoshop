using System;

namespace MyPhotoshop
{
	public class Photo
	{
		public int width { get; }
		public int height { get; }
        private Pixel[,] data {  get; }

		public Pixel this[int x, int y]
		{
			get { return data[x, y]; }
			set { data[x, y] = value; }
		}

		public Photo(int width, int height)
		{
			this.width = width;
			this.height = height;
			data = new Pixel[width, height];
		}
	}
}

