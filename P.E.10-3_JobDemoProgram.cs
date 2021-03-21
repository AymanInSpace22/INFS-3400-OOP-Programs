using System;
using static System.Console;
using System.Globalization;
class JobDemo
{
   static void Main()
   {
     // Your code here
     Job job1 = new Job(111, "Smith", "exterior paint", 20);
     Job job2 = new Job(222, "Bob", "ditch digger", 30);

     WriteLine(job1.ToString() + "\n");
     
     WriteLine(job2.ToString());

     job1.GetHashCode();
   }
    
}

class Job
{
  // auto implemented properties
  public int JobNumber { get; set;}
  public string Customer { get; set;}
  public string Description { get; set;}
 
  // non auto implemented properties
  public int Hours;

  private const double rate = 45.00;

  public double Price 
  {
    get
    {
      return Hours * rate;
    }
  }

  public Job(int jobNumber, string name, string description, int hours)
  {
    this.JobNumber = jobNumber;
    this.Customer = name;
    this.Description = description;
    this.Hours = hours;
  }


  public bool Equals(Job jbObj)
  {
    return jbObj.JobNumber == this.JobNumber;
  }

  public override int GetHashCode()
  {
    return JobNumber;
  }

  public override string ToString()
  {
    return ("Job " + JobNumber + " " + Customer + " " + Description + " " + Hours + " hours @" + rate.ToString("C", CultureInfo.GetCultureInfo("en-US")) + " per hour. Total price is " + Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))); 
  }
}
