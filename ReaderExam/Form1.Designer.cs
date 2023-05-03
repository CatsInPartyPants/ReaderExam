namespace ReaderExam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textPage1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textPage1
            // 
            this.textPage1.Enabled = false;
            this.textPage1.Location = new System.Drawing.Point(12, 12);
            this.textPage1.Margin = new System.Windows.Forms.Padding(4);
            this.textPage1.Name = "textPage1";
            this.textPage1.ReadOnly = true;
            this.textPage1.Size = new System.Drawing.Size(333, 341);
            this.textPage1.TabIndex = 0;
            this.textPage1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox textPage1;
    }
}