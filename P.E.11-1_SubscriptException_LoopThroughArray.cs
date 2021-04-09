using System;
using static System.Console;
class SubscriptExceptionTest
{
   static void Main()
   {
      double[] array = {20.3, 44.6, 32.5, 46.7, 89.6,
                    67.5, 12.3, 14.6, 22.1, 13.6};

      int input = 99;
        while (true)
        {
            try
            {
                Console.Write("Enter a number or 99 to quit << ");
                input = int.Parse(Console.ReadLine());
                if (input == 99)
                  break;
                Console.WriteLine("The number in position {0} is {1}", input, array[input]);
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index was outside the bounds of the array.");
            }
        } 
   }
}

