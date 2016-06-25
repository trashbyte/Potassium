using System;
using System.Windows.Forms;

namespace Potassium
{
	class MainClass
	{
        [STAThread]
		public static void Main (string[] args)
		{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
		}
	}
}
