using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GayMaker_PS3
{
    static class Program
    {
        public static GayMakerPS3 GMS;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GMS = new GayMakerPS3();
            Application.Run(GMS);
        }
    }
}
