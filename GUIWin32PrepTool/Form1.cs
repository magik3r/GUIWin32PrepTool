using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement; 

namespace GUIWin32PrepTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.ofd = new OpenFileDialog();
            ofd.ValidateNames = false;
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = true;
            ofd.Title = "Select a Folder";
            ofd.FileName = "Folder";
            ofd.InitialDirectory = @"C:\";

        }

        private void button_SrcPath_Click(object sender, EventArgs e)
        {

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_SrcPath.Text = Path.GetDirectoryName(ofd.FileName);
            }
            
        }

        private void button_SetupFile_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = textBox_SrcPath.Text;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_SetupFile.Text = (ofd.FileName);
            }
        }

        private void button_Output_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_Output.Text = Path.GetDirectoryName(ofd.FileName);
            }
        }

        private void button_Go_Click(object sender, EventArgs e)
        {
            CMD.RunPrepTool(textBox_SrcPath.Text, textBox_SetupFile.Text, textBox_Output.Text, UpdateConsole);
        }

        private void UpdateConsole(string text)
        {
            // Update your richTextBox_Console here
            richTextBox_Console.Invoke(new Action(() => richTextBox_Console.AppendText(text + "\n")));
        }
    }
}
