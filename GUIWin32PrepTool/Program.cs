﻿using System;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;

namespace GUIWin32PrepTool
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Check if the application is running as an administrator
            bool isAdmin = new WindowsPrincipal(WindowsIdentity.GetCurrent())
                .IsInRole(WindowsBuiltInRole.Administrator);

            if (!isAdmin)
            {
                MessageBox.Show("Please run as administrator");
                return;
            }

            // Check if IntuneWinAppUtil.exe exists in the same directory as the application
            string appPath = Application.StartupPath;
            string exePath = Path.Combine(appPath, "IntuneWinAppUtil.exe");

            if (!File.Exists(exePath))
            {
                MessageBox.Show("IntuneWinAppUtil.exe not found in the application directory.\nPlease note that alternate names will not work.");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
