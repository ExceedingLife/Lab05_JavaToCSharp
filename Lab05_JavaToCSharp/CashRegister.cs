using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_JavaToCSharp
{
    class CashRegister
    {
        private double subTotal = 0;
        private double tax = 0;
        private double total = 0;


        // Constructor for CashRegister
        public CashRegister(RetailItem item, int q)
        {
            subTotal = q * item.GetRetail();
            tax = .06;
            total = subTotal + (subTotal * tax);
        }

        // GetSubtotal()
        public double GetSubtotal()
        {
            return subTotal;
        }

        // GetTax()
        public double GetTax()
        {
            return tax;
        }

        // GetTotal()
        public double GetTotal()
        {
            return total;
        }
    }
}
