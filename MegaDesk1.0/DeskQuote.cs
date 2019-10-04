using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDesk1._0
{

    class DeskQuote
    {
        //Declare all variables to be used by class
        private double finalPrice;
        private const int productionTimeDays = 14;
        private double basePrice = 200;
        private double singleDrawer = 50;
        private double deskSurface;
        private double surfaceAreaPrice = 0;
        private string surfaceMatType;
        private double surfaceMatPrice = 0;
        string quoteID;

        MegaDesk1._0.Desk oi = new Desk();

        public DeskQuote() {
            //Constructor for DeskQuote 
        }

        internal double CalQuote(int numDrawer, double rushOrderPrice, double deskSurfaceArea, string surfaceMat)
        {
            double finalCal = 0;

            //Check the price of mats to add to final price
            if (surfaceMat == "Rosewood")
            {
                surfaceMatPrice = 300;
            } else if (surfaceMat == "Oak")
            {
                surfaceMatPrice = 200;
            } else if (surfaceMat == "Veneer")
            {
                surfaceMatPrice = 125;
            } else if (surfaceMat == "Laminate")
            {
                surfaceMatPrice = 100;
            }
            else
            {
                surfaceMatPrice = 50;
            }

            //Check if surface area should be added to price
            if (deskSurfaceArea > 1000)
                surfaceAreaPrice = deskSurfaceArea;

            //Calculate the Final Price
            finalCal = basePrice + (singleDrawer * numDrawer) + rushOrderPrice + deskSurfaceArea + surfaceMatPrice;

            //assign all collected data to variable for later access
            
            finalPrice = finalCal;
            deskSurface = deskSurfaceArea;
            surfaceMatType = surfaceMat;

            return finalCal;


        }

        internal void SetQuoteID(string orderId){

            quoteID = surfaceMatType + "[ "+orderId+" ]";
           
        }

        internal string GetFinalPrice()
        {
            return finalPrice.ToString();
        }

        internal string GetDeskSurface()
        {
            return deskSurface.ToString();
        }

        internal string GetQuoteID()
        {
            return quoteID;
        }

        internal string GetSurfaceMat()
        {
            return surfaceMatType;
        }
    }

    class CustomerInfo
    {
        private string firstName;
        private string lastName;
        private string customerID;
       
        public CustomerInfo()
        {
            //Constructor for CustomerInfo
        }

        internal void SetNameAndID(string xfirstName, string xlastName, string xOrderID)
        {
            customerID = xlastName + "[ " + xOrderID+" ]";
            lastName = xlastName;
            firstName = xfirstName;

        }

        internal string GetFullName()
        {
            return firstName + " " + lastName;
        }

        internal string GetCustID()
        {
            return customerID;
        }
    }


}
