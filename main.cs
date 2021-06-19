using System;

class MainClass {
  public static void Main (string[] args) {
    
//Itemname
Console.WriteLine("Enter the name of item");
string Itemname = Console.ReadLine();

//Quantity
double quantity; 
double tprice;
Console.WriteLine("Enter the Quantity");


quantity = Convert.ToDouble( Console.ReadLine());

// price

Console.WriteLine("Enter the Price");

tprice = Convert.ToDouble(Console.ReadLine());


//Unit price
Console.WriteLine("Total Price of " + Itemname);
 Console.WriteLine("$" + quantity * tprice);
 
 

 
 
 
  }
}