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
    public partial class AddQuote : Form
    {
        double bwidth;
        double bdepth;
        int bdrawer;
        int recordKeep = 0;
        string recordHolder;

        //Declare the Struct from which the array will be made to store data
        struct AccountQuote
        {
            public string fullName;
            public string CustomerID;
            public string OrderID;
            public string QuoteID;
            public string surfaceArea;
            public string material;
            public string finalPrice;
            
        };

        //Declare all Class to ensure Persistence of all values from one space
        MegaDesk1._0.Desk d = new Desk();
        MegaDesk1._0.CustomerInfo ci = new CustomerInfo();
        MegaDesk1._0.DeskQuote dq = new DeskQuote();

        
        public AddQuote()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackQuoteButton_Click(object sender, EventArgs e)
        {
            //Ensure you can go back to menu and hide the current window
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Reset the Form to start fresh
            textWidth.Text = String.Empty;
            textDepth.Text = String.Empty;
            textDrawer.Text = String.Empty;
            textFName.Text = String.Empty;
            textLName.Text = String.Empty;
            listRush.SelectedItem = "0";
            surfaceMat.SelectedItem = "Oak";
            this.errorInfo.Text = String.Empty;
            
        }

        private void SubmitDimensions_Click(object sender, EventArgs e)
        {
            //Use a try catch statement in case of any known error
            try
            {
                bwidth = Convert.ToDouble(textWidth.Text);
                bdepth = Convert.ToDouble(textDepth.Text);
                bdrawer = Convert.ToInt32(textDrawer.Text);

                if (d.CheckMeasureMent(bwidth, bdepth, bdrawer, Int32.Parse(listRush.SelectedItem.ToString()), surfaceMat.SelectedItem.ToString()) == true)
                {
                    //Create Struct Account to store records in Array
                    AccountQuote[] account = new AccountQuote[100];

                    //Run the final cost calculations based on the data authenticated for the finalPrice
                    account[recordKeep].finalPrice = dq.CalQuote(d.GetNumDrawers(), d.GetRushPrice(), d.GetSurfaceArea(), d.GetSurfaceMaterial()).ToString();
                    
                    //Store the Customer Information and create CustomerID from OrderID
                    ci.SetNameAndID(textFName.Text, textLName.Text,d.getOrderId());
                    
                    //Set QuoteIDfrom the order ID
                    dq.SetQuoteID(d.getOrderId());

                    //Write to file before resetting form and confirming submission                    
                    account[recordKeep].fullName = ci.GetFullName();
                    account[recordKeep].CustomerID = ci.GetCustID();
                    account[recordKeep].OrderID = d.getOrderId();
                    account[recordKeep].QuoteID = dq.GetQuoteID();
                    account[recordKeep].surfaceArea = dq.GetDeskSurface();
                    account[recordKeep].material = dq.GetSurfaceMat();
                    account[recordKeep].finalPrice = dq.GetFinalPrice();

                    //Store the Record in a single Line
                    recordHolder = "Name: " + account[recordKeep].fullName + ", CID: " + account[recordKeep].CustomerID + ", OID: " + account[recordKeep].OrderID +
                        ", QID: " + account[recordKeep].QuoteID + ", Dimensions: " + account[recordKeep].surfaceArea + ", Material: " + account[recordKeep].material +
                        ", FinalPrice: $" + account[recordKeep].finalPrice;


                    //Declare the StreamWriter
                    StreamWriter recordWriter = new StreamWriter("RecordDatabase.text", true);
                    //Write the record to file
                    recordWriter.WriteLine(recordHolder);
                    //Close the writer
                    recordWriter.Close();
                    

                    //Increment the recordKeep everytime this If statement submits and empty recordHolder
                    recordHolder = String.Empty;
                    recordKeep++;

                    this.errorInfo.Text = "Form Submitted for "+ textFName.Text+" "+textLName.Text+" Final Price: $"+ dq.GetFinalPrice();
                    textWidth.Text = String.Empty;
                    textDepth.Text = String.Empty;
                    textDrawer.Text = String.Empty;
                    textFName.Text = String.Empty;
                    textLName.Text = String.Empty;
                    listRush.SelectedItem = "0";                    

                }
                else
                {
                    //Display error on AddQuote Error section 

                    this.errorInfo.Text = "Error in your submission";
                }
            }catch(IOException er)
            {
                
                this.errorInfo.Text = "You cannot submit a blank form "+ er.Message;
            }catch(FormatException fr)
            {
                this.errorInfo.Text = "You cannot submit a blank form " + fr.Message;
            }


        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void ListRush_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }
    }
}
