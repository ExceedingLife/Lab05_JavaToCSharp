# Lab05_JavaToCSharp
Lab05 Create Text/Use classes/ Create Receipt : Console Application

Lab05 Using StreamWriter to create text file

1 Description
Write a CashRegister class that can be used with the given RetailItem class 
and the incomplete CashRegisterDemo class. 
The CashRegister class should simulate the sale of a retail item. 
It should have a constructor that accepts a RetailItem object as an argument. 
The constructor should also accept an integer that represents the quantity of items being purchased. 
In addition, the CashRegister class should have the following methods: 
• The getSubtotal method should return the subtotal of the sale, which is the quantity multiplied 
by the retail cost. This method must get the retail cost from the RetailItem object 
that was passed as an argument to the constructor. 
• The getTax method should return the amount of sales tax on the purchase. The sales tax rate is 6% of a retail sale. 
• The getTotal method should return the total of the sale, which is the subtotal plus the sales tax.

CashRegisterDemo class is the main program that asks the user for the quantity of items being purchased, 
and then generate a ﬁle named Receipt.txt with contents similar to the following:

SALES RECEIPT 
Unit Price: $10.00 
Quantity: 5 
Subtotal: $50.00 
Sales Tax: $3.00 
Total: $53.00


2 Grading
Grading Item                                                                            Scores 
The program can be compiled without any error messages                                    10 
The program can be run without any error messages                                         10 
The CashRegister class contains required methods and correct implementations              20 
The program can ask the user for the quantity of items being purchased                    10 
The program can generate ﬁle Receipt.txt and write correct information into the ﬁle       30 
Nice comments and proper indentations are used in the program                             10
