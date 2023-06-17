using System;
using System.Windows.Forms;

namespace Buyurtma_ilovasi
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm1());
        }
    }
}
