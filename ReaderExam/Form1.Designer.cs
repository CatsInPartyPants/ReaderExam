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
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.texbBoxPageFinder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textPage1
            // 
            this.textPage1.Location = new System.Drawing.Point(12, 12);
            this.textPage1.Margin = new System.Windows.Forms.Padding(4);
            this.textPage1.Name = "textPage1";
            this.textPage1.ReadOnly = true;
            this.textPage1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textPage1.Size = new System.Drawing.Size(333, 341);
            this.textPage1.TabIndex = 0;
            this.textPage1.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(364, 11);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(120, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(239, 360);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(108, 35);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = "> >";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 360);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "< <";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // texbBoxPageFinder
            // 
            this.texbBoxPageFinder.Location = new System.Drawing.Point(143, 367);
            this.texbBoxPageFinder.Name = "texbBoxPageFinder";
            this.texbBoxPageFinder.Size = new System.Drawing.Size(71, 23);
            this.texbBoxPageFinder.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.texbBoxPageFinder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.textPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox textPage1;
        private Button btnOpen;
        private OpenFileDialog openFileDialog1;
        private Button btnForward;
        private Button btnBack;
        private TextBox texbBoxPageFinder;
    }
}