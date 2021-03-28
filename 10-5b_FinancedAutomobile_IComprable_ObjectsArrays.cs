using System;
using System.Collections;
using static System.Console;
using System.Globalization;
class AutomobileDemo2
{
   static void Main()
   {
     // Your code here

     FinancedAutomobile[] finArray = new FinancedAutomobile[4];
     for(int i = 0; i < finArray.Length; ++i)
     {
       
       FinancedAutomobile finAuto = new FinancedAutomobile();

       do 
       {
         finAuto.IdNumber = int.Parse(Console.ReadLine());
       }while (AutomobileDemo2.HasID(finArray, finAuto.IdNumber));

        finAuto.Make = Console.ReadLine();
        finAuto.Year = int.Parse(Console.ReadLine());
        finAuto.Price = double.Parse(Console.ReadLine());
        finAuto.AmtFinanced = double.Parse(Console.ReadLine());

        finArray[i] = finAuto;


     }
      Console.WriteLine("Summary:");
      Array.Sort(finArray, new AutoComparer());

      double total = 0;
      double totalFinanced = 0;
      foreach (FinancedAutomobile car in finArray)
        {

            Console.WriteLine(car.ToString());
            total += car.Price;
            totalFinanced += car.AmtFinanced;
        }

        Console.WriteLine("Total for all Automobiles is {0}", total.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("Total financed all Automobiles is {0}", totalFinanced.ToString("C", CultureInfo.GetCultureInfo("en-US")));
   }

  public static bool HasID(FinancedAutomobile[] finArray, int id)
    {
      for (int i = 0; i < finArray.Length; ++i)
      {
        if(finArray[i] != null && finArray[i].IdNumber == id)
          return true;
      }
      return false;
    }

}






class Automobile 
{
    // auto implemented properties
    public int IdNumber { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }

    
    // constructor
    public Automobile()
    {

    }

    public Automobile(int idNum, string make, int year, double price)
    {
        this.IdNumber = idNum;
        this.Make = make;
        this.Year = year;
        this.Price = price;
    }


    public override string ToString()
    {
        return string.Format("Automobile {0} {1} {2} Price is {3}", IdNumber, Year, Make, Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }


    public static Automobile NewInstance()
    {
      Console.WriteLine("Enter Idnumber, make, year, and price");

      Automobile newAuto = new Automobile();
      

      newAuto.IdNumber = int.Parse(Console.ReadLine());
      newAuto.Make = Console.ReadLine();
      newAuto.Year = int.Parse(Console.ReadLine());
      newAuto.Price = double.Parse(Console.ReadLine());

      return newAuto;
    }

}








class FinancedAutomobile : Automobile
{
  public double AmtFinanced { get; set;}

  public FinancedAutomobile()
  {
    
  }

  public FinancedAutomobile(int idNum, string make, int year, double price, double amountFin) : base (idNum, make, year, price)
  {
    this.AmtFinanced = amountFin;
  }

  public override string ToString()
  {
     return string.Format("FinancedAutomobile {0} {1} {2} Price is {3} Amount financed {4}", IdNumber, Year, Make, Price.ToString("C", CultureInfo.GetCultureInfo("en-US")), AmtFinanced.ToString("C", CultureInfo.GetCultureInfo("en-US")));
  }


}


class AutoComparer : IComparer
{


    int IComparer.Compare(object x, object y)
    {
        FinancedAutomobile auto1 = (FinancedAutomobile)x;
        FinancedAutomobile auto2 = (FinancedAutomobile)y;

        if (auto1.IdNumber < auto2.IdNumber)
            return -1;
        else if (auto1.IdNumber > auto2.IdNumber)
            return 1;
        else
            return 0;
    }
}
