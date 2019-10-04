using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class ViewAllQuotes : Form
    {
        string line;

        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void BackQuoteButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void ViewQueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Use Stream Reader to run through the file line by line and print a line below for uniformity
                StreamReader readRecords = new StreamReader("RecordDatabase.text", true);
                while (readRecords.EndOfStream == false)
                {
                    line = readRecords.ReadLine();
                    displayRecords.AppendText(line+Environment.NewLine);
                    displayRecords.AppendText("----------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
                }
                
                readRecords.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                displayRecords.Text = "No Queries Exist, Please Add Some";
            }
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {

        }

        private void DisplayRecords_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
