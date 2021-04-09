using System;
using static System.Console;
class SwimmingWaterTemperature
{
   static void Main()
   {
       // Your code here
       int degreeFahrenheit;
    while(true)
    {
      try{
            Write("Enter another temperature or 999 to quit");
            degreeFahrenheit = int.Parse(ReadLine());
            if(degreeFahrenheit == 999)
                break;

            if(CheckComfort(degreeFahrenheit))
            {
              WriteLine("{0} degrees is comfortable for swimming.", degreeFahrenheit);
            }
            else
            {
              WriteLine("{0} degrees is not comfortable for swimming.", degreeFahrenheit);
            }
         }catch(ArgumentException ex)
         {
           WriteLine("Value does not fall within the expected range.");       
         }
         
       }
   }
    
    public static bool CheckComfort(int temp)
    {
      // your logic here   
      if(temp < 32 || temp > 212)
        throw new ArgumentException();

      return (temp >= 70 && temp <= 85);

      //if (temp >= 70 && temp <= 85)
      //return true;
          
    }

}
