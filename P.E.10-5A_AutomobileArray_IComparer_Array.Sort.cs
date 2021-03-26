using System;
using System.Collections;
using static System.Console;
using System.Globalization;
class AutomobileDemo
{
    static void Main()
    {
        // Your code here
        //Automobile auto1 = new Automobile();
        //auto1.IdNumber = 1;
        //auto1.Make = "Honda";
        //auto1.Year = 2017;
        //auto1.Price = 30000;

        //Automobile auto2 = new Automobile();
        //auto2.IdNumber = 45;
        //auto2.Make = "Toyota";
        //auto2.Year = 2016;
        //auto2.Price = 20000;

        //Automobile auto3 = new Automobile(44, "Honda", 2016, 35000);


        //Console.WriteLine(auto1.ToString());
        //Console.WriteLine(auto2.ToString());

        //Console.WriteLine(auto3.ToString());

        Automobile[] autoArray = new Automobile[8];
        for(int i = 0; i < autoArray.Length; ++i)
        {
          Console.WriteLine("Enter Idnumber, make, year, and price");

          Automobile newAuto = new Automobile();

          do 
          {
            newAuto.IdNumber = int.Parse(Console.ReadLine());
          } while (AutomobileDemo.HasID(autoArray, newAuto.IdNumber));

          newAuto.Make = Console.ReadLine();
          newAuto.Year = int.Parse(Console.ReadLine());
          newAuto.Price = double.Parse(Console.ReadLine());

          autoArray[i] = newAuto;
        }

       /* {
            new Automobile(5, "Toyota", 2015, 17000),
            new Automobile(7, "Honda", 1900, 1400),
            new Automobile(8, "Honda", 2000, 20000),
            new Automobile(10, "Honda", 2017, 20000),
            new Automobile(11, "Honda", 2009, 13000),
            new Automobile(30, "Toyota", 2016, 30001),
            new Automobile(44, "Honda", 2017, 35000),
            new Automobile(55, "Honda", 2016, 40000)
        };*/

        Array.Sort(autoArray, new AutoComparer());
        
        double total  = 0;
        foreach (Automobile car in autoArray)
        {
            Console.WriteLine(car.ToString());
            total += car.Price;

        }

      Console.WriteLine("Total for all Automobiles is {0}", total.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }

    public static bool HasID(Automobile[] autoArray, int id)
    {
      for (int i = 0; i < autoArray.Length; ++i)
      {
        if(autoArray[i] != null && autoArray[i].IdNumber == id)
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

class AutoComparer : IComparer
{


    int IComparer.Compare(object x, object y)
    {
        Automobile auto1 = (Automobile)x;
        Automobile auto2 = (Automobile)y;

        if (auto1.IdNumber < auto2.IdNumber)
            return -1;
        else if (auto1.IdNumber > auto2.IdNumber)
            return 1;
        else
            return 0;
    }
}
