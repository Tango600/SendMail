using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SendMail
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool noGUI = false;
            if (args.Length > 0)
                if (args[0] == "/nogui")
                    noGUI = true;

            if (!noGUI)
                Application.Run(new Form1());
            else
                Application.Run();
        }
    }
}
