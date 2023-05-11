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
            this.pageCounterLabel = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxForFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddToFavorite = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnForward.Location = new System.Drawing.Point(237, 381);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(108, 35);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = "> >";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 381);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "< <";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // texbBoxPageFinder
            // 
            this.texbBoxPageFinder.Location = new System.Drawing.Point(142, 393);
            this.texbBoxPageFinder.Name = "texbBoxPageFinder";
            this.texbBoxPageFinder.Size = new System.Drawing.Size(71, 23);
            this.texbBoxPageFinder.TabIndex = 4;
            // 
            // pageCounterLabel
            // 
            this.pageCounterLabel.AutoSize = true;
            this.pageCounterLabel.Location = new System.Drawing.Point(12, 363);
            this.pageCounterLabel.Name = "pageCounterLabel";
            this.pageCounterLabel.Size = new System.Drawing.Size(0, 15);
            this.pageCounterLabel.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(352, 330);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(103, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxForFind
            // 
            this.textBoxForFind.Location = new System.Drawing.Point(352, 301);
            this.textBoxForFind.Name = "textBoxForFind";
            this.textBoxForFind.Size = new System.Drawing.Size(186, 23);
            this.textBoxForFind.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск информации в тексте:";
            // 
            // buttonAddToFavorite
            // 
            this.buttonAddToFavorite.Location = new System.Drawing.Point(364, 50);
            this.buttonAddToFavorite.Name = "buttonAddToFavorite";
            this.buttonAddToFavorite.Size = new System.Drawing.Size(120, 23);
            this.buttonAddToFavorite.TabIndex = 9;
            this.buttonAddToFavorite.Text = "Add to Favorites";
            this.buttonAddToFavorite.UseVisualStyleBackColor = true;
            this.buttonAddToFavorite.Click += new System.EventHandler(this.buttonAddToFavorite_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add a comment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddToFavorite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxForFind);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.pageCounterLabel);
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
        private Label pageCounterLabel;
        private Button buttonSearch;
        private TextBox textBoxForFind;
        private Label label1;
        private Button buttonAddToFavorite;
        private Button button1;
    }
}