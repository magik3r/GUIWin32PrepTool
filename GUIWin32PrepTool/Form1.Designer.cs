namespace GUIWin32PrepTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_SrcPath = new System.Windows.Forms.TextBox();
            this.button_SrcPath = new System.Windows.Forms.Button();
            this.fBD_SrcPath = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.label_SrcPath = new System.Windows.Forms.Label();
            this.label_SetupFile = new System.Windows.Forms.Label();
            this.button_SetupFile = new System.Windows.Forms.Button();
            this.textBox_SetupFile = new System.Windows.Forms.TextBox();
            this.label_Output = new System.Windows.Forms.Label();
            this.button_Output = new System.Windows.Forms.Button();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.richTextBox_Console = new System.Windows.Forms.RichTextBox();
            this.button_Go = new System.Windows.Forms.Button();
            this.label_CommandLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_SrcPath
            // 
            this.textBox_SrcPath.Enabled = false;
            this.textBox_SrcPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SrcPath.Location = new System.Drawing.Point(144, 32);
            this.textBox_SrcPath.Name = "textBox_SrcPath";
            this.textBox_SrcPath.ReadOnly = true;
            this.textBox_SrcPath.Size = new System.Drawing.Size(344, 24);
            this.textBox_SrcPath.TabIndex = 0;
            this.textBox_SrcPath.Text = "<Source Directory>";
            // 
            // button_SrcPath
            // 
            this.button_SrcPath.Location = new System.Drawing.Point(503, 30);
            this.button_SrcPath.Name = "button_SrcPath";
            this.button_SrcPath.Size = new System.Drawing.Size(79, 26);
            this.button_SrcPath.TabIndex = 1;
            this.button_SrcPath.Text = "Browse";
            this.button_SrcPath.UseVisualStyleBackColor = true;
            this.button_SrcPath.Click += new System.EventHandler(this.button_SrcPath_Click);
            // 
            // label_SrcPath
            // 
            this.label_SrcPath.AutoSize = true;
            this.label_SrcPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SrcPath.Location = new System.Drawing.Point(23, 35);
            this.label_SrcPath.Name = "label_SrcPath";
            this.label_SrcPath.Size = new System.Drawing.Size(115, 18);
            this.label_SrcPath.TabIndex = 2;
            this.label_SrcPath.Text = "Source folder:";
            // 
            // label_SetupFile
            // 
            this.label_SetupFile.AutoSize = true;
            this.label_SetupFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SetupFile.Location = new System.Drawing.Point(23, 92);
            this.label_SetupFile.Name = "label_SetupFile";
            this.label_SetupFile.Size = new System.Drawing.Size(83, 18);
            this.label_SetupFile.TabIndex = 5;
            this.label_SetupFile.Text = "Setup file:";
            // 
            // button_SetupFile
            // 
            this.button_SetupFile.Location = new System.Drawing.Point(503, 87);
            this.button_SetupFile.Name = "button_SetupFile";
            this.button_SetupFile.Size = new System.Drawing.Size(79, 26);
            this.button_SetupFile.TabIndex = 4;
            this.button_SetupFile.Text = "Browse";
            this.button_SetupFile.UseVisualStyleBackColor = true;
            this.button_SetupFile.Click += new System.EventHandler(this.button_SetupFile_Click);
            // 
            // textBox_SetupFile
            // 
            this.textBox_SetupFile.Enabled = false;
            this.textBox_SetupFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SetupFile.Location = new System.Drawing.Point(144, 89);
            this.textBox_SetupFile.Name = "textBox_SetupFile";
            this.textBox_SetupFile.ReadOnly = true;
            this.textBox_SetupFile.Size = new System.Drawing.Size(344, 24);
            this.textBox_SetupFile.TabIndex = 3;
            this.textBox_SetupFile.Text = "<Setup File>";
            // 
            // label_Output
            // 
            this.label_Output.AutoSize = true;
            this.label_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Output.Location = new System.Drawing.Point(23, 153);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(111, 18);
            this.label_Output.TabIndex = 8;
            this.label_Output.Text = "Output folder:";
            // 
            // button_Output
            // 
            this.button_Output.Location = new System.Drawing.Point(503, 148);
            this.button_Output.Name = "button_Output";
            this.button_Output.Size = new System.Drawing.Size(79, 26);
            this.button_Output.TabIndex = 7;
            this.button_Output.Text = "Browse";
            this.button_Output.UseVisualStyleBackColor = true;
            this.button_Output.Click += new System.EventHandler(this.button_Output_Click);
            // 
            // textBox_Output
            // 
            this.textBox_Output.Enabled = false;
            this.textBox_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Output.Location = new System.Drawing.Point(144, 150);
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ReadOnly = true;
            this.textBox_Output.Size = new System.Drawing.Size(344, 24);
            this.textBox_Output.TabIndex = 6;
            this.textBox_Output.Text = "<Output Directory>";
            // 
            // richTextBox_Console
            // 
            this.richTextBox_Console.Location = new System.Drawing.Point(26, 235);
            this.richTextBox_Console.Name = "richTextBox_Console";
            this.richTextBox_Console.ReadOnly = true;
            this.richTextBox_Console.Size = new System.Drawing.Size(556, 72);
            this.richTextBox_Console.TabIndex = 9;
            this.richTextBox_Console.Text = "";
            // 
            // button_Go
            // 
            this.button_Go.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Go.Location = new System.Drawing.Point(460, 193);
            this.button_Go.Name = "button_Go";
            this.button_Go.Size = new System.Drawing.Size(122, 36);
            this.button_Go.TabIndex = 10;
            this.button_Go.Text = "GO";
            this.button_Go.UseVisualStyleBackColor = true;
            this.button_Go.Click += new System.EventHandler(this.button_Go_Click);
            // 
            // label_CommandLine
            // 
            this.label_CommandLine.AutoSize = true;
            this.label_CommandLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CommandLine.Location = new System.Drawing.Point(26, 216);
            this.label_CommandLine.Name = "label_CommandLine";
            this.label_CommandLine.Size = new System.Drawing.Size(192, 18);
            this.label_CommandLine.TabIndex = 11;
            this.label_CommandLine.Text = "Command used in CMD:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 342);
            this.Controls.Add(this.label_CommandLine);
            this.Controls.Add(this.button_Go);
            this.Controls.Add(this.richTextBox_Console);
            this.Controls.Add(this.label_Output);
            this.Controls.Add(this.button_Output);
            this.Controls.Add(this.textBox_Output);
            this.Controls.Add(this.label_SetupFile);
            this.Controls.Add(this.button_SetupFile);
            this.Controls.Add(this.textBox_SetupFile);
            this.Controls.Add(this.label_SrcPath);
            this.Controls.Add(this.button_SrcPath);
            this.Controls.Add(this.textBox_SrcPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GUIWinpreptool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SrcPath;
        private System.Windows.Forms.Button button_SrcPath;
        private System.Windows.Forms.FolderBrowserDialog fBD_SrcPath;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label label_SrcPath;
        private System.Windows.Forms.Label label_SetupFile;
        private System.Windows.Forms.Button button_SetupFile;
        private System.Windows.Forms.TextBox textBox_SetupFile;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.Button button_Output;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.RichTextBox richTextBox_Console;
        private System.Windows.Forms.Button button_Go;
        private System.Windows.Forms.Label label_CommandLine;
    }
}

