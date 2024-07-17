using MyPhotoshop.Filters;
using System;
using System.Windows.Forms;

namespace MyPhotoshop
{
	class MainClass
	{
        [STAThread]
		public static void Main (string[] args)
		{
			var window=new MainWindow();
			window.AddFilter(new GrayFilter());
			window.AddFilter (new LighteningFilter());
            window.AddFilter(new Sepia());
            Application.Run (window);
		}
	}
}
