using System;
using static System.Console;
using System.Globalization;
class SalesTransactionDemo
{
   static void Main()
   {
        // Write your main here.
   }
   public static void Display(SalesTransaction s)
   {
        // Write your Display() method here.
   }
   public static void DisplayTotal(SalesTransaction s)
   {
        // Write your DisplayTotal() method here.
   }
}
class SalesTransaction
{
  // fields
  public string Name {get; set;}
  public double SalesAmount {get; set;}
  public double Commission {get; set;}
  private double RATE;

  public SalesTransaction(string name, double salesAmount, double rate)
  {
    this.Name = name;
    this.SalesAmount = salesAmount;
    this.RATE = rate;
    this.Commission = salesAmount * rate;
  }

  public SalesTransaction(string name, double salesAmount)
  {
    this.Name = name;
    this.SalesAmount = salesAmount;
    this.Commission = 0;
    this.RATE = 0;
  }

  public SalesTransaction(string name)
  {
    this.Name = name;
    this.SalesAmount = 0;
    this.Commission = 0;
    this.RATE = 0;
  }

  public static SalesTransaction operator +(SalesTransaction a, SalesTransaction b)
  {
    return new SalesTransaction(a.Name, a.SalesAmount + b.SalesAmount);
  }

  public double getRate()
  {
    return RATE;
  }
}
