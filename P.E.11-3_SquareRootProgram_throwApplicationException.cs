using System;
using static System.Console;
class FindSquareRoot
{
   static void Main()
   {
        double n;
        double result = 0;
        Console.WriteLine("Enter a value: ");

         //this is not(!) if the user input is not in correct format 
        if (!double.TryParse(Console.ReadLine(), out n)) 
        {
          Console.WriteLine("Invalid Input");
        }
        else
        //this is how you can determine if user input is negative
          if(n < 0)
          {
            //you throw the exception. And then you use a try catch to handle the exception
            throw new ApplicationException("Number can’t be negative.");
          }
          result = Math.Sqrt(n);
        
          
        Console.WriteLine("the square root is "+result);
   }
}
