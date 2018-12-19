using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_JavaToCSharp
{
    class RetailItem
    {
        private string description = "";
        private int itemNumber = 0;
        private CostData cost = null;

        public RetailItem(string desc, int item, double wholesale, double retail)
        {
            description = desc;
            itemNumber = item;
            cost = new CostData(wholesale, retail);
        }

        public void SetWholeSale(double w)
        {
            cost.wholeSale = w;
        }
        public double GetWholeSale()
        {
            return cost.wholeSale;
        }

        public void SetRetail(double r)
        {
            cost.retail = r;
        }
        public double GetRetail()
        {
            return cost.retail;
        }

        public override string ToString()
        {
            return string.Format("Description:{0}\nItemNumber:{1}\nWholesale Cost:{2}\nRetail Cost:{3}", 
                    description, itemNumber, cost.wholeSale.ToString("C"), cost.retail.ToString("C"));
        }
    }
    // Inner Class 'CostData'
    class CostData
    {
        public double wholeSale = 0;
        public double retail = 0;

        public CostData(double w, double r)
        {
            wholeSale = w;
            retail = r;
        }
    }
}
