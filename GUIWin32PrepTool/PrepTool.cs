using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GUIWin32PrepTool
{
    public class CMD
    {
        public static void RunPrepTool(string source, string setup, string outputPath, Action<string> updateAction)
        {
            // Create a new process object
            Process process = new Process();

            // Configure the process using the StartInfo properties
            process.StartInfo.FileName = "cmd.exe";

            process.StartInfo.Arguments = @"/K ""IntuneWinAppUtil.exe -c """ + source + @""" -s """ + setup + @""" -o """ + outputPath + @""" -q & pause & exit"""; process.StartInfo.UseShellExecute = true; // Set to true to use the 'runas' verb
            process.StartInfo.CreateNoWindow = false; // Set to false to show the new console window
            process.StartInfo.WorkingDirectory = Application.StartupPath;
            process.StartInfo.Verb = "runas"; // Add this line to run as admin

            process.Start();

            // Call the action to update the richTextBox_Console
            updateAction($"Command executed:\n{process.StartInfo.Arguments}");
        }



















    }

}
