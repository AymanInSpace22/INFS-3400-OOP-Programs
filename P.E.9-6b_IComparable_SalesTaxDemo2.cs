using System;
using static System.Console;
using System.Globalization;
class SalesTaxDemo2
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

    Array.Sort(sales);
   

    for(int i = 0; i < 10; i++)
    {
      WriteLine("Sale # {0} Amount: {1} Sale {2}",(i+1), sales[i].InventoryNumber, sales[i].Amount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      /*WriteLine("Sale #" + (i+1) + " Amount: " + obj[i].InventoryNumber + " Sale $", obj[i].Amount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Tax is $", obj[i].Tax.ToString("C", CultureInfo.GetCultureInfo("en-US")));*/
      WriteLine("   Tax is {0}", sales[i].Tax.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }

   

   }
}


// adding the IComparable
class Sale : IComparable
{    
    // Write your Sale class here.
    // fields
    /*private string inventoryNumber;
    private double amount;
    private double tax;*/

    // properties
    public string InventoryNumber
    {
      /*get
      {
        return inventoryNumber;
      }
      set
      {
        inventoryNumber = value;
      }*/
      get; set;
    }

    public double Amount
    {
      /*get 
      {
        return amount;
      }
      set
      {
        amount = value;
      }*/
      get; set;
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
    if(Amount < 100)
    {
      return Amount * .08;
    }
    else
    {
      return 100 * 0.08 + (Amount - 100) * 0.06;
    }
   }

    int IComparable.CompareTo(object o)
    {
      int returnValue;
      Sale temp = (Sale)o;
      if(this.Tax > temp.Tax)
        returnValue = 1;
      else 
      if(this.Tax < temp.Tax)
        returnValue = -1;
      else 
        returnValue = 0;

      return returnValue;      
    }

}
