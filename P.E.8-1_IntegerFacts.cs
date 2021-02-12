using static System.Console;
class IntegerFacts
{
   static void Main()
   {
      // Write your main here
      int[] nums = new int[10];
      
      int numEls = FillArray(nums);

      int sum, low, high;
      double avg;
      Statistics(nums, numEls, out high, out low, out sum, out avg);

      WriteLine("The array has {0} values", numEls);
      WriteLine("The highest value is {0}", high);
      WriteLine("The lowest value is {0}", low);
      WriteLine("The sum of the values is {0}", sum);
      WriteLine("The average is {0}", avg);
   }

   public static int FillArray(int[] array)
   {
     int sentinel = 999;
     int currentNumInts = 0;

     do 
     {
       WriteLine("Enter an integer: ");
       int entry;

       if(int.TryParse(ReadLine(), out entry))
       {
         if(entry == sentinel)
            return currentNumInts;
            
         array[currentNumInts] = entry;
         currentNumInts++;
       }
       else
       {
         WriteLine("Invalid entry - try again");
       }

     }while(currentNumInts < array.Length);
     return currentNumInts;
   }
   public static void Statistics(int[] array, int els, out int high, out int low, out int sum, out double avg)
   {
     if(els == 0) {
       sum = 0;
       low = 0;
       high = 0;
       avg = 0;
       return;
     }

     sum = 0;
     low = array[0];
     high = array[0];

     for(int i = 0; i < els; i++)
     {
       sum += array[i];
       if(array[i] < low)
       {
         low = array[i];
       }
       if(array[i] > high)
       {
         high = array[i];
       }
     }

     avg = (double)sum / (double)els;
   }   

}
