﻿using System;
using System.Windows.Forms;

namespace HIWIN_Robot
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_HIWIN_Robot());
        }
    }
}