using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_JavaToCSharp
{
    class Program
    {
        // Class as CashRegisterDemo
        static void Main(string[] args)
        {
            int quantity = 0;   // Quantity being purchased.

            // Create RetailItem object.
            RetailItem item = new RetailItem("Candy bar", 17789, 0.75, 1.50);

            // Get the quantity.
            Console.WriteLine("How many candy bars are you buying ?");
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out quantity))
            {
                // Create a CashRegister object.

                CashRegister reg = new CashRegister(item, quantity);


                // Write the sales data to file Receipt.txt
                /* Missing code starts here */

                // Using a StreamWriter to create a txt file and write to it.
                // File.WriteAllLines & File.WriteAllText would also create a .txt file and write to it.
                using (System.IO.StreamWriter streamWriter =
                    new System.IO.StreamWriter(@"C:\Users\extre_000\Documents\GitHub\Lab05_JavaToCSharp\Lab05_JavaToCSharp\Receipt.txt"))
                {
                    streamWriter.WriteLine("SALES RECEIPT");
                    streamWriter.WriteLine("Unit Price: " + item.GetRetail().ToString("C"));
                    streamWriter.WriteLine("Quantity: " + quantity);
                    streamWriter.WriteLine("Subtotal: " + reg.GetSubtotal().ToString("C"));
                    streamWriter.WriteLine("Sales Tax: " + reg.GetTax() * reg.GetSubtotal());
                    streamWriter.WriteLine("Total: " + reg.GetTotal().ToString("C"));
                }

                /* Missing code ends here */
            }
            else
            {
                Console.WriteLine("User input must be an 'Integer' (number)\n" +
                                    "Press any key to exit the program");
                Console.ReadKey();
            }              
        }
    }
}
