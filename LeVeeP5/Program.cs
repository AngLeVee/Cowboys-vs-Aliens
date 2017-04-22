using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeVeeP5
{
    static class Program
    {
        /// <summary>
        /// Programmer: Angela LeVee (alevee@cnm.edu)
        /// File: Program
        /// Date: 4/9/2015
        /// </summary>

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
