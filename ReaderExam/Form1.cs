using Microsoft.Office.Interop.Word;
using Application = System.Windows.Forms.Application;

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
            navigator = new Navigator(getStringFromFile.OpenFile("C:\\"));
            textPage1.Text = navigator.ShowPage(0);
            pageCounterLabel.Text = "Page: " + navigator.currentPage.ToString();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (navigator != null)
            {
                if (texbBoxPageFinder.Text == "" && navigator.currentPage < navigator.totalPages)
                {
                    navigator.currentPage += 1; // увеличиваем значение текущей страницы
                    textPage1.Text = navigator.ShowPage(navigator.currentPage); //показываем текущую страницу
                    pageCounterLabel.Text = "Page: " + navigator.currentPage.ToString(); // добавляем номер
                }
                else
                {
                    try
                    {
                        navigator.currentPage = Int32.Parse(texbBoxPageFinder.Text);
                        textPage1.Text = navigator.ShowPage(navigator.currentPage);

                    }
                    catch(Exception ex) {
                        //MessageBox.Show(ex.ToString(), "Error");
                    }
                    pageCounterLabel.Text = "Page: " + navigator.currentPage.ToString();
                    texbBoxPageFinder.Clear();

                }
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (navigator != null)
            {
                if (navigator.currentPage > 0)
                {
                    navigator.currentPage -= 1;
                }
                pageCounterLabel.Text = "Page: " + navigator.currentPage.ToString();
                textPage1.Text = navigator.ShowPage(navigator.currentPage);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(textBoxForFind.Text != "" && navigator != null)
            {
                int page = 0;
                page = navigator.FindPageByText(textBoxForFind.Text);
                if (page >= 0)
                {
                    MessageBox.Show("Текст найден на станице " + page.ToString() + ".", "Информация");
                    textPage1.Text = navigator.ShowPage(page);
                    textBoxForFind.Clear();
                }
                else
                {
                    MessageBox.Show("Текст не найден.", "Информация");
                    textBoxForFind.Clear();
                }
            }
        }

        private void buttonAddToFavorite_Click(object sender, EventArgs e)
        {
            if(textPage1.SelectedText == "")
            {
                MessageBox.Show("Выделите текст.", "Информация");
            }
            else
            {
                Favorites.AddToFile(textPage1.SelectedText);
                MessageBox.Show("Выделенный текст сохранен в файл Favorites.txt", "Информация");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.BackColor = Color.WhiteSmoke;
            textPage1.BackColor = Color.White;
            textBoxForFind.BackColor = Color.White;
            texbBoxPageFinder.BackColor = Color.White;

            btnOpen.BackColor = Color.WhiteSmoke;
            buttonAddToFavorite.BackColor = Color.WhiteSmoke;
            buttonAddComment.BackColor = Color.WhiteSmoke;
            buttonSearch.BackColor = Color.WhiteSmoke;
            btnBack.BackColor = Color.WhiteSmoke;
            btnForward.BackColor = Color.WhiteSmoke;
            buttonLibrary.BackColor = Color.WhiteSmoke;
        }

        private void nightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
            textPage1.BackColor = Color.DarkGray;
            textBoxForFind.BackColor = Color.DarkGray;
            texbBoxPageFinder.BackColor = Color.DarkGray;

            btnOpen.BackColor = Color.DarkGray;
            buttonAddToFavorite.BackColor = Color.DarkGray;
            buttonAddComment.BackColor = Color.DarkGray;
            buttonSearch.BackColor = Color.DarkGray;
            btnBack.BackColor = Color.DarkGray;
            btnForward.BackColor = Color.DarkGray;
            buttonLibrary.BackColor = Color.DarkGray;
        }

        private void buttonLibrary_Click(object sender, EventArgs e)
        {
            textPage1.SelectionAlignment = HorizontalAlignment.Center;
            textPage1.Clear(); // очистка поля 
            navigator = new Navigator(getStringFromFile.OpenFile("C:\\Program Files\\MyLibrary"));
            textPage1.Text = navigator.ShowPage(0);
            pageCounterLabel.Text = "Page: " + navigator.currentPage.ToString();
        }
    }
}
