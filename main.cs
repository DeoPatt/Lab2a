using System;

class MainClass {
  public static void Main (string[] args) {
    
//Itemname
Console.WriteLine("Enter the name of item");
string Itemname = Console.ReadLine();

//Quantity

Console.WriteLine("Quantity");

int quantity = Convert.ToInt32(Console.ReadLine());


// price

Console.WriteLine(" Price");

double price = Convert.ToInt32(Console.ReadLine());


//Unit price
Console.WriteLine("Total Price of " + Itemname);
 Console.WriteLine("$" + quantity * price);
 
 

 
 
 
  }
}