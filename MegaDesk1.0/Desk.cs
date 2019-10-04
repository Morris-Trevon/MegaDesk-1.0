using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk1._0
{
    class Desk
    {
        string orderID;
        private double deskSurfaceArea;
        private double width;
        private double depth;
        private int numDrawers;
        private double widthMin = 24;
        private double widthMax = 96;
        private double depthMin = 12;
        private double depthMax = 48;
        private double rushOrderPrice;
        private string surfaceMaterialType;

        public Desk()
        {
            //Declare a new object
        }

        internal bool CheckMeasureMent(double xwidth, double xdepth, int xnumDrawer, int rushOrderDays, string surfaceMats)
        {
            bool returnCondition = false;

            

            if ((xwidth >= widthMin && xwidth <= widthMax) && (xdepth >= depthMin && xdepth <= depthMax) && (xnumDrawer >= 0 && xnumDrawer <= 7))
            {
                width = xwidth;
                depth = xdepth;
                numDrawers = xnumDrawer;
                Random rnd = new Random();
                
                deskSurfaceArea = width * depth;
                surfaceMaterialType = surfaceMats;
                orderID = "TM" + deskSurfaceArea + ":" + rnd.Next(1, 50).ToString() + ":" + rnd.Next(1000, 5000).ToString();

                if (rushOrderDays == 0)
                {
                    rushOrderPrice = 0;
                }
                else if (rushOrderDays == 3)
                {
                    if(deskSurfaceArea < 1000)
                    {
                        rushOrderPrice = 60;
                    }
                    else if (deskSurfaceArea >= 1000 && deskSurfaceArea <= 2000)
                    {
                        rushOrderPrice = 70;
                    }
                    else
                    {
                        rushOrderPrice = 80;
                    }
                }else if(rushOrderDays == 5)
                {
                    if (deskSurfaceArea < 1000)
                    {
                        rushOrderPrice = 40;
                    }
                    else if (deskSurfaceArea >= 1000 && deskSurfaceArea <= 2000)
                    {
                        rushOrderPrice = 50;
                    }
                    else
                    {
                        rushOrderPrice = 60;
                    }
                }
                else
                {
                    if (deskSurfaceArea < 1000)
                    {
                        rushOrderPrice = 30;
                    }
                    else if (deskSurfaceArea >= 1000 && deskSurfaceArea <= 2000)
                    {
                        rushOrderPrice = 35;
                    }
                    else
                    {
                        rushOrderPrice = 40;
                    }
                }

                               

                returnCondition = true;
                return returnCondition;

            }
            else
            {
                returnCondition = false;
                return returnCondition;
            }
        }

        internal string getOrderId()
        {

            return orderID;
        }

        internal int GetNumDrawers()
        {
            return numDrawers;
        }
                
        internal double GetRushPrice()
        {
            return rushOrderPrice;
        }

        internal double GetSurfaceArea()
        {
            return deskSurfaceArea;
        }

        internal string GetSurfaceMaterial()
        {
            return surfaceMaterialType;
        }
        

        
    }

   
}
