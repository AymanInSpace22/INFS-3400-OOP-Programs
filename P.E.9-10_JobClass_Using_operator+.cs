using System;
using static System.Console;
using System.Globalization;
class DemoJobs2
{
   static void Main()
   {
     // Your code here
     Job job1 = new Job();
     Job job2 = new Job();
     Job job3 = new Job();

     job1.Description = "Wash windows";
     job1.Time = 3.5;
     job1.Hourly = 25.00;

     job2.Description = "rake leaves";
     job2.Time = 2;
     job2.Hourly = 18.50;

      job3 = job1 + job2;

      WriteLine("{0} {1}", job3.Hourly, job3.Time);
      

   } 
}

class Job
{
    public string Description {get; set;}
    public double Time {get; set;}
    public double Hourly {get; set;}

    
    public double Average { get; set;}

    public static Job operator +(Job job1, Job job2)
    {
      Job job3 = new Job();
      job3.Time =  (job1.Time + job2.Time);
      job3.Hourly = ((job1.Time * job1.Hourly) + (job2.Time * job2.Hourly)) / job3.Time;
      return job3;
      
    }

}

