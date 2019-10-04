using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk1._0
{
    public partial class SearchQuotes : Form
    {
        string lines;
        int i = 0;
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SubmitSearch_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader queryFile = new StreamReader("RecordDatabase.text");
                searchResults.Clear();
                while (queryFile.EndOfStream == false)
                {
                    lines = queryFile.ReadLine();
                    if (searchQuery.Text == "")
                    {
                        searchResults.AppendText("Please Enter a Material Before Submitting");
                        break;
                    }
                    else
                    {
                        if (lines.Contains(searchQuery.Text))
                              searchResults.AppendText(lines + Environment.NewLine);
                        
                    }             
                }


            }
            catch (System.IO.FileNotFoundException)
            {
                searchResults.AppendText(String.Empty);
                searchResults.AppendText("File Not Found");
            }

        }

        private void BackQuoteButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void SearchQuery_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
