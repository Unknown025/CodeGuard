﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CodeGuard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Environment.CommandLine.Contains("-officeUI"))
            {
                Application.Run(new CodeGuardOfficeWindow());
            }
            else
            {
                Application.Run(new MainWindow());
            }
        }
    }
}
