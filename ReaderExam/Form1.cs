using Microsoft.Office.Interop.Word;

namespace ReaderExam
{
    public partial class Form1 : Form
    {
        GetStringsFromFile getStringFromFile;
        Navigator navigator;
        public Form1()
        {
            getStringFromFile = new GetStringsFromFile();
            
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            textPage1.SelectionAlignment = HorizontalAlignment.Center;
            textPage1.Clear(); // очистка поля 
            navigator = new Navigator(getStringFromFile.OpenFile());
            textPage1.Text = navigator.ShowPage(0);
            pageCounterLabel.Text = "Page: " + navigator.currentPage.ToString();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if(texbBoxPageFinder.Text == "" && navigator.currentPage < navigator.totalPages)
            {
                navigator.currentPage += 1;
                textPage1.Text = navigator.ShowPage(navigator.currentPage);
                pageCounterLabel.Text = "Page: " + navigator.currentPage.ToString();
            }
            else
            {
                try
                {
                    navigator.currentPage = Int32.Parse(texbBoxPageFinder.Text);
                    textPage1.Text = navigator.ShowPage(navigator.currentPage);
                }
                catch { }
                pageCounterLabel.Text = "Page: " + navigator.currentPage.ToString();
                texbBoxPageFinder.Clear();                
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(navigator.currentPage > 0)
            {
                navigator.currentPage -= 1;
            }
            pageCounterLabel.Text = "Page: " + navigator.currentPage.ToString();
            textPage1.Text = navigator.ShowPage(navigator.currentPage);
        }
    }
}
