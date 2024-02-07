namespace GUIWinpreptool
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
            this.textBox_SrcPath = new System.Windows.Forms.TextBox();
            this.button_SrcPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_SrcPath
            // 
            this.textBox_SrcPath.Location = new System.Drawing.Point(40, 43);
            this.textBox_SrcPath.Name = "textBox_SrcPath";
            this.textBox_SrcPath.Size = new System.Drawing.Size(202, 20);
            this.textBox_SrcPath.TabIndex = 0;
            this.textBox_SrcPath.Text = "Source folder...";
            // 
            // button_SrcPath
            // 
            this.button_SrcPath.Location = new System.Drawing.Point(248, 41);
            this.button_SrcPath.Name = "button_SrcPath";
            this.button_SrcPath.Size = new System.Drawing.Size(75, 23);
            this.button_SrcPath.TabIndex = 1;
            this.button_SrcPath.Text = "Edit";
            this.button_SrcPath.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_SrcPath);
            this.Controls.Add(this.textBox_SrcPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SrcPath;
        private System.Windows.Forms.Button button_SrcPath;
    }
}

