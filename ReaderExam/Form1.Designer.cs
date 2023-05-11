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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPage1
            // 
            this.textPage1.BackColor = System.Drawing.Color.White;
            this.textPage1.ForeColor = System.Drawing.Color.Black;
            this.textPage1.Location = new System.Drawing.Point(12, 37);
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
            this.btnOpen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpen.Location = new System.Drawing.Point(364, 37);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(120, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
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
            this.buttonAddToFavorite.Location = new System.Drawing.Point(364, 76);
            this.buttonAddToFavorite.Name = "buttonAddToFavorite";
            this.buttonAddToFavorite.Size = new System.Drawing.Size(120, 23);
            this.buttonAddToFavorite.TabIndex = 9;
            this.buttonAddToFavorite.Text = "Add to Favorites";
            this.buttonAddToFavorite.UseVisualStyleBackColor = true;
            this.buttonAddToFavorite.Click += new System.EventHandler(this.buttonAddToFavorite_Click);
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.Location = new System.Drawing.Point(364, 116);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(120, 23);
            this.buttonAddComment.TabIndex = 10;
            this.buttonAddComment.Text = "Add a comment";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.styleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayToolStripMenuItem,
            this.toolStripSeparator1,
            this.nightToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // dayToolStripMenuItem
            // 
            this.dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            this.dayToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.dayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dayToolStripMenuItem.Text = "Day";
            this.dayToolStripMenuItem.Click += new System.EventHandler(this.dayToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // nightToolStripMenuItem
            // 
            this.nightToolStripMenuItem.Name = "nightToolStripMenuItem";
            this.nightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.nightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nightToolStripMenuItem.Text = "Night";
            this.nightToolStripMenuItem.Click += new System.EventHandler(this.nightToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(546, 437);
            this.Controls.Add(this.buttonAddComment);
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
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simple Text Reader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private Button buttonAddComment;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem styleToolStripMenuItem;
        private ToolStripMenuItem dayToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem nightToolStripMenuItem;
    }
}