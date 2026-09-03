using Dalek_V_Cybermen.Before_Game_forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dalek_V_Cybermen
{
    internal static class Program
    {
        /// <summary>     dddd
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome_Form());
        }
    }
}
