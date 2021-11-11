using System;
using System.Windows.Forms;

using KeLi.TrainAnimation.Forms;

namespace KeLi.TrainAnimation
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}