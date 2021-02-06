using System;
using static System.Console;
class AdmissionModularized
{
   static void Main()
   {
      /*double gpa;
      int testScore;
      const double MINGPA = 3.0;
      const int ADMIN1 = 60, ADMIN2 = 80;*/
      string inputString;
      WriteLine("Enter grade point average ");
      inputString = ReadLine();
      double gpa = Convert.ToDouble(inputString);
      WriteLine("Enter test score ");
      inputString = ReadLine();
      int testScore = Convert.ToInt32(inputString);

      string result = AcceptOrReject(gpa, testScore);
      WriteLine(result);
      
   }
    public static string AcceptOrReject(double gpa, int testScore)
   {
    // Write your AcceptOrReject method here.
      const double MINGPA = 3.0;
      const int ADMIN1 = 60, ADMIN2 = 80;
      string result;

    if(gpa >= MINGPA && testScore >= ADMIN1 || testScore >= ADMIN2)
         //if(testScore >= ADMIN1)
            return "Accept";
         else
           return "Reject";
      /*else
         if(testScore >= ADMIN2)
            return "Accept";
         else
            return "Reject";*/
   }
}
