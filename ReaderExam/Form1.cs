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
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            textPage1.Text = navigator.ShowPage(navigator.currentPage++);
            navigator.currentPage += 1;
        }
    }
}
