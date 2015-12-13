using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcline.OpenEhr.Forms
{
    public static class App
    {
        [STAThread]
        public static void Main(String[] args)
        {
            Application.Run(new MainForm());
        }
    }
}
