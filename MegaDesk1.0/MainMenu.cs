using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk1._0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            AddQuote aqx = new AddQuote();
            aqx.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewQuoteButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes vaq = new ViewAllQuotes();
            vaq.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchQuotes sq = new SearchQuotes();
            sq.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
