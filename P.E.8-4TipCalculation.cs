using System;
using static System.Console;
using System.Globalization;
class TipCalculation
{
   static void Main()
   {
      // Write your main here
      double price;
      double tip;
      int tipInt;

      // prompt the user to enter the double inputs
      Write("Enter a floating point price of the item:  ");
      price = double.Parse(ReadLine());
      Write("Enter tip amount: ");
      tip = double.Parse(ReadLine());

    
      DisplayTipInfo(price, tip);


      // prompt user to enter tip rate as an integer
      // and price as double
      Write("Enter the price of another item: ");
      price = double.Parse(ReadLine());
      Write("Enter the tip amount as a whole number: ");
      tipInt = int.Parse(ReadLine());


     
      DisplayTipInfo(price, tipInt);

   }

   public static void DisplayTipInfo(double price, double tipRate)
   {
    
     double amount = price * tipRate;

     double sum = price + amount;

     
     // display the input in the console
     WriteLine("Meal price: " + price.ToString("C", CultureInfo.GetCultureInfo("en-US")) + ". Tip percent: " + tipRate.ToString("F"));
     WriteLine("Tip in dollars: " + amount.ToString("C", CultureInfo.GetCultureInfo("en-US")) + ".  Total bill " + sum.ToString("C", CultureInfo.GetCultureInfo("en-US")));

   }
   
   public static void DisplayTipInfo(double price, int tipInDollars)
   {
  
     double rate = price / tipInDollars;

     double sum = price + tipInDollars;

     WriteLine("Meal price: " + price.ToString("C", CultureInfo.GetCultureInfo("en-US")) + ". Tip percent: $" + rate.ToString("F"));
     WriteLine("Tip in dollars: " + tipInDollars.ToString("C", CultureInfo.GetCultureInfo("en-US")) + ". Total bill: " + sum.ToString("C", CultureInfo.GetCultureInfo("en-US")));


   }

}
