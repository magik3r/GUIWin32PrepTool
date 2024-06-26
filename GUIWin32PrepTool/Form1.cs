﻿using System;
using System.IO;
using System.Windows.Forms;

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
            // ofd.InitialDirectory = @"C:\";

        }

        private void button_SrcPath_Click(object sender, EventArgs e)
        {
            ofd.FileName = "Folder";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_SrcPath.Text = Path.GetDirectoryName(ofd.FileName);
                string[] files = Directory.GetFiles(textBox_SrcPath.Text, "*.exe");
                if (files.Length == 0)
                {
                    files = Directory.GetFiles(textBox_SrcPath.Text, "*.msi");
                }
                if (files.Length > 0)
                {
                    textBox_SetupFile.Text = files[0];
                }
            }

            // Get the parent directory
            var parentDirectory = Directory.GetParent(textBox_SrcPath.Text);

            // Check if the parent directory is not null
            if (parentDirectory != null)
            {
                // Set the text of the other textbox to the path of the parent directory
                textBox_Output.Text = parentDirectory.FullName;
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
            ofd.FileName = "Folder";
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
