using System;
using static System.Console;
using System.Globalization;
class SalesTaxDemo
{
   static void Main()
   {
    // Write your main here.
    string inventoryNumber;
    double amount;

    Sale[] sales = new Sale[10];
    for(int i = 0; i < 10; i++)
    {
      Write("Enter inventory number #" + (i + 1) + " >> ");
      inventoryNumber = ReadLine();

      Write("Enter amount of sale >> ");
      amount = Convert.ToDouble(ReadLine());

      sales[i] = new Sale();
      sales[i].InventoryNumber = inventoryNumber;
      sales[i].Amount = amount;
      sales[i].CalculateTax();
    }

    for(int i = 0; i < 10; i++)
    {
      WriteLine("Sale # {0} Amount: {1} Sale {2}",(i+1), sales[i].InventoryNumber, sales[i].Amount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      /*WriteLine("Sale #" + (i+1) + " Amount: " + obj[i].InventoryNumber + " Sale $", obj[i].Amount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Tax is $", obj[i].Tax.ToString("C", CultureInfo.GetCultureInfo("en-US")));*/
      WriteLine("   Tax is {0}", sales[i].Tax.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }


   }
}



class Sale
{    
    // Write your Sale class here.
    // fields
    private string inventoryNumber;
    private double amount;
    private double tax;

    // properties
    public string InventoryNumber
    {
      get
      {
        return inventoryNumber;
      }
      set
      {
        inventoryNumber = value;
      }
    }

    public double Amount
    {
      get 
      {
        return amount;
      }
      set
      {
        amount = value;
      }
    }

    // we are returning out method here because it is doing our calculation for tax
    public double Tax
    {
      get
      {
        return CalculateTax();
      }
    }
 

   public double CalculateTax()
   {
    // Write your CalculateTax method here.
    if(amount < 100)
    {
      tax = amount * .08;
    }
    else
    {
      tax = 100 * 0.08 + (amount - 100) * 0.06;
    }
    // returning this to our Tax property
    return tax;
   }
}
