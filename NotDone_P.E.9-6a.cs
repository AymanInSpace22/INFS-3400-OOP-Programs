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

    Sale[] obj = new Sale[10];
    for(int i = 0; i < 10; i++)
    {
      Write("Enter inventory number #" + (i + 1) + " >> ");
      inventoryNumber = ReadLine();

      Write("Enter amount of sale >> ");
      amount = Convert.ToDouble(ReadLine());

      obj[i] = new Sale();
      obj[i].InventoryNumber = inventoryNumber;
      obj[i].Amount = amount;
      obj[i].CalculateTax();
    }

    for(int i = 0; i < 10; i++)
    {
      WriteLine("Sale # {0} Amount: {1} Sale {2}",(i+1), obj[i].InventoryNumber, obj[i].Amount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      /*WriteLine("Sale #" + (i+1) + " Amount: " + obj[i].InventoryNumber + " Sale $", obj[i].Amount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Tax is $", obj[i].Tax.ToString("C", CultureInfo.GetCultureInfo("en-US")));*/
      WriteLine("   Tax is {0}", obj[i].Tax.ToString("C", CultureInfo.GetCultureInfo("en-US")));
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

    public double Tax
    {
      get
      {
        return tax;
      }
    }
 

   public void CalculateTax()
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
   }
}
