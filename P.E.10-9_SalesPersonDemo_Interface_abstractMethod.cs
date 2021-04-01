using System;
using static System.Console;
using System.Globalization;
class SalespersonDemo
{
  // parent abstract class SalesPerson
  // this means you cannot instantiate any objects from SalesPerson class
  // two fields in SalesPerson - firstName, lastName
  // SalesPerson constructor, properties and method GetName
  // two child classes - RealEstateSalesPerson, GirlScout
  // two methods - SalesPitch, MakeSale
   static void Main()
   {
     RealEstateSalesPerson p = new RealEstateSalesPerson("Joe", "Stevens", 39);

     GirlScout mandy = new GirlScout("Lana", "Green");

     p.SalesSpeech();
     mandy.SalesSpeech();

     p.MakeSale(100000);
     p.MakeSale(150000);

     mandy.MakeSale(2);
     mandy.MakeSale(10);
     mandy.MakeSale(4);

     WriteLine("{0} sold {1} worth of real estate", p.GetName(), p.TotalValueSold.ToString("C0", CultureInfo.GetCultureInfo("en-US")));
     WriteLine("At {0}%, the total commission earned is {1}", p.CommissionRate * 100, p.TotalCommissionEarned.ToString("C", CultureInfo.GetCultureInfo("en-US")));


    WriteLine();
    WriteLine("{0} sold  {1} boxes of cookies", mandy.GetName(), mandy.TotalBoxes);

   }
} // end of Main() method


// abstract goes before class
abstract class SalesPerson
{
  // properties
  public string FirstName {get; set;}
  public string LastName {get; set;}

  // constructor
  public SalesPerson(string first, string last)
  {
    this.FirstName = first;
    this.LastName = last;
  }

  // GetName method
  public string GetName()
  {
    string fullName = FirstName + " " + LastName;
    return fullName;
  }

}// end SalesPerson class


class RealEstateSalesPerson : SalesPerson, ISellable
{
  // properties
  public int TotalValueSold {get; set;}
  public double TotalCommissionEarned {get; set;}
  public double CommissionRate {get; set;}


  // constructor
  // you must put the inherited parameters into the list but then you ass the base and pull the methods
  public RealEstateSalesPerson(string first, string last, double rate) : base(first, last)
  {
    this.CommissionRate = rate;
    this.TotalValueSold = 0;
    this.TotalCommissionEarned = 0;
  }


  // pulling int our interface methods
  public void SalesSpeech()
  {
    WriteLine("This property will double in value in the next ten years");
  }

  public void MakeSale(int amt)
  {
    TotalValueSold += amt;
    TotalCommissionEarned = TotalValueSold * CommissionRate;
  }

}// end of RealEstateSalesPerson class


class GirlScout : SalesPerson, ISellable
{
  // properties
  public int TotalBoxes {get; set;}

  // constructor
  public GirlScout(string first, string last) : base(first, last)
  {
    this.TotalBoxes = 0;
  }


  // pulling in our interface methods
  public void SalesSpeech()
  {
    WriteLine("would you like to buy some cookies?");
  }

  public void MakeSale(int boxes)
  {
    TotalBoxes += boxes;
  }

}// end of GirlScout class

// creating an interface
// interface methods aer all technically abstract becuase they cannot have method bodies
public interface ISellable
{
  // dont put public in front of your interface methods
   void SalesSpeech();
  
   void MakeSale(int amount);
}


